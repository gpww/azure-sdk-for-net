// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing the Gallery data model.
    /// Specifies information about the Shared Image Gallery that you want to create or update.
    /// </summary>
    public partial class GalleryData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GalleryData"/>. </summary>
        /// <param name="location"> The location. </param>
        public GalleryData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="GalleryData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="description"> The description of this Shared Image Gallery resource. This property is updatable. </param>
        /// <param name="identifier"> Describes the gallery unique name. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="sharingProfile"> Profile for gallery sharing to subscription or tenant. </param>
        /// <param name="softDeletePolicy"> Contains information about the soft deletion policy of the gallery. </param>
        /// <param name="sharingStatus"> Sharing status of current gallery. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GalleryData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string description, GalleryIdentifier identifier, GalleryProvisioningState? provisioningState, SharingProfile sharingProfile, SoftDeletePolicy softDeletePolicy, SharingStatus sharingStatus, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Description = description;
            Identifier = identifier;
            ProvisioningState = provisioningState;
            SharingProfile = sharingProfile;
            SoftDeletePolicy = softDeletePolicy;
            SharingStatus = sharingStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GalleryData"/> for deserialization. </summary>
        internal GalleryData()
        {
        }

        /// <summary> The description of this Shared Image Gallery resource. This property is updatable. </summary>
        public string Description { get; set; }
        /// <summary> Describes the gallery unique name. </summary>
        internal GalleryIdentifier Identifier { get; set; }
        /// <summary> The unique name of the Shared Image Gallery. This name is generated automatically by Azure. </summary>
        public string IdentifierUniqueName
        {
            get => Identifier is null ? default : Identifier.UniqueName;
        }

        /// <summary> The provisioning state, which only appears in the response. </summary>
        public GalleryProvisioningState? ProvisioningState { get; }
        /// <summary> Profile for gallery sharing to subscription or tenant. </summary>
        public SharingProfile SharingProfile { get; set; }
        /// <summary> Contains information about the soft deletion policy of the gallery. </summary>
        internal SoftDeletePolicy SoftDeletePolicy { get; set; }
        /// <summary> Enables soft-deletion for resources in this gallery, allowing them to be recovered within retention time. </summary>
        public bool? IsSoftDeleteEnabled
        {
            get => SoftDeletePolicy is null ? default : SoftDeletePolicy.IsSoftDeleteEnabled;
            set
            {
                if (SoftDeletePolicy is null)
                    SoftDeletePolicy = new SoftDeletePolicy();
                SoftDeletePolicy.IsSoftDeleteEnabled = value;
            }
        }

        /// <summary> Sharing status of current gallery. </summary>
        public SharingStatus SharingStatus { get; }
    }
}
