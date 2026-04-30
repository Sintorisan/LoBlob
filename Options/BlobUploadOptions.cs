using System.ComponentModel.DataAnnotations;

namespace LoBlob.Options;

public class BlobUploadOptions
{
    [Required]
    public required string FileName { get; set; }
    [Required]
    public required string FileContent { get; set; }
    public bool IsPrivate { get; set; }
}
