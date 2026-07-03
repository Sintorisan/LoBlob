using LoBlob.Interfaces;
using LoBlob.Models;
using LoBlob.Services;

namespace LoBlob.Clients;

public class BlobStorageClient
{
    private readonly IStorageGateway _gateway;
    private readonly StorageClientService _clientService;

    internal BlobStorageClient(IStorageGateway gateway)
    {
        _gateway = gateway;
        _clientService = new StorageClientService(gateway);
    }

    public async Task<BlobContainerClient> GetContainerClient(string containerName)
    {
        throw new NotImplementedException();
    }

    public async Task<BlobContainerClient> CreateContainerAsync(string containerName)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteContainerAsync(string containerName)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> ContainerExistsAsync(string containerName)
    {
        throw new NotImplementedException();
    }

    public async Task<BlobStorageResponse<List<BlobContainerClient>>> ListContainersAsync()
    {
        throw new NotImplementedException();
    }
}

