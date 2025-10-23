using SabzMarketShare;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarketBLL
{
    public class SavePhoto
    {
        private const string accessKey = "36be0a0e-838c-4040-827c-ba415160709e";
        private const string secretKey = "c9348c66b682e2e7178bb766b48e31f03d006826f0089f2f179d82bde6983ef5";
        private const string bucketName = "sabzmarket";
        private const string region = "ir-thr-at1";
        private const string service = "s3";
        private const string serviceURL = "https://sabzmarket.s3.ir-thr-at1.arvanstorage.ir";
        public async Task<OperationResult> Save(string filePath)
        {

            string objectKey = Path.GetFileName(filePath).Replace(" ", "_");

            try
            {
                string url = await UploadFile(filePath, objectKey);
                return OperationResult.Successed(url);
            }
            catch (Exception ex)
            {
                return OperationResult.Failed(MessageDTO.notSavePhoto);
            }


        }
        private async Task<string> UploadFile(string filePath, string objectKey)
        {

            byte[] fileBytes = File.ReadAllBytes(filePath);

            DateTime now = DateTime.UtcNow;
            string amzDate = now.ToString("yyyyMMddTHHmmssZ");
            string dateStamp = now.ToString("yyyyMMdd");

            string host = "sabzmarket.s3.ir-thr-at1.arvanstorage.ir";
            string canonicalUri = $"/{objectKey}";
            string payloadHash = ToHex(Hash(fileBytes));

            string canonicalHeaders =
                $"host:{host}\n" +
                $"x-amz-content-sha256:{payloadHash}\n" +
                $"x-amz-date:{amzDate}\n";

            string signedHeaders = "host;x-amz-content-sha256;x-amz-date";

            string canonicalRequest =
                $"PUT\n{canonicalUri}\n\n{canonicalHeaders}\n{signedHeaders}\n{payloadHash}";

            string algorithm = "AWS4-HMAC-SHA256";
            string credentialScope = $"{dateStamp}/{region}/{service}/aws4_request";
            string stringToSign =
                $"{algorithm}\n{amzDate}\n{credentialScope}\n{ToHex(Hash(Encoding.UTF8.GetBytes(canonicalRequest)))}";

            byte[] signingKey = GetSignatureKey(secretKey, dateStamp, region, service);
            string signature = ToHex(HmacSHA256(signingKey, stringToSign));

            string authorizationHeader =
                $"{algorithm} Credential={accessKey}/{credentialScope}, SignedHeaders={signedHeaders}, Signature={signature}";

            var client = new HttpClient();
            var content = new ByteArrayContent(fileBytes);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");

            var request = new HttpRequestMessage(HttpMethod.Put, $"{serviceURL}/{objectKey}")
            {
                Content = content
            };

            // 🟢 هدرهای ضروری
            request.Headers.TryAddWithoutValidation("x-amz-date", amzDate);
            request.Headers.TryAddWithoutValidation("x-amz-content-sha256", payloadHash);
            request.Headers.TryAddWithoutValidation("Authorization", authorizationHeader);
            request.Headers.TryAddWithoutValidation("x-amz-acl", "public-read"); // 👈 فایل Public میشه

            var response = await client.SendAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                string errorDetails = await response.Content.ReadAsStringAsync();
                throw new Exception($"❌ خطا در آپلود: {response.StatusCode}\n{errorDetails}");
            }

            return $"{serviceURL}/{objectKey}";
        }





        // ---------------- 🟢 متدهای کمکی ----------------

        // هش SHA256
        static byte[] Hash(byte[] data)
        {
            using (var sha256 = SHA256.Create())
                return sha256.ComputeHash(data);
        }

        // امضا با HMAC-SHA256
        static byte[] HmacSHA256(byte[] key, string data)
        {
            using (var hmac = new HMACSHA256(key))
                return hmac.ComputeHash(Encoding.UTF8.GetBytes(data));
        }

        // تبدیل بایت → رشته هگز
        static string ToHex(byte[] data, bool lowerCase = true)
        {
            return BitConverter.ToString(data)
                               .Replace("-", "")
                               .ToLower();
        }

        // ساخت کلید نهایی امضا
        static byte[] GetSignatureKey(string key, string dateStamp, string regionName, string serviceName)
        {
            byte[] kDate = HmacSHA256(Encoding.UTF8.GetBytes("AWS4" + key), dateStamp);
            byte[] kRegion = HmacSHA256(kDate, regionName);
            byte[] kService = HmacSHA256(kRegion, serviceName);
            return HmacSHA256(kService, "aws4_request");
        }
    }
}
