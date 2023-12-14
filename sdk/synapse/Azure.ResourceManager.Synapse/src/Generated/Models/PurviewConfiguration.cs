// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Purview Configuration. </summary>
    internal partial class PurviewConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="PurviewConfiguration"/>. </summary>
        public PurviewConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PurviewConfiguration"/>. </summary>
        /// <param name="purviewResourceId"> Purview Resource ID. </param>
        internal PurviewConfiguration(ResourceIdentifier purviewResourceId)
        {
            PurviewResourceId = purviewResourceId;
        }

        /// <summary> Purview Resource ID. </summary>
        public ResourceIdentifier PurviewResourceId { get; set; }
    }
}
