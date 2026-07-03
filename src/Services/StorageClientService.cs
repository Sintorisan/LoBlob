using LoBlob.Interfaces;

namespace LoBlob.Services;

internal class StorageClientService
{
    private readonly IStorageGateway _gateway;


    internal StorageClientService(IStorageGateway gateway)
    {
        _gateway = gateway;
    }
}