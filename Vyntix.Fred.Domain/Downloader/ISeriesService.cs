namespace LeaderAnalytics.Vyntix.Fred.Domain.Downloader;

public interface ISeriesService
{
    Task<List<RowOpResult>> DownloadSeries(string[] symbols, string releaseID = null);
    Task<RowOpResult> DownloadSeries(string symbol, string releaseID = null);
    Task<RowOpResult> DownloadSeriesRelease(string symbol);
    Task<RowOpResult> DownloadSeriesTags(string symbol);
    Task<RowOpResult> DeleteSeriesTagsForSymbol(string symbol);
    Task<RowOpResult<FredSeries>> DownloadSeriesIfItDoesNotExist(string symbol);
    Task<RowOpResult> SaveSeries(FredSeries series, bool saveChanges = true);
    Task<RowOpResult> SaveSeriesCategory(FredSeriesCategory seriesCategory, bool saveChanges = true);
    Task<List<FredSeries>> GetLocalSeries(string? searchSymbol = null, string? searchTitle = null, string? sortExpression = null, bool sortAscending = true, int skip = 0, int take = int.MaxValue);
    Task<List<FredSeries>> GetLocalSeriesForCategory(string? symbol = null, string? titleSearchExpression = null, string? categoryID = null, string? sortExpression = null, bool sortAscending = true, int skip = 0, int take = int.MaxValue);
    Task<int> GetSeriesCount();
    Task<RowOpResult> DeleteSeriesCategoriesForSymbol(string symbol);
    Task<RowOpResult> DeleteSeries(string symbol);
}
