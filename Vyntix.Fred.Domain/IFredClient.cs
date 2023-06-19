/*
 The MIT License (MIT)

Copyright (c) 2020 Leader Analytics

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

This copyright notice header shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

This software uses the FRED® API but is not endorsed or certified by the Federal Reserve Bank of St. Louis.
By using this software you agree to be bound by the FRED® API Terms of Use found here: https://fred.stlouisfed.org/legal/.

*/

global using LeaderAnalytics.Vyntix.Fred.Model;
namespace LeaderAnalytics.Vyntix.Fred.Domain;

public interface IFredClient
{
    IDownloadJobStatistics JobStatistics { get; set; }
    int RemainingLimitRequests { get; }

    Task<List<FredCategory>> GetCategoriesForSeries(string symbol);
    Task<FredCategory> GetCategory(string categoryID);
    Task<List<FredCategory>> GetCategoryChildren(string parentID);
    Task<List<CategoryTag>> GetCategoryTags(string categoryID);

    /// <summary>
    /// Get observations using the most recent vintage
    /// </summary>
    /// <param name="symbol">A valid FRED series identifier.</param>
    /// <returns>A List of Observations</returns>
    Task<List<FredObservation>> GetObservations(string symbol);

    /// <summary>
    /// Get observations using the most recent vintage
    /// </summary>
    /// <param name="symbol">A valid FRED series identifier.</param>
    /// <param name="density">Dense repeats unchanged values across vintages, Sparse includes new and revised values only.</param>
    /// <returns>A List of Observations</returns>
    Task<List<FredObservation>> GetObservations(string symbol, DataDensity density);

    /// <summary>
    /// Get observations for the specified observation periods that were valid between the user-defined real-time periods of interest.
    /// To find user-defined real-time periods of interest that correspond to vintage dates, first call GetVintageDates than call this method
    /// passing in the desired vintage dates.
    /// </summary>
    /// <param name="symbol">A valid FRED series identifier.</param>
    /// <param name="RTStart">Start date of a user-defined real-time period of interest.</param>
    /// <param name="RTEnd">End date of a user-defined real-time period of interest.</param>
    /// <param name="obsPeriod">Date of the observation period.</param>
    /// <param name="density">Dense repeats unchanged values across vintages, Sparse includes new and revised values only.</param>
    /// <returns>A List of Observations</returns>
    Task<List<FredObservation>> GetObservations(string symbol, DateTime obsPeriod, DateTime? RTStart, DateTime? RTEnd, DataDensity density);

    /// <summary>
    /// Get observations for the specified observation periods that were valid between the user-defined real-time periods of interest.
    /// To find user-defined real-time periods of interest that correspond to vintage dates, first call GetVintageDates than call this method
    /// passing in the desired vintage dates.
    /// </summary>
    /// <param name="symbol">A valid FRED series identifier.</param>
    /// <param name="obsStart">Start date of the observation period.</param>
    /// <param name="obsEnd">End date of the observation period.</param>
    /// <param name="density">Dense repeats unchanged values across vintages, Sparse includes new and revised values only.</param>
    /// <returns>A List of Observations</returns>
    Task<List<FredObservation>> GetObservations(string symbol, DateTime? obsStart, DateTime? obsEnd, DataDensity density);

    /// <summary>
    /// Get observations for the supplied list of valid FRED defined vintage dates.
    /// </summary>
    /// <param name="symbol">A valid FRED series identifier.</param>
    /// <param name="vintageDates">A List of valid FRED defined vintage dates</param>
    /// <param name="density">Dense repeats unchanged values across vintages, Sparse includes new and revised values only.</param>
    /// <returns>A List of Observations</returns>
    Task<List<FredObservation>> GetObservations(string symbol, IList<DateTime> vintageDates, DataDensity density);

    /// <summary>
    /// Get observations for the supplied list of valid FRED defined vintage dates.
    /// </summary>
    /// <param name="symbol">A valid FRED series identifier.</param>
    /// <param name="vintageDates">A List of valid FRED defined vintage dates</param>
    /// <param name="obsStart">Date of the starting observation period.</param>
    /// <param name="obsEnd">Date of the ending observation period.</param>
    /// <param name="density">Dense repeats unchanged values across vintages, Sparse includes new and revised values only.</param>
    /// <returns>A List of Observations</returns>
    Task<List<FredObservation>> GetObservations(string symbol, IList<DateTime> vintageDates, DateTime? obsStart, DateTime? obsEnd, DataDensity density);
    
    Task<List<RelatedCategory>> GetRelatedCategories(string parentID);
    Task<List<FredRelease>> GetAllReleases();
    Task<List<FredReleaseDate>> GetAllReleaseDates(DateTime? realtimeStart, bool includeReleaseDatesWithNoData);
    Task<FredRelease> GetRelease(string nativeID);
    Task<List<FredReleaseDate>> GetReleaseDatesForRelease(string releaseNativeID, DateTime? realtimeStart, bool includeReleaseDatesWithNoData);
    Task<List<FredSeries>> GetSeriesForRelease(string releaseNativeID);
    Task<List<FredSource>> GetSourcesForRelease(string releaseNativeID);
    Task<List<FredReleaseDate>> GetReleaseDates(string nativeReleaseID, int offset);
    Task<List<FredRelease>> GetReleasesForSource(string nativeSourceID);
    Task<FredRelease> GetReleaseForSeries(string symbol);
    Task<List<FredRelease>> GetReleasesForSource(string nativeSourceID, DateTime RTStart, DateTime RTEnd);
    Task<FredSeries> GetSeries(string symbol);
    Task<List<FredSeries>> GetSeriesForCategory(string categoryID, bool includeDiscontinued);
    Task<List<SeriesTag>> GetSeriesTags(string symbol);
    Task<FredSource> GetSource(string sourceID);
    Task<List<FredSource>> GetSources();
    Task<List<FredSource>> GetSources(DateTime RTStart, DateTime RTEnd);
    Task<List<FredVintage>> GetVintages(string symbol, DateTime? RTStart = null, DateTime? RTEnd = null);
    Task<List<DateTime>> GetVintageDates(string symbol, DateTime? RTStart = null, DateTime? RTEnd = null);
}
