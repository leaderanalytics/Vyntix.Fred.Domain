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
    Task BulkInsertRelatedCategories(List<RelatedCategory> categories);
    Task BulkInsertSeries(List<FredSeries> series);
    Task BulkInsertSources(List<FredSource> sources);
    Task BulkInsertReleases(List<FredRelease> releases);
    Task BulkInsertReleaseDates(List<FredReleaseDate> releaseDates);
    Task BulkInsertSeriesCategories(List<SeriesCategory> releaseSeries);
    Task BulkInsertObservations(List<FredObservation> observations);
    Task BulkInsertCategoryTags(List<CategoryTag> tags);
    Task BulkInsertSeriesTags(List<SeriesTag> tags);
    Task<int> GetSeriesCountForDownload();
    Task<List<FredCategory>> GetChildCategories(string parentID);
    Task<List<string>> GetRootParentIDs();
    Task<List<FredSource>> GetSources(int skip, int take);
    Task GetReleases(Func<List<FredRelease>, Task> func, int takeSize);
    Task GetSeries(Func<List<IGrouping<string, FredSeries>>, Task> func, int takeSize);
    Task GetSeriesTags(Func<List<SeriesTag>, Task> func, int takeSize);
    Task GetCategoryTags(Func<List<CategoryTag>, Task> func, int takeSize);
    Task<List<RelatedCategory>> GetRelatedCategories(int skip, int take);
    Task GetVintages(Func<string, Task> func);
    Task GetReleaseDates(Func<List<IGrouping<string, FredReleaseDate>>, Task> func, int takeSize);
    Task GetSeriesCategories(Func<List<IGrouping<string, SeriesCategory>>, Task> func, int takeSize);
    Task<List<KeyValuePair<string, string[]>>> GetSeriesCategoryDict();
    Task ToggleDTOObserationsIndex(bool enable);
    Task ToggleDTOSeriesIndex(bool enable);
    Task ExportSeries(int dataProviderID, IDownloadJobStatistics jobStatistics);
    Task ExportVintages(string symbol, int dataProviderID, IDownloadJobStatistics jobStatistics);
    Task ExportDataRequests(int dataProviderID);
    Task ExportTags(int dataProviderID, IDownloadJobStatistics jobStatistics);
    Task ExportCategoryTags(int dataProviderID, IDownloadJobStatistics jobStatistics);
    Task ExportSeriesTags(int dataProviderID, IDownloadJobStatistics jobStatistics);
}
