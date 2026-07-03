using LoBlob.Interfaces;
using LoBlob.Models;
using LoBlob.Services;

namespace LoBlob.Clients;

public class BlobContainerClient
{
    private readonly ContainerClientService _clientService;
    private readonly IStorageGateway _gateway;

    public string ContainerName { get; init; }

    internal BlobContainerClient(IStorageGateway gateway, string containerName)
    {
        _gateway = gateway;
        _clientService = new ContainerClientService(gateway);
        ContainerName = containerName;
    }

    public Task<bool> CreateIfNotExistsAsync()
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<BlobStorageResponse<List<BlobClient>>>> ListBlobClientsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<BlobStorageResponse<List<string>>>> ListBlobNamesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<BlobClient> GetBlobClient(string blobName)
    {
        throw new NotImplementedException();
    }

    public Task<BlobStorageResponse<bool>> UploadBlobAsync(string blobName, FileStream stream, bool overwrite = true)
    {
        throw new NotImplementedException();
    }

    public Task<BlobStorageResponse<bool>> DeleteBlobAsync(string blobName)
    {
        throw new NotImplementedException();
    }
}