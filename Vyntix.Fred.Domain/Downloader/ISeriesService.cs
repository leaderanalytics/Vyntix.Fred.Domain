namespace LeaderAnalytics.Vyntix.Fred.Domain.Downloader;

public interface ISeriesService
{
    Task<List<RowOpResult>> DownloadSeries(string[] symbols, string releaseID = null);
    Task<RowOpResult> DownloadSeries(string symbol, string releaseID = null);
    Task<RowOpResult> DownloadCategoriesForSeries(string symbol);
    Task<RowOpResult> DownloadSeriesRelease(string symbol);
    Task<RowOpResult> DownloadSeriesTags(string symbol);
    Task<RowOpResult> DeleteSeriesTagsForSymbol(string symbol);
    Task<RowOpResult> DownloadSeriesIfItDoesNotExist(string symbol);
    Task<RowOpResult> SaveSeries(FredSeries series, bool saveChanges = true);
    Task<RowOpResult> SaveSeriesCategory(FredSeriesCategory seriesCategory, bool saveChanges = true);
    Task<RowOpResult<List<FredSeries>>> GetLocalSeries(int skip, int take, string searchTitle);
    Task<int> GetSeriesCount();
    Task<RowOpResult> DeleteSeriesCategoriesForSymbol(string symbol);
    Task<RowOpResult> DeleteSeries(string symbol);
}
