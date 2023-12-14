// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Network Intent Policy resource. </summary>
    public partial class NetworkIntentPolicy : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="NetworkIntentPolicy"/>. </summary>
        public NetworkIntentPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkIntentPolicy"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        internal NetworkIntentPolicy(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, ETag? etag) : base(id, name, resourceType, location, tags)
        {
            ETag = etag;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
    }
}
