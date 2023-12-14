// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB MongoDB collection index key. </summary>
    public partial class MongoDBIndex
    {
        /// <summary> Initializes a new instance of <see cref="MongoDBIndex"/>. </summary>
        public MongoDBIndex()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBIndex"/>. </summary>
        /// <param name="key"> Cosmos DB MongoDB collection index keys. </param>
        /// <param name="options"> Cosmos DB MongoDB collection index key options. </param>
        internal MongoDBIndex(MongoIndexKeys key, MongoDBIndexConfig options)
        {
            Key = key;
            Options = options;
        }

        /// <summary> Cosmos DB MongoDB collection index keys. </summary>
        internal MongoIndexKeys Key { get; set; }
        /// <summary> List of keys for each MongoDB collection in the Azure Cosmos DB service. </summary>
        public IList<string> Keys
        {
            get
            {
                if (Key is null)
                    Key = new MongoIndexKeys();
                return Key.Keys;
            }
        }

        /// <summary> Cosmos DB MongoDB collection index key options. </summary>
        public MongoDBIndexConfig Options { get; set; }
    }
}
