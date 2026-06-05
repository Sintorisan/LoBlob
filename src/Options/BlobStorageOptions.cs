namespace LoBlob.Options;

public class BlobStorageOptions
{
    public required string StorageName { get; init; }
    public required string Location { get; init; }
    public string? AccessKey { get; init; }
}