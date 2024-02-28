// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The ExtendedCassandraTableResourceInfo. </summary>
    public partial class ExtendedCassandraTableResourceInfo : CassandraTableResourceInfo
    {
        /// <summary> Initializes a new instance of <see cref="ExtendedCassandraTableResourceInfo"/>. </summary>
        /// <param name="tableName"> Name of the Cosmos DB Cassandra table. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public ExtendedCassandraTableResourceInfo(string tableName) : base(tableName)
        {
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedCassandraTableResourceInfo"/>. </summary>
        /// <param name="tableName"> Name of the Cosmos DB Cassandra table. </param>
        /// <param name="defaultTtl"> Time to live of the Cosmos DB Cassandra table. </param>
        /// <param name="schema"> Schema of the Cosmos DB Cassandra table. </param>
        /// <param name="analyticalStorageTtl"> Analytical TTL. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="timestamp"> A system generated property that denotes the last updated timestamp of the resource. </param>
        /// <param name="etag"> A system generated property representing the resource etag required for optimistic concurrency control. </param>
        internal ExtendedCassandraTableResourceInfo(string tableName, int? defaultTtl, CassandraSchema schema, int? analyticalStorageTtl, IDictionary<string, BinaryData> serializedAdditionalRawData, string rid, float? timestamp, ETag? etag) : base(tableName, defaultTtl, schema, analyticalStorageTtl, serializedAdditionalRawData)
        {
            Rid = rid;
            Timestamp = timestamp;
            ETag = etag;
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedCassandraTableResourceInfo"/> for deserialization. </summary>
        internal ExtendedCassandraTableResourceInfo()
        {
        }

        /// <summary> A system generated property. A unique identifier. </summary>
        public string Rid { get; }
        /// <summary> A system generated property that denotes the last updated timestamp of the resource. </summary>
        public float? Timestamp { get; }
        /// <summary> A system generated property representing the resource etag required for optimistic concurrency control. </summary>
        public ETag? ETag { get; }
    }
}
