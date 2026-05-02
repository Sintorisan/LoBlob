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

    public async Task<BlobUploadResponse> UploadBlobAsync(Stream stream, BlobUploadOptions options)
    {
        options.ContainerName = _containerName;
        var respons = await _blobService.UploadAsync(stream, options);
        return respons;
    }

    public async Task<BlobUploadResponse> UploadBlobAsync(string path, BlobUploadOptions options)
    {
        await using FileStream stream = new FileStream(
            path,
            FileMode.Open,
            FileAccess.Read,
            FileShare.Read,
            bufferSize: 81320,
            useAsync: true
            );

        options.ContainerName = _containerName;
        var respons = await _blobService.UploadAsync(stream, options);

        return respons;
    }


    public async Task<BlobUploadResponse> GetBlobUrlAsync(string blobKey)
    {
        var respons = await _blobService.GetUrlAsync(blobKey);
        return respons;
    }

    public async Task DeleteBlobAsync(string blobKey)
    {
        await _blobService.DeleteAsync(blobKey);
    }
}
