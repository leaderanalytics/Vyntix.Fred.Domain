namespace LeaderAnalytics.Vyntix.Fred.Domain.Downloader;

public interface IObservationsService
{
    Task<RowOpResult> DownloadObservations(string symbol, CancellationToken? cancellationToken);
    Task<List<RowOpResult>> DownloadObservations(string[] symbols, CancellationToken? cancellationToken);
    Task<RowOpResult> DeleteObservationsForSymbol(string symbol);
    Task<RowOpResult<List<FredObservation>>> GetLocalObservations(string[] symbols);
    Task<RowOpResult<SeriesStatistics>> GetSeriesStatistics(string symbol);
}
