using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.Share
{
    public static class CurlHelper
    {
        /// <summary>
        /// تبدیل HttpRequestMessage به دستور curl (async)
        /// </summary>
        public static async Task<string> ToCurlAsync(this HttpRequestMessage request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            var parts = new List<string> { "curl" };

            // متد HTTP
            parts.Add($"-X {request.Method.Method.ToUpperInvariant()}");

            // هدرها
            AppendHeaders(parts, request.Headers);
            if (request.Content?.Headers != null)
                AppendHeaders(parts, request.Content.Headers);

            // بدنه
            if (request.Content != null)
            {
                string? body = await SafeReadContentAsync(request.Content).ConfigureAwait(false);
                if (!string.IsNullOrWhiteSpace(body))
                {
                    string escapedBody = EscapeForSingleQuotedString(body);
                    parts.Add($"--data-raw '{escapedBody}'");
                }
            }

            // URL
            string url = request.RequestUri?.ToString() ?? "";
            parts.Add($"\"{EscapeForDoubleQuotedString(url)}\"");

            // خروجی زیبا
            return string.Join(" \\\n  ", parts);
        }

        /// <summary>
        /// نسخه sync
        /// </summary>
        public static string ToCurl(HttpRequestMessage request)
            => ToCurlAsync(request).GetAwaiter().GetResult();

        // =================== متدهای داخلی ===================

        private static void AppendHeaders(ICollection<string> parts, HttpHeaders headers)
        {
            foreach (var header in headers)
            {
                foreach (var value in header.Value)
                {
                    if (header.Key.Equals("Host", StringComparison.OrdinalIgnoreCase) ||
                        header.Key.Equals("Content-Length", StringComparison.OrdinalIgnoreCase))
                        continue;

                    string escapedValue = EscapeForDoubleQuotedString(value.Trim());
                    parts.Add($"-H \"{header.Key}: {escapedValue}\"");
                }
            }
        }

        private static async Task<string?> SafeReadContentAsync(HttpContent content)
        {
            try
            {
                return await content.ReadAsStringAsync().ConfigureAwait(false);
            }
            catch
            {
                return "[Unable to read body]";
            }
        }

        private static string EscapeForDoubleQuotedString(string s)
            => s?.Replace("\\", "\\\\").Replace("\"", "\\\"") ?? string.Empty;

        private static string EscapeForSingleQuotedString(string s)
            => s?.Replace("'", "'\"'\"'") ?? string.Empty;
    }
}

