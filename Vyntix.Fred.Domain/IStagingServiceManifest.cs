namespace LeaderAnalytics.Vyntix.Fred.Domain;

public interface IStagingServiceManifest : IDisposable
{
    IFred_StagingService FRED_StagingService { get; }
}