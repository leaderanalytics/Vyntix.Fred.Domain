namespace LeaderAnalytics.Vyntix.Fred.Domain.Downloader;

public interface ICategoriesService
{
    Task<RowOpResult> DownloadCategory(string categoryID);
    Task<RowOpResult> DownloadCategoriesForSeries(string symbol);
    Task<RowOpResult> DownloadCategoryChildren(string categoryID);
    Task<RowOpResult> DownloadRelatedCategories(string parentID);
    Task<RowOpResult> DownloadCategorySeries(string categoryID, bool includeDiscontinued = false);
    Task<RowOpResult> DownloadCategoryTags(string categoryID);
    Task<RowOpResult> SaveCategory(FredCategory category, bool saveChanges = true);
    Task<RowOpResult> SaveCategoryTag(FredCategoryTag categoryTag, bool saveChanges = true);
    Task<RowOpResult> SaveRelatedCategory(FredRelatedCategory category, bool saveChanges = true);
    Task<List<FredCategory>> GetLocalCategoriesForSeries(string symbol);
    Task<List<FredCategory>> GetLocalChildCategories(string? parentID, bool sortAscending = true, string searchExpression = null, int skip = 0, int take = int.MaxValue);
    Task<List<Node>> GetCategoryNodes(string? categoryID, bool sortAscending = true, string searchExpression = null, int skip = 0, int take = int.MaxValue);
}
