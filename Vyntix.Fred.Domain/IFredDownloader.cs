namespace LeaderAnalytics.Vyntix.Fred.Domain;

public interface IFredDownloader
{
    IDownloadJobStatistics JobStatistics { get; }
    Task<DownloadResult> Download(FredDownloadJobArgs jobArgs);
    void Cancel();
}