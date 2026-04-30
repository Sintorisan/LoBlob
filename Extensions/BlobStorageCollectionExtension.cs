using LoBlob.BlobStorages;
using LoBlob.Clients;
using LoBlob.Interfaces;
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
            services.Configure<BlobStorageOptions>(options);
        }

        services.PostConfigure<BlobStorageOptions>(opt =>
        {
            opt.BasePath ??= SetDefaultLocalBlobPath();
            opt.Tenant ??= AppDomain.CurrentDomain.FriendlyName;
        });

        services.AddSingleton<IBlobService, LocalBlobService>();
        services.AddSingleton<BlobClient>();

        return services;
    }

    public static IServiceCollection AddHttpBlobStorage(this IServiceCollection services, Action<BlobStorageOptions>? configure = null)
    {
        var baseUrl = new Uri("http://localhost:5001");
        if (configure != null)
        {
            services.Configure(configure);
        }

        services.PostConfigure<BlobStorageOptions>(opt =>
        {
            opt.BaseUrl ??= baseUrl;
            opt.Tenant ??= AppDomain.CurrentDomain.FriendlyName;
        });

        services.AddHttpClient<IBlobService, HttpBlobService>((sp, client) =>
        {
            var opt = sp.GetRequiredService<IOptions<BlobStorageOptions>>().Value;
            client.BaseAddress = new Uri(opt.BaseUrl ?? baseUrl, $"{opt.Tenant}/");
        });

        services.AddSingleton<BlobClient>();

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
