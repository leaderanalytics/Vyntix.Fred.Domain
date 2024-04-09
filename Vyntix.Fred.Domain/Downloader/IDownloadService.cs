namespace LeaderAnalytics.Vyntix.Fred.Domain.Downloader;

public interface IDownloadService
{
    Task<APIResult> Download(FredDownloadArgs args, Action<string> statusCallback);
}
