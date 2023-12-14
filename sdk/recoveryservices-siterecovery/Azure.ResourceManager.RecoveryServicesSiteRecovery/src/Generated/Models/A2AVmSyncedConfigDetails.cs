// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Azure to Azure VM synced configuration details. </summary>
    public partial class A2AVmSyncedConfigDetails
    {
        /// <summary> Initializes a new instance of <see cref="A2AVmSyncedConfigDetails"/>. </summary>
        internal A2AVmSyncedConfigDetails()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            VmEndpoints = new ChangeTrackingList<SiteRecoveryVmEndpoint>();
        }

        /// <summary> Initializes a new instance of <see cref="A2AVmSyncedConfigDetails"/>. </summary>
        /// <param name="tags"> The Azure VM tags. </param>
        /// <param name="vmEndpoints"> The Azure VM input endpoints. </param>
        internal A2AVmSyncedConfigDetails(IReadOnlyDictionary<string, string> tags, IReadOnlyList<SiteRecoveryVmEndpoint> vmEndpoints)
        {
            Tags = tags;
            VmEndpoints = vmEndpoints;
        }

        /// <summary> The Azure VM tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
        /// <summary> The Azure VM input endpoints. </summary>
        public IReadOnlyList<SiteRecoveryVmEndpoint> VmEndpoints { get; }
    }
}
