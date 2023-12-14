// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.KeyVault;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> List of vaults. </summary>
    internal partial class VaultListResult
    {
        /// <summary> Initializes a new instance of <see cref="VaultListResult"/>. </summary>
        internal VaultListResult()
        {
            Value = new ChangeTrackingList<KeyVaultData>();
        }

        /// <summary> Initializes a new instance of <see cref="VaultListResult"/>. </summary>
        /// <param name="value"> The list of vaults. </param>
        /// <param name="nextLink"> The URL to get the next set of vaults. </param>
        internal VaultListResult(IReadOnlyList<KeyVaultData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of vaults. </summary>
        public IReadOnlyList<KeyVaultData> Value { get; }
        /// <summary> The URL to get the next set of vaults. </summary>
        public string NextLink { get; }
    }
}
