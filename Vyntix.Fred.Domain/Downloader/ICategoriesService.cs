namespace LeaderAnalytics.Vyntix.Fred.Domain.Downloader;

public interface ICategoriesService
{
    Task<RowOpResult> DownloadCategory(string categoryID, CancellationToken? cancellationToken);
    Task<RowOpResult> DownloadCategoriesForSeries(string symbol, CancellationToken? cancellationToken);
    Task<RowOpResult> DownloadCategoryChildren(string categoryID, CancellationToken? cancellationToken);
    Task<RowOpResult> DownloadRelatedCategories(string parentID, CancellationToken? cancellationToken);
    Task<RowOpResult> DownloadCategorySeries(string categoryID, CancellationToken? cancellationToken, bool includeDiscontinued = false);
    Task<RowOpResult> DownloadCategoryTags(string categoryID, CancellationToken? cancellationToken);
    Task<RowOpResult> SaveCategory(FredCategory category, bool saveChanges = true);
    Task<RowOpResult> SaveCategoryTag(FredCategoryTag categoryTag, bool saveChanges = true);
    Task<RowOpResult> SaveRelatedCategory(FredRelatedCategory category, bool saveChanges = true);
    Task<List<FredCategory>> GetLocalCategoriesForSeries(string symbol);
    Task<List<FredCategory>> GetLocalChildCategories(string? parentID, bool sortAscending = true, string searchExpression = null, int skip = 0, int take = int.MaxValue);
    Task<List<Node>> GetCategoryNodes(string? categoryID, bool sortAscending = true, string searchExpression = null, string symbolSearchExpression = null, int skip = 0, int take = int.MaxValue);
}
