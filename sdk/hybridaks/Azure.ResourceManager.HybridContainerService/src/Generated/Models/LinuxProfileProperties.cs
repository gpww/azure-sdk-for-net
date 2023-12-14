// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> LinuxProfile - Profile for Linux VMs in the container service cluster. </summary>
    public partial class LinuxProfileProperties
    {
        /// <summary> Initializes a new instance of <see cref="LinuxProfileProperties"/>. </summary>
        public LinuxProfileProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LinuxProfileProperties"/>. </summary>
        /// <param name="adminUsername"> AdminUsername - The administrator username to use for Linux VMs. </param>
        /// <param name="ssh"> SSH - SSH configuration for Linux-based VMs running on Azure. </param>
        internal LinuxProfileProperties(string adminUsername, LinuxProfilePropertiesSsh ssh)
        {
            AdminUsername = adminUsername;
            Ssh = ssh;
        }

        /// <summary> AdminUsername - The administrator username to use for Linux VMs. </summary>
        public string AdminUsername { get; set; }
        /// <summary> SSH - SSH configuration for Linux-based VMs running on Azure. </summary>
        internal LinuxProfilePropertiesSsh Ssh { get; set; }
        /// <summary> PublicKeys - The list of SSH public keys used to authenticate with Linux-based VMs. Only expect one key specified. </summary>
        public IList<LinuxProfilePropertiesSshPublicKeysItem> SshPublicKeys
        {
            get
            {
                if (Ssh is null)
                    Ssh = new LinuxProfilePropertiesSsh();
                return Ssh.PublicKeys;
            }
        }
    }
}
