// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Recovery plan A2A specific details. </summary>
    public partial class RecoveryPlanA2ADetails : RecoveryPlanProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of RecoveryPlanA2ADetails. </summary>
        internal RecoveryPlanA2ADetails()
        {
            InstanceType = "A2A";
        }

        /// <summary> Initializes a new instance of RecoveryPlanA2ADetails. </summary>
        /// <param name="instanceType"> Gets the Instance type. </param>
        /// <param name="primaryZone"> The primary zone. </param>
        /// <param name="recoveryZone"> The recovery zone. </param>
        /// <param name="primaryExtendedLocation"> The primary extended location. </param>
        /// <param name="recoveryExtendedLocation"> The recovery extended location. </param>
        internal RecoveryPlanA2ADetails(string instanceType, string primaryZone, string recoveryZone, SiteRecoveryExtendedLocation primaryExtendedLocation, SiteRecoveryExtendedLocation recoveryExtendedLocation) : base(instanceType)
        {
            PrimaryZone = primaryZone;
            RecoveryZone = recoveryZone;
            PrimaryExtendedLocation = primaryExtendedLocation;
            RecoveryExtendedLocation = recoveryExtendedLocation;
            InstanceType = instanceType ?? "A2A";
        }

        /// <summary> The primary zone. </summary>
        public string PrimaryZone { get; }
        /// <summary> The recovery zone. </summary>
        public string RecoveryZone { get; }
        /// <summary> The primary extended location. </summary>
        public SiteRecoveryExtendedLocation PrimaryExtendedLocation { get; }
        /// <summary> The recovery extended location. </summary>
        public SiteRecoveryExtendedLocation RecoveryExtendedLocation { get; }
    }
}
