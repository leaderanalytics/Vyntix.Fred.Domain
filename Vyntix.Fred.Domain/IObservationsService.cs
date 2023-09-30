namespace LeaderAnalytics.Vyntix.Fred.Domain;

public interface IObservationsService
{
    Task<RowOpResult> DownloadObservations(string symbol);
    Task<List<RowOpResult>> DownloadObservations(string[] symbols);
    Task<RowOpResult> DeleteObservationsForSymbol(string symbol);
    Task<RowOpResult<List<Observation>>> GetLocalObservations(string[] symbols);
}
