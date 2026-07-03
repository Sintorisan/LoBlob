using LoBlob.Interfaces;

namespace LoBlob.Services;

internal class ContainerClientService
{
    private readonly IStorageGateway _gateway;


    internal ContainerClientService(IStorageGateway gateway)
    {
        _gateway = gateway;
    }

    public Task EnsureContainerExistsAsync(string containerName)
    {
        throw new NotImplementedException();
    }

    internal async Task InitializeContainerServiceAsync(string containerName)
    {
        throw new NotImplementedException();
    }
}