namespace LeaderAnalytics.Vyntix.Fred.Domain;

public class FredDownloadJobArgs
{
    public const int Max_HTTP_Requests_Default = 8;
    public const int Max_DB_Connections_Default = -1; // unbounded
    public const int MaxDegreeOfParallelism_Default = 10; // System.Threading.Tasks.Dataflow.DataflowBlockOptions.Unbounded
    public const int ChunkSize_Default = 10;
    public const int BoundedCapacity_Default = 5000;

    public bool IsFaulted { get; set; }
    public CancellationTokenSource CancelTokenSource { get; private set; }
    public CancellationToken CancelToken { get; private set; }
    public bool ResumeLastDownload { get; private set; }
    public bool UpdateCategories { get; private set; }
    public bool UpdateReleasesAndSources { get; private set; }
    public bool UpdateReleaseSeries { get; private set; }
    public bool UpdateReleaseDates { get; private set; }
    public bool UpdateObservationsAndVintages { get; private set; }
    public bool UpdateCategoryTags { get; private set; }
    public bool UpdateSeriesTags { get; private set; }
    public bool UpdateRelatedCategories { get; private set; }
    public IEnumerable<string> SymbolsToUpdate { get; private set; }
    public bool IncludeDiscontinuedSeries { get; private set; }
    public bool PurgeProductionTablesBeforeImport { get; private set; }

    /// Test and diagnostic parameters

    /// <summary>
    /// Keeps staging data, if any, that exists prior to start of download
    /// </summary>
    public bool PreserveStagingDataBeforeDownload { get; set; }

    /// <summary>
    /// Master switch to skip all downloads and only export data, if any, in staging tables
    /// </summary>
    public bool BypassAllDownloads { get; set; }
    
    /// <summary>
    /// Downloads data but does not export it.
    /// </summary>
    public bool BypassExport { get; set; }
    
    /// <summary>
    /// Stops data from being purged from staging tables after export.
    /// </summary>
    public bool PreserveStagingDataAfterExport { get; set; }

    /// <summary>
    /// Max number of concurrent HTTP requests that will be sent to FRED client.  
    /// Default and hard coded max is 8.
    /// </summary>
    public int Max_HTTP_Requests { get; set; } = Max_HTTP_Requests_Default;

    /// <summary>
    /// 
    /// </summary>
    public int Max_DB_Connections { get; set; } = Max_DB_Connections_Default;

    /// <summary>
    /// MaxDegreeOfPaarallelism for ActionBlocks.  
    /// Set to 1 to step through code on a single thread.
    /// </summary>
    public int MaxDegreeOfParallelism { get; set; } = MaxDegreeOfParallelism_Default;

    /// <summary>
    /// Number of rows to take when selecting rows of data in chunks.
    /// </summary>
    public int ChunkSize { get; set; } = ChunkSize_Default;

    /// <summary>
    /// Capacity of buffer blocks for queued tasks.  Setting to unbounded will cause out of memory error.
    /// </summary>
    public int BoundedCapacity { get; set; } = BoundedCapacity_Default;

    public bool IsCanceled { get => CancelToken.IsCancellationRequested; }


    public FredDownloadJobArgs(bool resumeLastDownload, bool updateCategoriesAndSeries,
        bool updateReleasesAndSources, bool updateReleaseSeries, bool updateReleaseDates,
        bool updateObservationsAndVintages, 
        bool updateCategoryTags, bool updateSeriesTags, bool updateRelatedCategories,
        IEnumerable<string> symbolsToUpdate, bool includeDiscontinuedSeries,  bool purgeBeforeImport)
    {
        CancelTokenSource = new CancellationTokenSource();
        CancelToken = CancelTokenSource.Token;
        ResumeLastDownload = resumeLastDownload;
        UpdateCategories = updateCategoriesAndSeries;
        UpdateCategoryTags = updateCategoryTags;
        UpdateSeriesTags = updateSeriesTags;
        UpdateRelatedCategories = updateRelatedCategories;
        PurgeProductionTablesBeforeImport = purgeBeforeImport;
        UpdateReleasesAndSources = updateReleasesAndSources;
        UpdateReleaseSeries = updateReleaseSeries;
        UpdateReleaseDates = updateReleaseDates;
        UpdateObservationsAndVintages = updateObservationsAndVintages;
        SymbolsToUpdate = symbolsToUpdate;
        IncludeDiscontinuedSeries = includeDiscontinuedSeries;
    }
}
