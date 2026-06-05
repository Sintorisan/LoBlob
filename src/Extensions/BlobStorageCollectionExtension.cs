using LoBlob.Clients;
using LoBlob.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace LoBlob.Extensions;

public static class BlobStorageCollectionExtension
{
    public static IServiceCollection AddLocalBlobStorage(this IServiceCollection services, Action<BlobStorageOptions>? options = null)
    {
        if (options != null)
        {
            services.Configure(options);
        }

        services.AddScoped<BlobServiceClient>();

        return services;
    }

    public static IServiceCollection AddHttpBlobStorage(this IServiceCollection services, Action<BlobStorageOptions>? configure = null)
    {
        if (configure != null)
        {
            services.Configure(configure);
        }

        services.AddHttpClient<IBlobService, HttpBlobService>((sp, client) =>
        {
            var opt = sp.GetRequiredService<IOptions<BlobStorageOptions>>().Value;
            client.BaseAddress = new Uri(opt.Location, $"{opt.StorageName}/");
        });

        services.AddScoped<BlobServiceClient>();

        return services;
    }

    private static string SetDefaultLocalBlobPath()
    {
        var basePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "LoBlob"
        );

        Directory.CreateDirectory(basePath);

        return basePath;
    }

}
