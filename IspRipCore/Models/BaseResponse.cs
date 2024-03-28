namespace IspRipCore.Models;

public class BaseResponse
{
    public bool Success { get; set; }
    public string? Error { get; set; }
}

public class BaseResponse<T> : BaseResponse
{
    public T? Data { get; set; }
}