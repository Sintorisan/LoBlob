namespace LoBlob.Models;

public class BlobUploadResponse
{
    public BlobInfo? Blob { get; set; }
    public bool IsSuccess { get; set; }
    public string Message { get; set; } = string.Empty;

    public static BlobUploadResponse Success(BlobInfo blob) => new BlobUploadResponse { Blob = blob, IsSuccess = true };
    public static BlobUploadResponse Failure(string message) => new BlobUploadResponse { IsSuccess = false, Message = message };
}
