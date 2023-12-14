// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Recovery plan InMageAzureV2 failover input. </summary>
    public partial class RecoveryPlanInMageAzureV2FailoverContent : RecoveryPlanProviderSpecificFailoverContent
    {
        /// <summary> Initializes a new instance of <see cref="RecoveryPlanInMageAzureV2FailoverContent"/>. </summary>
        /// <param name="recoveryPointType"> The recovery point type. </param>
        public RecoveryPlanInMageAzureV2FailoverContent(InMageV2RpRecoveryPointType recoveryPointType)
        {
            RecoveryPointType = recoveryPointType;
            InstanceType = "InMageAzureV2";
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryPlanInMageAzureV2FailoverContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="recoveryPointType"> The recovery point type. </param>
        /// <param name="useMultiVmSyncPoint"> A value indicating whether multi VM sync enabled VMs should use multi VM sync points for failover. </param>
        internal RecoveryPlanInMageAzureV2FailoverContent(string instanceType, InMageV2RpRecoveryPointType recoveryPointType, string useMultiVmSyncPoint) : base(instanceType)
        {
            RecoveryPointType = recoveryPointType;
            UseMultiVmSyncPoint = useMultiVmSyncPoint;
            InstanceType = instanceType ?? "InMageAzureV2";
        }

        /// <summary> The recovery point type. </summary>
        public InMageV2RpRecoveryPointType RecoveryPointType { get; }
        /// <summary> A value indicating whether multi VM sync enabled VMs should use multi VM sync points for failover. </summary>
        public string UseMultiVmSyncPoint { get; set; }
    }
}
