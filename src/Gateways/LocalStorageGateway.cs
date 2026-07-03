using LoBlob.Interfaces;
using LoBlob.Options;
using Microsoft.Extensions.Options;

namespace LoBlob.Gateways;

internal class LocalStorageGateway : IStorageGateway
{
    private readonly BlobStorageOptions _opt;

    public LocalStorageGateway(IOptions<BlobStorageOptions> opt)
    {
        _opt = opt.Value;
    }

    public Task CreateBlobServiceAsync(string blobName)
    {
        throw new NotImplementedException();
    }

    public bool IsExistingBlob(string blobName)
    {
        throw new NotImplementedException();
    }
}
