// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> VMwareToAzStackHCI NIC properties. </summary>
    public partial class VMwareToAzStackHciProtectedNicProperties
    {
        /// <summary> Initializes a new instance of <see cref="VMwareToAzStackHciProtectedNicProperties"/>. </summary>
        internal VMwareToAzStackHciProtectedNicProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VMwareToAzStackHciProtectedNicProperties"/>. </summary>
        /// <param name="nicId"> Gets or sets the NIC Id. </param>
        /// <param name="macAddress"> Gets or sets the NIC mac address. </param>
        /// <param name="label"> Gets or sets the NIC label. </param>
        /// <param name="isPrimaryNic"> Gets or sets a value indicating whether this is the primary NIC. </param>
        /// <param name="networkName"> Gets or sets the network name. </param>
        /// <param name="targetNetworkId"> Gets or sets the target network Id within AzStackHCI Cluster. </param>
        /// <param name="testNetworkId"> Gets or sets the target test network Id within AzStackHCI Cluster. </param>
        /// <param name="selectionTypeForFailover"> Gets or sets the selection type of the NIC. </param>
        internal VMwareToAzStackHciProtectedNicProperties(string nicId, string macAddress, string label, bool? isPrimaryNic, string networkName, string targetNetworkId, string testNetworkId, VmNicSelection? selectionTypeForFailover)
        {
            NicId = nicId;
            MacAddress = macAddress;
            Label = label;
            IsPrimaryNic = isPrimaryNic;
            NetworkName = networkName;
            TargetNetworkId = targetNetworkId;
            TestNetworkId = testNetworkId;
            SelectionTypeForFailover = selectionTypeForFailover;
        }

        /// <summary> Gets or sets the NIC Id. </summary>
        public string NicId { get; }
        /// <summary> Gets or sets the NIC mac address. </summary>
        public string MacAddress { get; }
        /// <summary> Gets or sets the NIC label. </summary>
        public string Label { get; }
        /// <summary> Gets or sets a value indicating whether this is the primary NIC. </summary>
        public bool? IsPrimaryNic { get; }
        /// <summary> Gets or sets the network name. </summary>
        public string NetworkName { get; }
        /// <summary> Gets or sets the target network Id within AzStackHCI Cluster. </summary>
        public string TargetNetworkId { get; }
        /// <summary> Gets or sets the target test network Id within AzStackHCI Cluster. </summary>
        public string TestNetworkId { get; }
        /// <summary> Gets or sets the selection type of the NIC. </summary>
        public VmNicSelection? SelectionTypeForFailover { get; }
    }
}
