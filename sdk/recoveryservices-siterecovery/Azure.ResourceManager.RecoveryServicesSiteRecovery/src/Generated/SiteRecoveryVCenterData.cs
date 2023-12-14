// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing the SiteRecoveryVCenter data model.
    /// vCenter definition.
    /// </summary>
    public partial class SiteRecoveryVCenterData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="SiteRecoveryVCenterData"/>. </summary>
        internal SiteRecoveryVCenterData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryVCenterData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> VCenter related data. </param>
        /// <param name="location"> Resource Location. </param>
        internal SiteRecoveryVCenterData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SiteRecoveryVCenterProperties properties, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Location = location;
        }

        /// <summary> VCenter related data. </summary>
        public SiteRecoveryVCenterProperties Properties { get; }
        /// <summary> Resource Location. </summary>
        public AzureLocation? Location { get; }
    }
}
