namespace LeaderAnalytics.Vyntix.Fred.Domain;

public interface IVintageComposer
{
    /// <summary>
    /// Populate observations where the value is equal to the value of the prior vintage for the same observation date.
    /// </summary>
    /// <param name="sparse"></param>
    /// <returns></returns>
    List<IFredObservation> MakeDense(List<IFredObservation> sparse);

    /// <summary>
    /// Populate observations where the value is equal to the value of the prior vintage for the same observation date.
    /// </summary>
    /// <param name="sparse"></param>
    /// <returns></returns>
    List<IFredVintage> MakeDense(List<IFredVintage> sparseVintages);

    /// <summary>
    /// Remove observations where the value is equal to the value of the prior vintage for the same observation date.
    /// </summary>
    /// <param name="dense"></param>
    /// <returns></returns>
    List<IFredObservation> MakeSparse(List<IFredObservation> dense);
}
