// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The gallery artifact version source. </summary>
    public partial class GalleryArtifactVersionSource
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GalleryArtifactVersionSource"/>. </summary>
        public GalleryArtifactVersionSource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GalleryArtifactVersionSource"/>. </summary>
        /// <param name="id"> The id of the gallery artifact version source. Can specify a disk uri, snapshot uri, user image or storage account resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GalleryArtifactVersionSource(ResourceIdentifier id, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The id of the gallery artifact version source. Can specify a disk uri, snapshot uri, user image or storage account resource. </summary>
        public ResourceIdentifier Id { get; set; }
    }
}
