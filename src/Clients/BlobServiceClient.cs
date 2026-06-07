using LoBlob.Interfaces;

namespace LoBlob.Clients;

public class BlobServiceClient
{
    private readonly IStorageService _storageService;

    internal BlobServiceClient(IStorageService storageService)
    {
        _storageService = storageService;
    }

    public async Task<BlobContainerClient> CreateContainerClientAsync(string containerName)
    {
        var client = new BlobContainerClient(containerName, _storageService);
        return await client.InitializeContainerAsync();
    }
}