// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DefenderEasm.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DefenderEasm
{
    /// <summary>
    /// A class representing the EasmWorkspace data model.
    /// Workspace details.
    /// </summary>
    public partial class EasmWorkspaceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="EasmWorkspaceData"/>. </summary>
        /// <param name="location"> The location. </param>
        public EasmWorkspaceData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="EasmWorkspaceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> Resource provisioning state. </param>
        /// <param name="dataPlaneEndpoint"> Data plane endpoint. </param>
        internal EasmWorkspaceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, EasmResourceProvisioningState? provisioningState, string dataPlaneEndpoint) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            DataPlaneEndpoint = dataPlaneEndpoint;
        }

        /// <summary> Resource provisioning state. </summary>
        public EasmResourceProvisioningState? ProvisioningState { get; }
        /// <summary> Data plane endpoint. </summary>
        public string DataPlaneEndpoint { get; }
    }
}
