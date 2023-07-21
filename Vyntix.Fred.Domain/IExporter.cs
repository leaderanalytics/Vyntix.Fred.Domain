namespace LeaderAnalytics.Vyntix.Fred.Domain;

public interface IExporter
{
    Task Export(FredDownloadJobArgs jobArgs);
}
