using LoBlob.Clients;
using LoBlob.Gateways;
using LoBlob.Interfaces;
using LoBlob.Options;
using LoBlob.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace LoBlob.Extensions;

public static class BlobStorageCollectionExtension
{
    public static IServiceCollection AddLocalBlobStorage(this IServiceCollection services, Action<BlobStorageOptions> options)
    {
        services.Configure(options);

        services.AddScoped<IStorageGateway, LocalStorageGateway>();
        services.AddScoped<BlobStorageClient>();

        return services;
    }

    public static IServiceCollection AddHttpBlobStorage(this IServiceCollection services, Action<BlobStorageOptions> configure)
    {
        services.Configure(configure);

        services.AddHttpClient<IStorageGateway, HttpStorageGateway>((sp, client) =>
        {
            var opt = sp.GetRequiredService<IOptions<BlobStorageOptions>>().Value;
            client.BaseAddress = new Uri($"{opt.Location}/{opt.StorageName}");
        });
        services.AddScoped<BlobStorageClient>();

        return services;
    }
}
