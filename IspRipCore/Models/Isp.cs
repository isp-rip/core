namespace IspRipCore.Models;

public class Isp
{
    public Guid Id { get; set; }
    public IspStatus Status { get; set; }
    public string Country { get; set; } = "unknown";
    public string Name { get; set; } = "";
    public string Logo { get; set; } = "";
    public string Url { get; set; } = "";
}