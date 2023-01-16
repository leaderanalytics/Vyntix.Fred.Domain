﻿/*
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

    Task<List<Category>> GetCategoriesForSeries(string symbol);
    Task<Category> GetCategory(string categoryID);
    Task<List<Category>> GetCategoryChildren(string parentID);
    Task<List<CategoryTag>> GetCategoryTags(string categoryID);
    
    /// <summary>
    /// Get observations using the most recent vintage
    /// </summary>
    /// <param name="symbol">A valid FRED series identifier.</param>
    /// <param name="density">Dense repeats unchanged values across vintages, Sparse includes new and revised values only.  Default is Dense.</param>
    /// <returns>A List of Observations</returns>
    Task<List<Observation>> GetObservations(string symbol, DataDensity density = DataDensity.Sparse);

    /// <summary>
    /// Get observations for vintages that were valid between the user-defined real-time start and real-time end periods of interest.
    /// </summary>
    /// <param name="symbol">A valid FRED series identifier.</param>
    /// <param name="RTStart">Start date of a user-defined real-time period of interest.</param>
    /// <param name="RTEnd">End date of a user-defined real-time period of interest.</param>
    /// <param name="density">Dense repeats unchanged values across vintages, Sparse includes new and revised values only.  Default is Dense.</param>
    /// <returns>A List of Observations</returns>
    Task<List<Observation>> GetObservations(string symbol, DateTime? RTStart = null, DateTime? RTEnd = null, DataDensity density = DataDensity.Sparse);

    /// <summary>
    /// Get observations for the specified observation periods that were valid between the user-defined real-time periods of interest.
    /// To find user-defined real-time periods of interest that correspond to vintage dates, first call GetVintageDates than call this method
    /// passing in the desired vintage dates.
    /// </summary>
    /// <param name="symbol">A valid FRED series identifier.</param>
    /// <param name="RTStart">Start date of a user-defined real-time period of interest.</param>
    /// <param name="RTEnd">End date of a user-defined real-time period of interest.</param>
    /// <param name="obsStart">Date of the starting observation period.</param>
    /// <param name="obsEnd">Date of the ending observation period.</param>
    /// <param name="density">Dense repeats unchanged values across vintages, Sparse includes new and revised values only.  Default is Dense.</param>
    /// <returns>A List of Observations</returns>
    Task<List<Observation>> GetObservations(string symbol, DateTime? RTStart = null, DateTime? RTEnd = null, DateTime? obsStart = null, DateTime? obsEnd = null, DataDensity density = DataDensity.Sparse);

    /// <summary>
    /// Get observations for the supplied list of valid FRED defined vintage dates.
    /// </summary>
    /// <param name="symbol">A valid FRED series identifier.</param>
    /// <param name="vintageDates">A List of valid FRED defined vintage dates</param>
    /// <param name="density">Dense repeats unchanged values across vintages, Sparse includes new and revised values only.  Default is Dense.</param>
    /// <returns>A List of Observations</returns>
    Task<List<Observation>> GetObservations(string symbol, IList<DateTime> vintageDates, DataDensity density = DataDensity.Sparse);

    /// <summary>
    /// Get observations for the supplied list of valid FRED defined vintage dates.
    /// </summary>
    /// <param name="symbol">A valid FRED series identifier.</param>
    /// <param name="vintageDates">A List of valid FRED defined vintage dates</param>
    /// <param name="obsStart">Date of the starting observation period.</param>
    /// <param name="obsEnd">Date of the ending observation period.</param>
    /// <param name="density">Dense repeats unchanged values across vintages, Sparse includes new and revised values only.  Default is Dense.</param>
    /// <returns>A List of Observations</returns>
    Task<List<Observation>> GetObservations(string symbol, IList<DateTime> vintageDates, DateTime? obsStart = null, DateTime? obsEnd = null, DataDensity density = DataDensity.Sparse);
    
    Task<List<RelatedCategory>> GetRelatedCategories(string parentID);
    Task<List<Release>> GetAllReleases();
    Task<List<ReleaseDate>> GetAllReleaseDates(DateTime? realtimeStart, bool includeReleaseDatesWithNoData);
    Task<Release> GetRelease(string nativeID);
    Task<List<ReleaseDate>> GetReleaseDatesForRelease(string releaseNativeID, DateTime? realtimeStart, bool includeReleaseDatesWithNoData);
    Task<List<Series>> GetSeriesForRelease(string releaseNativeID);
    Task<List<Source>> GetSourcesForRelease(string releaseNativeID);
    Task<List<ReleaseDate>> GetReleaseDates(string nativeReleaseID, int offset);
    Task<List<Release>> GetReleasesForSource(string nativeSourceID);
    Task<Release> GetReleaseForSeries(string symbol);
    Task<List<Release>> GetReleasesForSource(string nativeSourceID, DateTime RTStart, DateTime RTEnd);
    Task<Series> GetSeries(string symbol);
    Task<List<Series>> GetSeriesForCategory(string categoryID, bool includeDiscontinued);
    Task<List<SeriesTag>> GetSeriesTags(string symbol);
    Task<Source> GetSource(string sourceID);
    Task<List<Source>> GetSources();
    Task<List<Source>> GetSources(DateTime RTStart, DateTime RTEnd);
    Task<List<Vintage>> GetVintages(string symbol);
    Task<List<Vintage>> GetVintages(string symbol, DateTime? RTStart, DateTime? RTEnd);
}
