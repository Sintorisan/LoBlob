using LoBlob.Interfaces;

namespace LoBlob.Services;

internal class BlobService : IBlobService
{
    private readonly IStorageService _storageService;


    internal BlobService(IStorageService storageService)
    {
        _storageService = storageService;
    }
}