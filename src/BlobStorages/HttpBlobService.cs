using LoBlob.Interfaces;
using LoBlob.Models;
using LoBlob.Options;
using Microsoft.Extensions.Options;

namespace LoBlob.BlobStorages;

internal class HttpBlobService : IBlobService
{
    private readonly BlobStorageOptions _options;

    internal HttpBlobService(IOptions<BlobStorageOptions> options)
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

    public Task<BlobUploadResponse> UploadAsync(Stream stream, BlobUploadOptions options)
    {
        throw new NotImplementedException();
    }
}
