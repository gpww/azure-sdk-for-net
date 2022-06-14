// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The regional capabilities. </summary>
    public partial class ContainerInstanceCapabilities : ResourceData
    {
        /// <summary> Initializes a new instance of ContainerInstanceCapabilities. </summary>
        internal ContainerInstanceCapabilities()
        {
        }

        /// <summary> Initializes a new instance of ContainerInstanceCapabilities. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="osType"> The OS type that this capability describes. </param>
        /// <param name="location"> The resource location. </param>
        /// <param name="ipAddressType"> The ip address type that this capability describes. </param>
        /// <param name="gpu"> The GPU sku that this capability describes. </param>
        /// <param name="capabilities"> The supported capabilities. </param>
        internal ContainerInstanceCapabilities(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string osType, AzureLocation? location, string ipAddressType, string gpu, Capabilities capabilities) : base(id, name, resourceType, systemData)
        {
            OSType = osType;
            Location = location;
            IPAddressType = ipAddressType;
            Gpu = gpu;
            Capabilities = capabilities;
        }

        /// <summary> The OS type that this capability describes. </summary>
        public string OSType { get; }
        /// <summary> The resource location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The ip address type that this capability describes. </summary>
        public string IPAddressType { get; }
        /// <summary> The GPU sku that this capability describes. </summary>
        public string Gpu { get; }
        /// <summary> The supported capabilities. </summary>
        public Capabilities Capabilities { get; }
    }
}
