using LoBlob.Interfaces;
using LoBlob.Models;
using LoBlob.Options;
using Microsoft.Extensions.Options;

namespace LoBlob.Extensions;

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

    public Task<BlobInfo> GetUrlAsync(string blobKey)
    {
        throw new NotImplementedException();
    }

    public Task<BlobInfo> UploadAsync(Stream stream, BlobUploadOptions options, string containerName)
    {
        throw new NotImplementedException();
    }
}
