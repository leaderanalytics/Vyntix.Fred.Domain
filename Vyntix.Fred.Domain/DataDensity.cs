namespace LeaderAnalytics.Vyntix.Fred.Domain;

public enum DataDensity
{
    /// <summary>
    /// Include unchanged values from prior vintages for each vintage
    /// </summary>
    Dense,
    /// <summary>
    /// Include only new and revised data for each vintage
    /// </summary>
    Sparse
}
