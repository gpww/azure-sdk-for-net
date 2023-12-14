// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Network Properties. </summary>
    public partial class SiteRecoveryNetworkProperties
    {
        /// <summary> Initializes a new instance of <see cref="SiteRecoveryNetworkProperties"/>. </summary>
        internal SiteRecoveryNetworkProperties()
        {
            Subnets = new ChangeTrackingList<SiteRecoverySubnet>();
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryNetworkProperties"/>. </summary>
        /// <param name="fabricType"> The Fabric Type. </param>
        /// <param name="subnets"> The List of subnets. </param>
        /// <param name="friendlyName"> The Friendly Name. </param>
        /// <param name="networkType"> The Network Type. </param>
        internal SiteRecoveryNetworkProperties(string fabricType, IReadOnlyList<SiteRecoverySubnet> subnets, string friendlyName, string networkType)
        {
            FabricType = fabricType;
            Subnets = subnets;
            FriendlyName = friendlyName;
            NetworkType = networkType;
        }

        /// <summary> The Fabric Type. </summary>
        public string FabricType { get; }
        /// <summary> The List of subnets. </summary>
        public IReadOnlyList<SiteRecoverySubnet> Subnets { get; }
        /// <summary> The Friendly Name. </summary>
        public string FriendlyName { get; }
        /// <summary> The Network Type. </summary>
        public string NetworkType { get; }
    }
}
