// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> A private link resource. </summary>
    public partial class AppServicePrivateLinkResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="AppServicePrivateLinkResourceData"/>. </summary>
        /// <param name="properties"> Properties of a private link resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        internal AppServicePrivateLinkResourceData(AppServicePrivateLinkResourceProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="AppServicePrivateLinkResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of a private link resource. </param>
        internal AppServicePrivateLinkResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AppServicePrivateLinkResourceProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Properties of a private link resource. </summary>
        public AppServicePrivateLinkResourceProperties Properties { get; }
    }
}
