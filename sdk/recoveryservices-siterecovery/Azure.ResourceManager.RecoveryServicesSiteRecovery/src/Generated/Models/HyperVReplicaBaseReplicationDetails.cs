// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Hyper V replica provider specific settings base class. </summary>
    public partial class HyperVReplicaBaseReplicationDetails : ReplicationProviderSpecificSettings
    {
        /// <summary> Initializes a new instance of <see cref="HyperVReplicaBaseReplicationDetails"/>. </summary>
        internal HyperVReplicaBaseReplicationDetails()
        {
            VmNics = new ChangeTrackingList<VmNicDetails>();
            VmDiskDetails = new ChangeTrackingList<SiteRecoveryDiskDetails>();
            InstanceType = "HyperVReplicaBaseReplicationDetails";
        }

        /// <summary> Initializes a new instance of <see cref="HyperVReplicaBaseReplicationDetails"/>. </summary>
        /// <param name="instanceType"> Gets the Instance type. </param>
        /// <param name="lastReplicatedOn"> The Last replication time. </param>
        /// <param name="vmNics"> The PE Network details. </param>
        /// <param name="vmId"> The virtual machine Id. </param>
        /// <param name="vmProtectionState"> The protection state for the vm. </param>
        /// <param name="vmProtectionStateDescription"> The protection state description for the vm. </param>
        /// <param name="initialReplicationDetails"> Initial replication details. </param>
        /// <param name="vmDiskDetails"> VM disk details. </param>
        internal HyperVReplicaBaseReplicationDetails(string instanceType, DateTimeOffset? lastReplicatedOn, IReadOnlyList<VmNicDetails> vmNics, string vmId, string vmProtectionState, string vmProtectionStateDescription, InitialReplicationDetails initialReplicationDetails, IReadOnlyList<SiteRecoveryDiskDetails> vmDiskDetails) : base(instanceType)
        {
            LastReplicatedOn = lastReplicatedOn;
            VmNics = vmNics;
            VmId = vmId;
            VmProtectionState = vmProtectionState;
            VmProtectionStateDescription = vmProtectionStateDescription;
            InitialReplicationDetails = initialReplicationDetails;
            VmDiskDetails = vmDiskDetails;
            InstanceType = instanceType ?? "HyperVReplicaBaseReplicationDetails";
        }

        /// <summary> The Last replication time. </summary>
        public DateTimeOffset? LastReplicatedOn { get; }
        /// <summary> The PE Network details. </summary>
        public IReadOnlyList<VmNicDetails> VmNics { get; }
        /// <summary> The virtual machine Id. </summary>
        public string VmId { get; }
        /// <summary> The protection state for the vm. </summary>
        public string VmProtectionState { get; }
        /// <summary> The protection state description for the vm. </summary>
        public string VmProtectionStateDescription { get; }
        /// <summary> Initial replication details. </summary>
        public InitialReplicationDetails InitialReplicationDetails { get; }
        /// <summary> VM disk details. </summary>
        public IReadOnlyList<SiteRecoveryDiskDetails> VmDiskDetails { get; }
    }
}
