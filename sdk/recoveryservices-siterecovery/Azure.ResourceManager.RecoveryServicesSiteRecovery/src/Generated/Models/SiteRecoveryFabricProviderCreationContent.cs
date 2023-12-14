// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Fabric provider specific settings. </summary>
    public partial class SiteRecoveryFabricProviderCreationContent : FabricSpecificCreationContent
    {
        /// <summary> Initializes a new instance of <see cref="SiteRecoveryFabricProviderCreationContent"/>. </summary>
        public SiteRecoveryFabricProviderCreationContent()
        {
            InstanceType = "Azure";
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryFabricProviderCreationContent"/>. </summary>
        /// <param name="instanceType"> Gets the class type. </param>
        /// <param name="location"> The Location. </param>
        internal SiteRecoveryFabricProviderCreationContent(string instanceType, AzureLocation? location) : base(instanceType)
        {
            Location = location;
            InstanceType = instanceType ?? "Azure";
        }

        /// <summary> The Location. </summary>
        public AzureLocation? Location { get; set; }
    }
}
