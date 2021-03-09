using LeaderAnalytics.Vyntix.Fred.Model;
using System.Collections.Generic;


namespace LeaderAnalytics.Vyntix.Fred.Domain
{
    public interface IVintageComposer
    {
        /// <summary>
        /// Populate observations where the value is equal to the value of the prior vintage for the same observation date.
        /// </summary>
        /// <param name="sparse"></param>
        /// <returns></returns>
        List<IObservation> MakeDense(List<IObservation> sparse);

        /// <summary>
        /// Populate observations where the value is equal to the value of the prior vintage for the same observation date.
        /// </summary>
        /// <param name="sparse"></param>
        /// <returns></returns>
        List<IVintage> MakeDense(List<IVintage> sparseVintages);

        /// <summary>
        /// Remove observations where the value is equal to the value of the prior vintage for the same observation date.
        /// </summary>
        /// <param name="dense"></param>
        /// <returns></returns>
        List<IObservation> MakeSparse(List<IObservation> dense);
    }
}
