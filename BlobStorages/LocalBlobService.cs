using LoBlob.Interfaces;
using LoBlob.Models;
using LoBlob.Options;
using Microsoft.Extensions.Options;

namespace LoBlob.BlobStorages;

internal class LocalBlobStorage : IBlobService
{
    private readonly BlobStorageOptions _options;

    internal LocalBlobStorage(IOptions<BlobStorageOptions> options)
    {
        _options = options.Value;
    }

    public Task DeleteAsync(string blobKey)
    {
        throw new NotImplementedException();
    }

    public Task EnsureContainerAsync(string path)
    {
        throw new NotImplementedException();
    }

    public Task<List<string>> GetContainerNamesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<BlobUploadResponse> GetUrlAsync(string blobKey)
    {
        throw new NotImplementedException();
    }

    public async Task<BlobUploadResponse> UploadAsync(Stream stream, BlobUploadOptions uploadOpt)
    {
        var dir = GetDirectory(uploadOpt);

        if (!uploadOpt.Overwrite && File.Exists(dir))
        {
            return BlobUploadResponse.Failure("Blob with same name exists in container.");
        }

        await WriteToDestination(stream, dir);

        var blob = new Blob
        {
            BlobKey = uploadOpt.FileName + Guid.NewGuid(),
            Location = dir
        };


        return BlobUploadResponse.Success(new BlobInfo { });
    }

    private string GetDirectory(BlobUploadOptions blobOpt)
    {
        var dir = Path.Combine(_options.BasePath!, _options.Tenant, blobOpt.ContainerName, blobOpt.FileName);
        return dir;
    }

    private async Task WriteToDestination(Stream source, string destinationPath)
    {
        await using var destination = new FileStream(
                destinationPath,
                FileMode.Create,
                FileAccess.Write,
                FileShare.None,
                bufferSize: 81920,
                useAsync: true);

        await source.CopyToAsync(destination);
    }

}
