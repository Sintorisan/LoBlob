using System.ComponentModel;
using System.Runtime.CompilerServices;
using LoBlob.Interfaces;
using LoBlob.Services;

namespace LoBlob.Clients;

public class BlobClient
{
    private readonly IBlobService _blobService;
    private string _blobName;

    internal BlobClient(string blobName, IStorageService storageService)
    {
        _blobService = new BlobService(storageService);
        _blobName = blobName;
    }


    internal async Task<BlobClient> InitializeBlobClientAsync()
    {
        var blob = _blobService.GetBlobClientDataAsync(_blobName);
        return this;
    }
}