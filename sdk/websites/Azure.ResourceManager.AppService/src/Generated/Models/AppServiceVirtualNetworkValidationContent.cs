// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The required set of inputs to validate a VNET. </summary>
    public partial class AppServiceVirtualNetworkValidationContent : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="AppServiceVirtualNetworkValidationContent"/>. </summary>
        public AppServiceVirtualNetworkValidationContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceVirtualNetworkValidationContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="vnetResourceGroup"> The Resource Group of the VNET to be validated. </param>
        /// <param name="vnetName"> The name of the VNET to be validated. </param>
        /// <param name="vnetSubnetName"> The subnet name to be validated. </param>
        /// <param name="subnetResourceId"> The ARM Resource ID of the subnet to validate. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal AppServiceVirtualNetworkValidationContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string vnetResourceGroup, string vnetName, string vnetSubnetName, ResourceIdentifier subnetResourceId, string kind) : base(id, name, resourceType, systemData)
        {
            VnetResourceGroup = vnetResourceGroup;
            VnetName = vnetName;
            VnetSubnetName = vnetSubnetName;
            SubnetResourceId = subnetResourceId;
            Kind = kind;
        }

        /// <summary> The Resource Group of the VNET to be validated. </summary>
        public string VnetResourceGroup { get; set; }
        /// <summary> The name of the VNET to be validated. </summary>
        public string VnetName { get; set; }
        /// <summary> The subnet name to be validated. </summary>
        public string VnetSubnetName { get; set; }
        /// <summary> The ARM Resource ID of the subnet to validate. </summary>
        public ResourceIdentifier SubnetResourceId { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
