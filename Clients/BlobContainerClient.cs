using LoBlob.Interfaces;
using LoBlob.Models;
using LoBlob.Options;

namespace LoBlob.Clients;

public class BlobContainerClient
{
    private readonly IBlobService _blobService;
    private string _containerName = string.Empty;

    internal BlobContainerClient(string containerName, IBlobService blobService)
    {
        _containerName = containerName;
        _blobService = blobService;
    }

    internal async Task<BlobContainerClient> InitializeContainerAsync()
    {
        await _blobService.EnsureContainerAsync(_containerName);
        return this;
    }

    public async Task<BlobInfo> UploadBlobAsync(BlobUploadOptions options)
    {
        var respons = await _blobService.UploadAsync(options, _containerName);
        return respons;
    }

    public async Task<BlobInfo> GetBlobUrlAsync(string blobKey)
    {
        var respons = await _blobService.GetUrlAsync(blobKey);
        return respons;
    }

    public async Task DeleteBlobAsync(string blobKey)
    {
        await _blobService.DeleteAsync(blobKey);
    }
}
