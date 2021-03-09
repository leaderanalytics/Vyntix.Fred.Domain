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
*/

using LeaderAnalytics.Vyntix.Fred.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeaderAnalytics.Vyntix.Fred.Domain
{
    public interface IFredClient 
    {
        IDownloadJobStatistics JobStatistics { get; set; }
        int RemainingLimitRequests { get; }

        Task<List<Category>> GetCategoriesForSeries(string symbol);
        Task<Category> GetCategory(string categoryID);
        Task<List<Category>> GetCategoryChildren(string parentID);
        Task<List<CategoryTag>> GetCategoryTags(string categoryID);
        Task<List<Observation>> GetObservations(string symbol);
        Task<List<Observation>> GetObservations(string symbol, DateTime RTStart, DateTime RTEnd);
        Task<List<Observation>> GetObservations(string symbol, IList<DateTime> vintageDates);
        Task<List<Observation>> GetObservationUpdates(string symbol, DateTime? ObsStart, DateTime? ObsEnd);
        Task<List<RelatedCategory>> GetRelatedCategories(string parentID);
        Task<List<ReleaseDate>> GetReleaseDates(string nativeReleaseID, int offset);
        Task<List<Release>> GetReleasesForSource(string nativeSourceID);
        Task<List<Release>> GetReleasesForSource(string nativeSourceID, DateTime RTStart, DateTime RTEnd);
        Task<Series> GetSeries(string symbol);
        Task<List<SeriesCategory>> GetSeriesForCategory(string categoryID, bool includeDiscontinued);
        Task<List<Series>> GetSeriesForRelease(string releaseNativeID);
        Task<List<SeriesTag>> GetSeriesTags(string symbol);
        Task<List<Source>> GetSources();
        Task<List<Source>> GetSources(DateTime RTStart, DateTime RTEnd);
        Task<List<Vintage>> GetVintgeDates(string symbol, DateTime? RTStart);
    }
}