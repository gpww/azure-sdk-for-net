// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The gallery images resource patch definition. </summary>
    public partial class GalleryImagePatch
    {
        /// <summary> Initializes a new instance of <see cref="GalleryImagePatch"/>. </summary>
        public GalleryImagePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="GalleryImagePatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        internal GalleryImagePatch(IDictionary<string, string> tags)
        {
            Tags = tags;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
