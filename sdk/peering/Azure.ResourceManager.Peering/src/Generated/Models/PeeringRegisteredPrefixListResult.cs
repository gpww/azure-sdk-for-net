// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Peering;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The paginated list of peering registered prefixes. </summary>
    internal partial class PeeringRegisteredPrefixListResult
    {
        /// <summary> Initializes a new instance of <see cref="PeeringRegisteredPrefixListResult"/>. </summary>
        internal PeeringRegisteredPrefixListResult()
        {
            Value = new ChangeTrackingList<PeeringRegisteredPrefixData>();
        }

        /// <summary> Initializes a new instance of <see cref="PeeringRegisteredPrefixListResult"/>. </summary>
        /// <param name="value"> The list of peering registered prefixes. </param>
        /// <param name="nextLink"> The link to fetch the next page of peering registered prefixes. </param>
        internal PeeringRegisteredPrefixListResult(IReadOnlyList<PeeringRegisteredPrefixData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of peering registered prefixes. </summary>
        public IReadOnlyList<PeeringRegisteredPrefixData> Value { get; }
        /// <summary> The link to fetch the next page of peering registered prefixes. </summary>
        public string NextLink { get; }
    }
}
