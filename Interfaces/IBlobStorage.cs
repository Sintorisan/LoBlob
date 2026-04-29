using LoBlob.Models;

namespace LoBlob.Interfaces;

public interface IBlobStorage
{
    Task<BlobResponse> UploadAsync(Stream stream, string fileName, string fileType);
    Task<BlobResponse> GetUrlAsync(string blobKey);
    Task DeleteAsync(string blobKey);
}
