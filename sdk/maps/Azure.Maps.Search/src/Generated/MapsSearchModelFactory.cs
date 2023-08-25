// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;
using Azure.Core.GeoJson;
using Azure.Maps.Search;

namespace Azure.Maps.Search.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class MapsSearchModelFactory
    {
        /// <summary> Initializes a new instance of PolygonResult. </summary>
        /// <param name="polygons"> Results array. </param>
        /// <returns> A new <see cref="Models.PolygonResult"/> instance for mocking. </returns>
        public static PolygonResult PolygonResult(IEnumerable<PolygonObject> polygons = null)
        {
            polygons ??= new List<PolygonObject>();

            return new PolygonResult(polygons?.ToList());
        }

        /// <summary> Initializes a new instance of PolygonObject. </summary>
        /// <param name="providerId"> ID of the returned entity. </param>
        /// <param name="geometryData"> Geometry data in GeoJSON format. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946) for details. Present only if "error" is not present. </param>
        /// <returns> A new <see cref="Models.PolygonObject"/> instance for mocking. </returns>
        public static PolygonObject PolygonObject(string providerId = null, GeoObject geometryData = null)
        {
            return new PolygonObject(providerId, geometryData);
        }

        /// <summary> Initializes a new instance of PointOfInterestCategorySet. </summary>
        /// <param name="id"> Category ID. </param>
        /// <returns> A new <see cref="Models.PointOfInterestCategorySet"/> instance for mocking. </returns>
        public static PointOfInterestCategorySet PointOfInterestCategorySet(int? id = null)
        {
            return new PointOfInterestCategorySet(id);
        }

        /// <summary> Initializes a new instance of PointOfInterestClassification. </summary>
        /// <param name="code"> Code property. </param>
        /// <param name="names"> Names array. </param>
        /// <returns> A new <see cref="Models.PointOfInterestClassification"/> instance for mocking. </returns>
        public static PointOfInterestClassification PointOfInterestClassification(string code = null, IEnumerable<ClassificationName> names = null)
        {
            names ??= new List<ClassificationName>();

            return new PointOfInterestClassification(code, names?.ToList());
        }

        /// <summary> Initializes a new instance of ClassificationName. </summary>
        /// <param name="nameLocale"> Name Locale property. </param>
        /// <param name="name"> Name property. </param>
        /// <returns> A new <see cref="Models.ClassificationName"/> instance for mocking. </returns>
        public static ClassificationName ClassificationName(string nameLocale = null, string name = null)
        {
            return new ClassificationName(nameLocale, name);
        }

        /// <summary> Initializes a new instance of BrandName. </summary>
        /// <param name="name"> Name of the brand. </param>
        /// <returns> A new <see cref="Models.BrandName"/> instance for mocking. </returns>
        public static BrandName BrandName(string name = null)
        {
            return new BrandName(name);
        }

        /// <summary> Initializes a new instance of OperatingHours. </summary>
        /// <param name="mode"> Value used in the request: none or "nextSevenDays". </param>
        /// <param name="timeRanges"> List of time ranges for the next 7 days. </param>
        /// <returns> A new <see cref="Models.OperatingHours"/> instance for mocking. </returns>
        public static OperatingHours OperatingHours(string mode = null, IEnumerable<OperatingHoursTimeRange> timeRanges = null)
        {
            timeRanges ??= new List<OperatingHoursTimeRange>();

            return new OperatingHours(mode, timeRanges?.ToList());
        }

        /// <summary> Initializes a new instance of MapsDataSource. </summary>
        /// <param name="geometry"> Information about the geometric shape of the result. Only present if type == Geography. </param>
        /// <returns> A new <see cref="Models.MapsDataSource"/> instance for mocking. </returns>
        public static MapsDataSource MapsDataSource(GeometryIdentifier geometry = null)
        {
            return new MapsDataSource(geometry);
        }

        /// <summary> Initializes a new instance of GeometryIdentifier. </summary>
        /// <param name="id"> Pass this as geometryId to the [Get Search Polygon](https://docs.microsoft.com/rest/api/maps/search/getsearchpolygon) API to fetch geometry information for this result. </param>
        /// <returns> A new <see cref="Models.GeometryIdentifier"/> instance for mocking. </returns>
        public static GeometryIdentifier GeometryIdentifier(string id = null)
        {
            return new GeometryIdentifier(id);
        }

        /// <summary> Initializes a new instance of PointOfInterestCategoryTreeResult. </summary>
        /// <param name="categories"> Categories array. </param>
        /// <returns> A new <see cref="Models.PointOfInterestCategoryTreeResult"/> instance for mocking. </returns>
        public static PointOfInterestCategoryTreeResult PointOfInterestCategoryTreeResult(IEnumerable<PointOfInterestCategory> categories = null)
        {
            categories ??= new List<PointOfInterestCategory>();

            return new PointOfInterestCategoryTreeResult(categories?.ToList());
        }

        /// <summary> Initializes a new instance of PointOfInterestCategory. </summary>
        /// <param name="id"> Unique ID for the category. ID can be used to restrict search results to specific categories through other Search Service APIs, like [Get Search POI](https://docs.microsoft.com/rest/api/maps/search/getsearchpoi). </param>
        /// <param name="name"> Name of the category. </param>
        /// <param name="childIds"> Array of child category ids. </param>
        /// <param name="synonyms"> Array of alternative names of the category. </param>
        /// <returns> A new <see cref="Models.PointOfInterestCategory"/> instance for mocking. </returns>
        public static PointOfInterestCategory PointOfInterestCategory(int? id = null, string name = null, IEnumerable<int> childIds = null, IEnumerable<string> synonyms = null)
        {
            childIds ??= new List<int>();
            synonyms ??= new List<string>();

            return new PointOfInterestCategory(id, name, childIds?.ToList(), synonyms?.ToList());
        }

        /// <summary> Initializes a new instance of ReverseSearchAddressItem. </summary>
        /// <param name="address"> The address of the result. </param>
        /// <param name="position"> Position property in the form of "{latitude},{longitude}". </param>
        /// <param name="roadUse"></param>
        /// <param name="matchType">
        /// Information on the type of match.
        ///
        /// One of:
        ///   * AddressPoint
        ///   * HouseNumberRange
        ///   * Street
        /// </param>
        /// <returns> A new <see cref="Models.ReverseSearchAddressItem"/> instance for mocking. </returns>
        public static ReverseSearchAddressItem ReverseSearchAddressItem(MapsAddress address = null, string position = null, IEnumerable<RoadKind> roadUse = null, MapsSearchMatchType? matchType = null)
        {
            roadUse ??= new List<RoadKind>();

            return new ReverseSearchAddressItem(address, position, roadUse?.ToList(), matchType);
        }

        /// <summary> Initializes a new instance of ReverseSearchCrossStreetAddressResultItem. </summary>
        /// <param name="address"> The address of the result. </param>
        /// <param name="position"> Position property in the form of "{latitude},{longitude}". </param>
        /// <returns> A new <see cref="Models.ReverseSearchCrossStreetAddressResultItem"/> instance for mocking. </returns>
        public static ReverseSearchCrossStreetAddressResultItem ReverseSearchCrossStreetAddressResultItem(MapsAddress address = null, string position = null)
        {
            return new ReverseSearchCrossStreetAddressResultItem(address, position);
        }
    }
}
