namespace LeaderAnalytics.Vyntix.Fred.Domain;

public interface IFred_StagingService : IDisposable
{
    Task TruncateStagingTables();
    Task<List<string>> GetDownloadedCategoryIDs();
    Task<List<string>> GetSymbols(int skip, int take);
    Task<List<string>> GetFrequencies();
    Task<List<string>> GetSymbolsForDownloadedVintageDates();
    Task BulkInsertCategories(List<FredCategory> categories);
    Task BulkInsertDataRequests(List<string> nativeIDs);
    Task BulkInsertRelatedCategories(List<FredRelatedCategory> categories);
    Task BulkInsertSeries(List<FredSeries> series);
    Task BulkInsertSources(List<FredSource> sources);
    Task BulkInsertReleases(List<FredRelease> releases);
    Task BulkInsertReleaseDates(List<FredReleaseDate> releaseDates);
    Task BulkInsertSeriesCategories(List<FredSeriesCategory> releaseSeries);
    Task BulkInsertObservations(List<FredObservation> observations);
    Task BulkInsertCategoryTags(List<FredCategoryTag> tags);
    Task BulkInsertSeriesTags(List<FredSeriesTag> tags);
    Task<int> GetSeriesCountForDownload();
    Task<List<FredCategory>> GetChildCategories(string parentID);
    Task<List<string>> GetRootParentIDs();
    Task<List<FredSource>> GetSources(int skip, int take);
    Task GetReleases(Func<List<FredRelease>, Task> func, int takeSize);
    Task GetSeries(Func<List<IGrouping<string, FredSeries>>, Task> func, int takeSize);
    Task GetSeriesTags(Func<List<FredSeriesTag>, Task> func, int takeSize);
    Task GetCategoryTags(Func<List<FredCategoryTag>, Task> func, int takeSize);
    Task<List<FredRelatedCategory>> GetRelatedCategories(int skip, int take);
    Task GetVintages(Func<string, Task> func);
    Task GetReleaseDates(Func<List<IGrouping<string, FredReleaseDate>>, Task> func, int takeSize);
    Task GetSeriesCategories(Func<List<IGrouping<string, FredSeriesCategory>>, Task> func, int takeSize);
    Task<List<KeyValuePair<string, string[]>>> GetSeriesCategoryDict();
    Task ToggleObserationsIndex(bool enable);
    Task ToggleSeriesIndex(bool enable);
    Task ExportSeries(int dataProviderID, IDownloadJobStatistics jobStatistics);
    Task ExportVintages(string symbol, int dataProviderID, IDownloadJobStatistics jobStatistics);
    Task ExportDataRequests(int dataProviderID);
    Task ExportTags(int dataProviderID, IDownloadJobStatistics jobStatistics);
    Task ExportCategoryTags(int dataProviderID, IDownloadJobStatistics jobStatistics);
    Task ExportSeriesTags(int dataProviderID, IDownloadJobStatistics jobStatistics);
}
