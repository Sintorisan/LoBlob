using LoBlob.Interfaces;

namespace LoBlob.Services;

internal class BlobClientService
{
    private readonly IStorageGateway _gateway;


    internal BlobClientService(IStorageGateway gateway)
    {
        _gateway = gateway;
    }
}
