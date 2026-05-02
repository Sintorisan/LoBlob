
using LoBlob.Interfaces;

namespace LoBlob.Clients;

public class BlobClient
{
    private readonly IBlobService _blobService;

    internal BlobClient(IBlobService blobService)
    {
        _blobService = blobService;
    }

    public async Task<BlobContainerClient> CreateContainerClient(string containerName)
    {
        var client = new BlobContainerClient(containerName, _blobService);
        return await client.InitializeContainerAsync();
    }

    public async Task<List<string>> GetContainerNamesAsync()
    {
        var containers = await _blobService.GetContainerNamesAsync();
        return containers;
    }
}
