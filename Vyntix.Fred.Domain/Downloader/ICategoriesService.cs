namespace LeaderAnalytics.Vyntix.Fred.Domain.Downloader;

public interface ICategoriesService
{
    Task<RowOpResult> DownloadCategory(string categoryID);
    Task<RowOpResult> DownloadCategoryChildren(string categoryID);
    Task<RowOpResult> DownloadRelatedCategories(string parentID);
    Task<RowOpResult> DownloadCategorySeries(string categoryID);
    Task<RowOpResult> DownloadCategoryTags(string categoryID);
    Task<RowOpResult> SaveCategory(FredCategory category, bool saveChanges = true);
    Task<RowOpResult> SaveCategoryTag(FredCategoryTag categoryTag, bool saveChanges = true);
    Task<RowOpResult> SaveRelatedCategory(FredRelatedCategory category, bool saveChanges = true);
}
