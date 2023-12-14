// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The storage profile. </summary>
    internal partial class StorageProfile
    {
        /// <summary> Initializes a new instance of <see cref="StorageProfile"/>. </summary>
        public StorageProfile()
        {
            StorageAccounts = new ChangeTrackingList<HDInsightStorageAccountInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageProfile"/>. </summary>
        /// <param name="storageAccounts"> The list of storage accounts in the cluster. </param>
        internal StorageProfile(IList<HDInsightStorageAccountInfo> storageAccounts)
        {
            StorageAccounts = storageAccounts;
        }

        /// <summary> The list of storage accounts in the cluster. </summary>
        public IList<HDInsightStorageAccountInfo> StorageAccounts { get; }
    }
}
