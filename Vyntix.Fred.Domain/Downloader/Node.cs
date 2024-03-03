namespace LeaderAnalytics.Vyntix.Fred.Domain.Downloader;

// This class has no database table. It represents a category child
// either a sub-category or a series.


public class Node
{
    public string? ParentID { get; set; }           // Null if root
    public string EntityType { get; private set; }
    public string EntityID {  get; set; }
    public string EntityName { get; set; }
    public string SeriesName => $"{EntityName} ({EntityID})";


    public Node(FredCategory category, string parentID)
    {
        ArgumentNullException.ThrowIfNull(category);
        EntityType = "C";
        EntityID = category.NativeID;
        EntityName = category.Name;
        ParentID = parentID;
    }

    public Node(FredSeries series, string parentID)
    {
        ArgumentNullException.ThrowIfNull(series);
        EntityType = "S";
        EntityID = series.Symbol;
        EntityName = series.Title;
        ParentID = parentID;
    }
}
