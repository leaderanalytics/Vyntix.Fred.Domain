namespace LeaderAnalytics.Vyntix.Fred.Domain.Downloader;

public class FredDownloadArgs
{
    public string[] Symbols { get; set; }       // Download path is for each symbol
    public string CategoryID { get; set; }      // Download path is a single Category


    public bool Series { get; set; }
    public bool IncludeDiscontinuedSeries { get; set; } // Only used if path is CategoryID
    public bool ChildCategories { get; set; }
    public bool SeriesTags { get; set; }
    public bool CategoryTags { get; set; }
    public bool RelatedCategories { get; set; }
    public bool Releases { get; set; }
    public bool ReleaseDates { get; set; }
    public bool Sources { get; set; }
    public bool Observations { get; set; }
    public bool Recurse { get; set; }  // Only used if download path id CategoryID and ChildCategories is true
}
