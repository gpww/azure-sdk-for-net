// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The ExtendedCosmosDBSqlDatabaseResourceInfo. </summary>
    public partial class ExtendedCosmosDBSqlDatabaseResourceInfo : CosmosDBSqlDatabaseResourceInfo
    {
        /// <summary> Initializes a new instance of <see cref="ExtendedCosmosDBSqlDatabaseResourceInfo"/>. </summary>
        /// <param name="databaseName"> Name of the Cosmos DB SQL database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public ExtendedCosmosDBSqlDatabaseResourceInfo(string databaseName) : base(databaseName)
        {
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedCosmosDBSqlDatabaseResourceInfo"/>. </summary>
        /// <param name="databaseName"> Name of the Cosmos DB SQL database. </param>
        /// <param name="restoreParameters"> Parameters to indicate the information about the restore. </param>
        /// <param name="createMode"> Enum to indicate the mode of resource creation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="colls"> A system generated property that specified the addressable path of the collections resource. </param>
        /// <param name="users"> A system generated property that specifies the addressable path of the users resource. </param>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="timestamp"> A system generated property that denotes the last updated timestamp of the resource. </param>
        /// <param name="etag"> A system generated property representing the resource etag required for optimistic concurrency control. </param>
        internal ExtendedCosmosDBSqlDatabaseResourceInfo(string databaseName, ResourceRestoreParameters restoreParameters, CosmosDBAccountCreateMode? createMode, IDictionary<string, BinaryData> serializedAdditionalRawData, string colls, string users, string rid, float? timestamp, ETag? etag) : base(databaseName, restoreParameters, createMode, serializedAdditionalRawData)
        {
            Colls = colls;
            Users = users;
            Rid = rid;
            Timestamp = timestamp;
            ETag = etag;
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedCosmosDBSqlDatabaseResourceInfo"/> for deserialization. </summary>
        internal ExtendedCosmosDBSqlDatabaseResourceInfo()
        {
        }

        /// <summary> A system generated property that specified the addressable path of the collections resource. </summary>
        public string Colls { get; set; }
        /// <summary> A system generated property that specifies the addressable path of the users resource. </summary>
        public string Users { get; set; }
        /// <summary> A system generated property. A unique identifier. </summary>
        public string Rid { get; }
        /// <summary> A system generated property that denotes the last updated timestamp of the resource. </summary>
        public float? Timestamp { get; }
        /// <summary> A system generated property representing the resource etag required for optimistic concurrency control. </summary>
        public ETag? ETag { get; }
    }
}
