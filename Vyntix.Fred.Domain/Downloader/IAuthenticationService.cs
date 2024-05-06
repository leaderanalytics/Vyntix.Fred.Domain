namespace LeaderAnalytics.Vyntix.Fred.Domain.Downloader;

public interface IAuthenticationService
{
    Task<bool> IsAPI_KeyValid();
}
