using Amazon.S3;
using Amazon.S3.Model;
using SabzMarket.Application.Interfaces.Services;
using Microsoft.Extensions.Options;
using SabzMarket.Application.Common.Enums;
using SabzMarket.Infrastructure.Storage.Configuration;

namespace SabzMarket.Infrastructure.Storage;

public class S3FileStorageService(IAmazonS3 s3, IOptionsSnapshot<S3Settings> settings) : IFileStorageService
{
    private readonly string _bucketName = settings.Value.BucketName;
    private readonly string _serviceUrl = settings.Value.ServiceUrl;

    public async Task<string> SaveAsync(Stream fileStream, string fileName, FileFolder fileFolder, long entityId,
        CancellationToken token)
    {
        fileStream.Position = 0;
        var extension = Path.GetExtension(fileName);

        var objectKey = $"{GetFolder(fileFolder, entityId)}/{Guid.CreateVersion7()}{extension}";

        var putRequest = new PutObjectRequest
        {
            BucketName = _bucketName,
            Key = objectKey,
            InputStream = fileStream,
            CannedACL = S3CannedACL.PublicRead,
        };

        await s3.PutObjectAsync(putRequest, token);


        string fileUrl = $"{_serviceUrl}/{_bucketName}/{objectKey}";
        return fileUrl;
    }

    public async Task DeleteAsync(string fileUrl, CancellationToken token)
    {
        var objectKey = fileUrl.Replace(
            $"{_serviceUrl}/{_bucketName}/",
            string.Empty);

        var request = new DeleteObjectRequest
        {
            BucketName = _bucketName,
            Key = objectKey
        };

        await s3.DeleteObjectAsync(request, token);
    }

    private static string GetFolder(FileFolder fileFolder, long entityId) => fileFolder switch
    {
        FileFolder.FarmerProfile => $"farmers/{entityId}/profile",
        FileFolder.SellerProfile => $"sellers/{entityId}/profile",
        FileFolder.ProductImage => $"products/{entityId}/image",
        _ => throw new ArgumentOutOfRangeException(nameof(fileFolder), fileFolder, null)
    };
}