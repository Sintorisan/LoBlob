using LoBlob.Interfaces;
using LoBlob.Models;

namespace LoBlob.Extensions;

internal class LocalBlobStorage : IBlobStorage
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
