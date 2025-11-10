using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using SabzMarket.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabzMarket.BLL
{
    public class SavePhoto: IDisposable
    {
        private const string accessKey = "36be0a0e-838c-4040-827c-ba415160709e";
        private const string secretKey = "cb1cc9b5a26b8ddbd747eb843f3eb7022eae2d86eee4ac496428b2170f9cfa6d";
        private const string bucketName = "sabzmarket";
        private const string serviceURL = "https://s3.ir-thr-at1.arvanstorage.ir";
        private readonly IAmazonS3 _s3Client;
        public SavePhoto()
        {
            var config = new AmazonS3Config
            {
                ServiceURL = serviceURL,
                ForcePathStyle = true, // برای Arvan ضروریه
                AuthenticationRegion = "ir-thr-at1"
            };

            var credentials = new BasicAWSCredentials(accessKey, secretKey);
            _s3Client = new AmazonS3Client(credentials, config);
        }

        public void Dispose()
        {
            _s3Client.Dispose();
        }

        public async Task<OperationResult> SaveAsync(string filePath)
        {
            try
            {
                string objectKey = Path.GetFileName(filePath).Replace(" ", "_");

                var putRequest = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = objectKey,
                    FilePath = filePath,
                    CannedACL = S3CannedACL.PublicRead // فایل Public بشه
                };

                await _s3Client.PutObjectAsync(putRequest);

                string fileUrl = $"{serviceURL}/{bucketName}/{objectKey}";
                return OperationResult.Successed(true, fileUrl);
            }
            catch (Exception ex)
            {
                return OperationResult.Failed(GetType().Name,ex);
            }
        }
    }
}
