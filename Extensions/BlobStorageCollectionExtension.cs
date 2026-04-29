using LoBlob.BlobStorages;
using LoBlob.Interfaces;
using LoBlob.Options;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace LoBlob.Extensions;

public static class BlobStorageCollectionExtension
{
    public static IServiceCollection AddLocalBlobStorage(this IServiceCollection services, Action<BlobStorageOptions>? options = null)
    {
        var defaultPath = SetDefaultLocalBlobUrl();
        services.SetDefaultConfig(defaultPath);

        if (options != null)
        {
            services.PostConfigure<BlobStorageOptions>(options);
        }

        services.AddSingleton<IBlobStorage, LocalBlobStorage>();

        return services;
    }

    public static IServiceCollection AddHttpBlobStorage(this IServiceCollection services, Action<BlobStorageOptions>? options = null)
    {
        var defaultPath = "http://localhost:5001";
        services.SetDefaultConfig(defaultPath);

        if (options != null)
        {
            services.PostConfigure<BlobStorageOptions>(options);
        }

        services.AddScoped<IBlobStorage, HttpBlobStorage>();

        return services;
    }

    private static IServiceCollection SetDefaultConfig(this IServiceCollection services, string baseUrl)
    {
        return services.Configure<BlobStorageOptions>(options =>
            {
                options.BaseUrl = baseUrl;
                options.Container = "storage";
            });
    }

    private static string SetDefaultLocalBlobUrl()
    {
        var projectName = Assembly.GetExecutingAssembly().GetName().Name ?? "unknown";
        var currentDir = Directory.GetCurrentDirectory();
        var rootDir = Directory.GetDirectoryRoot(currentDir);
        var blobPath = Path.Combine(rootDir, "blob-storage", projectName);

        if (!Directory.Exists(blobPath))
        {
            Directory.CreateDirectory(blobPath);
        }

        return blobPath;
    }

}
