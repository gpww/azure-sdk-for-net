// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> SSH configuration for Linux based VMs running on Azure. </summary>
    internal partial class SapSshConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="SapSshConfiguration"/>. </summary>
        public SapSshConfiguration()
        {
            PublicKeys = new ChangeTrackingList<SapSshPublicKey>();
        }

        /// <summary> Initializes a new instance of <see cref="SapSshConfiguration"/>. </summary>
        /// <param name="publicKeys"> The list of SSH public keys used to authenticate with linux based VMs. </param>
        internal SapSshConfiguration(IList<SapSshPublicKey> publicKeys)
        {
            PublicKeys = publicKeys;
        }

        /// <summary> The list of SSH public keys used to authenticate with linux based VMs. </summary>
        public IList<SapSshPublicKey> PublicKeys { get; }
    }
}
