using LoBlob.Interfaces;

namespace LoBlob.Gateways;

internal class HttpStorageGateway : IStorageGateway
{
    public Task CreateBlobServiceAsync(string blobName)
    {
        throw new NotImplementedException();
    }

    public bool IsExistingBlob(string blobName)
    {
        throw new NotImplementedException();
    }
}
