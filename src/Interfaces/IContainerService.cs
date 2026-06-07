using LoBlob.Models;

namespace LoBlob.Interfaces;

internal interface IContainerService
{
    Task EnsureContainerExistsAsync(string containerName);

}