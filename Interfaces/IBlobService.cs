using LoBlob.Models;
using LoBlob.Options;

namespace LoBlob.Interfaces;

internal interface IBlobService
{
    Task<BlobUploadResponse> UploadAsync(Stream stream, BlobUploadOptions options);
    Task<BlobUploadResponse> GetUrlAsync(string blobKey);
    Task DeleteAsync(string blobKey);
    Task EnsureContainerAsync(string path);
    Task<List<string>> GetContainerNamesAsync();
}
