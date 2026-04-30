using LoBlob.Models;
using LoBlob.Options;

namespace LoBlob.Interfaces;

internal interface IBlobService
{
    Task<BlobInfo> UploadAsync(BlobUploadOptions options, string containerName);
    Task<BlobInfo> GetUrlAsync(string blobKey);
    Task DeleteAsync(string blobKey);
    Task EnsureContainerAsync(string path);
    Task<List<string>> GetContainerNamesAsync();
}
