namespace LeaderAnalytics.Vyntix.Fred.Domain.Downloader;

public interface IObservationsService
{
    Task<RowOpResult> DownloadObservations(string symbol);
    Task<List<RowOpResult>> DownloadObservations(string[] symbols);
    Task<RowOpResult> DeleteObservationsForSymbol(string symbol);
    Task<RowOpResult<List<FredObservation>>> GetLocalObservations(string[] symbols);
    Task<RowOpResult<SeriesStatistics>> GetSeriesStatistics(string symbol);
}
