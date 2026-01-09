namespace Catalog.Data;

public interface IAppContext
{
    Guid UserId { get; }
    string? Email { get; }
    bool IsAuthenticated { get; }
    string? IpAddr { get; }
}