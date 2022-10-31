namespace LeaderAnalytics.Vyntix.Fred.Domain;

public interface IDownloadStatistic
{
    int FailCount { get; }
    int InsertCount { get; }
    int TotalCount { get; }
    int UpdateCount { get; }

    void IncrementFails(int value);
    void IncrementInserts(int value);
    void IncrementUpdates(int value);
    void Reset();
}
