namespace LoBlob.Models;

internal class Blob
{
    public string BlobKey { get; set; } = string.Empty;
    public bool IsPrivate { get; set; }
    public string Location { get; set; } = string.Empty;
}
