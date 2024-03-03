namespace LeaderAnalytics.Vyntix.Fred.Domain.Downloader;

public interface IReleasesService
{
    Task<RowOpResult> DownloadAllReleaseDates();
    Task<RowOpResult> DownloadAllReleases();
    Task<RowOpResult> DownloadAllSources();
    Task<RowOpResult> DownloadRelease(string releaseID);
    Task<RowOpResult> DownloadReleaseDates(string releaseID);
    Task<RowOpResult> DownloadReleaseSeries(string releaseID);
    Task<RowOpResult> DownloadReleaseForSeries(string symbol, bool saveChanges = true);
    Task<RowOpResult> DownloadReleaseSources(string releaseID);
    Task<RowOpResult> DownloadSource(string sourceID);
    Task<RowOpResult> DownloadSourceReleases(string sourceID);
    Task<RowOpResult> SaveRelease(FredRelease release, bool saveChanges = true);
    Task<RowOpResult> SaveReleaseDate(FredReleaseDate releaseDate, bool saveChanges = true);
    Task<RowOpResult> SaveSource(FredSource source, bool saveChanges = true);
}