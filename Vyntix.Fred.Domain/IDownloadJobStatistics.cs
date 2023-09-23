namespace LeaderAnalytics.Vyntix.Fred.Domain;

public interface IDownloadJobStatistics
{
    DateTime? StartTime { get; }
    DateTime? ProdStartTime { get; }
    DateTime? EndTime { get; }
    TimeSpan ElapsedTime { get; }
    bool IsCanceled { get; set; }

    IDownloadStatistic ProductionCategoryCounts { get; }
    IDownloadStatistic ProductionCategoryTagCounts { get; }
    IDownloadStatistic ProductionObservationCounts { get; }
    IDownloadStatistic ProductionRelatedCategoryCounts { get; }
    IDownloadStatistic ProductionReleaseCounts { get; }
    IDownloadStatistic ProductionReleaseDateCounts { get; }
    IDownloadStatistic ProductionSeriesCounts { get; }
    IDownloadStatistic ProductionSeriesTagCounts { get; }
    IDownloadStatistic ProductionSourceCounts { get; }
    IDownloadStatistic ProductionVintageDateCounts { get; }

    IDownloadStatistic StagingCategoryCounts { get; }
    IDownloadStatistic StagingCategoryTagCounts { get; }
    IDownloadStatistic StagingObservationCounts { get; }
    IDownloadStatistic StagingRelatedCategoryCounts { get; }
    IDownloadStatistic StagingReleaseCounts { get; }
    IDownloadStatistic StagingReleaseDateCounts { get; }
    IDownloadStatistic StagingSeriesCategoryCounts { get; }
    IDownloadStatistic StagingSeriesCounts { get; }
    IDownloadStatistic StagingSeriesTagCounts { get; }
    IDownloadStatistic StagingSourceCounts { get; }
    IDownloadStatistic StagingVintageDateCounts { get; }
    IDownloadStatistic ProductionSeriesCategoryCounts { get; }
    IDownloadStatistic ProductionTagCounts { get; }

    int ActiveRequestCount { get; }
    int TotalRequestCount { get; }
    int ProductionThroughput { get; }
    int StagingThroughput { get; }

    void EndJob();
    void IncrementActiveRequestCount(int value);
    void IncrementTotalRequestCount(int value);
    void StartJob();
    void StartProd();
    void Dispose();
}
