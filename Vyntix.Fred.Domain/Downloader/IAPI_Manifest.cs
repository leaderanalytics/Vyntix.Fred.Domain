namespace LeaderAnalytics.Vyntix.Fred.Domain.Downloader;

public interface IAPI_Manifest
{
    IObservationsService ObservationsService { get; }
    IReleasesService ReleasesService { get; }
    ISeriesService SeriesService { get; }
    ICategoriesService CategoriesService { get; }
}
