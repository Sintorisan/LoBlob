using LoBlob.Interfaces;
using LoBlob.Services;

namespace LoBlob.Clients;

public class BlobClient
{
    private readonly BlobClientService _clientService;

    public string ContainerName { get; init; }
    public string BlobName { get; init; }

    private string location => $"{ContainerName}/{BlobName}";

    internal BlobClient(IStorageGateway gateway, string containerName, string blobName)
    {
        _clientService = new BlobClientService(gateway);
        ContainerName = containerName;
        BlobName = blobName;
    }

    public Task UploadAsync(FileStream stream)
    {
        throw new NotImplementedException();
    }
    public Task DownloadAsync()
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync()
    {
        throw new NotImplementedException();
    }

    public Task ExistsAsync()
    {
        throw new NotImplementedException();
    }

    public Task GetPropertiesAsync()
    {
        throw new NotImplementedException();
    }

    public Task SetMetadataAsync(Dictionary<string, string> metadata)
    {
        throw new NotImplementedException();
    }

}