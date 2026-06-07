using LoBlob.Interfaces;

namespace LoBlob.Services;

internal class ContainerService : IContainerService
{
    private readonly IStorageService _storageService;

    internal ContainerService(IStorageService storageService)
    {
        _storageService = storageService;
    }

    public Task EnsureContainerExistsAsync(string containerName)
    {
        throw new NotImplementedException();
    }
}