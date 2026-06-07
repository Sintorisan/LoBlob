namespace LoBlob.Interfaces;

internal interface IBlobService
{
    object GetBlobClientDataAsync(string blobName);
}