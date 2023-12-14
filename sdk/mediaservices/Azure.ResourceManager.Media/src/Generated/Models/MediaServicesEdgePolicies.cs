// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The MediaServicesEdgePolicies. </summary>
    public partial class MediaServicesEdgePolicies
    {
        /// <summary> Initializes a new instance of <see cref="MediaServicesEdgePolicies"/>. </summary>
        internal MediaServicesEdgePolicies()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MediaServicesEdgePolicies"/>. </summary>
        /// <param name="usageDataCollectionPolicy"></param>
        internal MediaServicesEdgePolicies(EdgeUsageDataCollectionPolicy usageDataCollectionPolicy)
        {
            UsageDataCollectionPolicy = usageDataCollectionPolicy;
        }

        /// <summary> Gets the usage data collection policy. </summary>
        public EdgeUsageDataCollectionPolicy UsageDataCollectionPolicy { get; }
    }
}
