// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Storage.Blobs.Models
{
    /// <summary> Stats for the storage service. </summary>
    public partial class BlobServiceStatistics
    {
        /// <summary> Initializes a new instance of <see cref="BlobServiceStatistics"/>. </summary>
        internal BlobServiceStatistics()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BlobServiceStatistics"/>. </summary>
        /// <param name="geoReplication"> Geo-Replication information for the Secondary Storage Service. </param>
        internal BlobServiceStatistics(BlobGeoReplication geoReplication)
        {
            GeoReplication = geoReplication;
        }

        /// <summary> Geo-Replication information for the Secondary Storage Service. </summary>
        public BlobGeoReplication GeoReplication { get; }
    }
}
