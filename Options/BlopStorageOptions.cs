using System.ComponentModel.DataAnnotations;

namespace LoBlob.Options;

public class BlobStorageOptions
{
    public Uri? BaseUrl { get; set; }
    public string? BasePath { get; set; }
    [Required]
    public required string Tenant { get; set; }
}
