// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies information about the gallery image version that you want to
    /// update.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class GalleryImageVersionUpdate : UpdateResourceDefinition
    {
        /// <summary>
        /// Initializes a new instance of the GalleryImageVersionUpdate class.
        /// </summary>
        public GalleryImageVersionUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GalleryImageVersionUpdate class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="provisioningState">Possible values include:
        /// 'Creating', 'Updating', 'Failed', 'Succeeded', 'Deleting',
        /// 'Migrating'</param>
        public GalleryImageVersionUpdate(GalleryImageVersionStorageProfile storageProfile, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), GalleryImageVersionPublishingProfile publishingProfile = default(GalleryImageVersionPublishingProfile), string provisioningState = default(string), GalleryImageVersionSafetyProfile safetyProfile = default(GalleryImageVersionSafetyProfile), ReplicationStatus replicationStatus = default(ReplicationStatus), ImageVersionSecurityProfile securityProfile = default(ImageVersionSecurityProfile))
            : base(id, name, type, tags)
        {
            PublishingProfile = publishingProfile;
            ProvisioningState = provisioningState;
            StorageProfile = storageProfile;
            SafetyProfile = safetyProfile;
            ReplicationStatus = replicationStatus;
            SecurityProfile = securityProfile;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishingProfile")]
        public GalleryImageVersionPublishingProfile PublishingProfile { get; set; }

        /// <summary>
        /// Gets possible values include: 'Creating', 'Updating', 'Failed',
        /// 'Succeeded', 'Deleting', 'Migrating'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageProfile")]
        public GalleryImageVersionStorageProfile StorageProfile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.safetyProfile")]
        public GalleryImageVersionSafetyProfile SafetyProfile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.replicationStatus")]
        public ReplicationStatus ReplicationStatus { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.securityProfile")]
        public ImageVersionSecurityProfile SecurityProfile { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageProfile == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageProfile");
            }
        }
    }
}
