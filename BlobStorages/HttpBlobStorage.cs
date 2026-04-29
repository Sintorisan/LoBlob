using LoBlob.Interfaces;
using LoBlob.Models;

namespace LoBlob.BlobStorages;

internal class HttpBlobStorage : IBlobStorage
{
    public Task DeleteAsync(string blobKey)
    {
        throw new NotImplementedException();
    }

    public Task<BlobResponse> GetUrlAsync(string blobKey)
    {
        throw new NotImplementedException();
    }

    public Task<BlobResponse> UploadAsync(Stream stream, string fileName, string fileType)
    {
        throw new NotImplementedException();
    }
}
