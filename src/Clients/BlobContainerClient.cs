using LoBlob.Interfaces;
using LoBlob.Services;

namespace LoBlob.Clients;

public class BlobContainerClient
{
    private readonly IStorageService _storageService;
    private readonly IContainerService _containerService;
    private string _containerName;


    internal BlobContainerClient(string containerName, IStorageService storageService)
    {
        _containerName = containerName;
        _storageService = storageService;
        _containerService = new ContainerService(storageService);
    }

    internal async Task<BlobContainerClient> InitializeContainerAsync()
    {
        await _containerService.EnsureContainerExistsAsync(_containerName);
        return this;
    }

    public async Task<BlobClient> CreateBlobClientAsync(string blobName)
    {
        var client = new BlobClient(blobName, _storageService);
        return await client.InitializeBlobClientAsync();
    }
}