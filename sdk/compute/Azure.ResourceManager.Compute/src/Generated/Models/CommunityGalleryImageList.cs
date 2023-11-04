// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The List Community Gallery Images operation response. </summary>
    internal partial class CommunityGalleryImageList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CommunityGalleryImageList"/>. </summary>
        /// <param name="value"> A list of community gallery images. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal CommunityGalleryImageList(IEnumerable<CommunityGalleryImageData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="CommunityGalleryImageList"/>. </summary>
        /// <param name="value"> A list of community gallery images. </param>
        /// <param name="nextLink"> The uri to fetch the next page of community gallery images. Call ListNext() with this to fetch the next page of community gallery images. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CommunityGalleryImageList(IReadOnlyList<CommunityGalleryImageData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CommunityGalleryImageList"/> for deserialization. </summary>
        internal CommunityGalleryImageList()
        {
        }

        /// <summary> A list of community gallery images. </summary>
        public IReadOnlyList<CommunityGalleryImageData> Value { get; }
        /// <summary> The uri to fetch the next page of community gallery images. Call ListNext() with this to fetch the next page of community gallery images. </summary>
        public string NextLink { get; }
    }
}
