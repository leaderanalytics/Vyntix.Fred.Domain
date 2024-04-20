using System.Threading;

namespace LeaderAnalytics.Vyntix.Fred.Domain.Downloader;

public interface IReleasesService
{
    Task<RowOpResult> DownloadAllReleaseDates(CancellationToken? cancellationToken);
    Task<RowOpResult> DownloadAllReleases(CancellationToken? cancellationToken);
    Task<RowOpResult> DownloadAllSources(CancellationToken? cancellationToken);
    Task<RowOpResult> DownloadRelease(string releaseID, CancellationToken? cancellationToken);
    Task<RowOpResult> DownloadReleaseDates(string releaseID, CancellationToken? cancellationToken);
    Task<RowOpResult> DownloadReleaseSeries(string releaseID, CancellationToken? cancellationToken);
    Task<RowOpResult> DownloadReleaseForSeries(string symbol, CancellationToken? cancellationToken, bool saveChanges = true);
    Task<RowOpResult> DownloadReleaseSources(string releaseID, CancellationToken? cancellationToken);
    Task<RowOpResult> DownloadSource(string sourceID, CancellationToken? cancellationToken);
    Task<RowOpResult> DownloadSourceReleases(string sourceID, CancellationToken? cancellationToken);
    Task<RowOpResult> SaveRelease(FredRelease release, bool saveChanges = true);
    Task<RowOpResult> SaveReleaseDate(FredReleaseDate releaseDate, bool saveChanges = true);
    Task<RowOpResult> SaveSource(FredSource source, bool saveChanges = true);
}