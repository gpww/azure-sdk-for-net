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
    /// <summary> The List Image operation response. </summary>
    internal partial class ImageListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ImageListResult"/>. </summary>
        /// <param name="value"> The list of Images. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ImageListResult(IEnumerable<DiskImageData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ImageListResult"/>. </summary>
        /// <param name="value"> The list of Images. </param>
        /// <param name="nextLink"> The uri to fetch the next page of Images. Call ListNext() with this to fetch the next page of Images. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ImageListResult(IReadOnlyList<DiskImageData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ImageListResult"/> for deserialization. </summary>
        internal ImageListResult()
        {
        }

        /// <summary> The list of Images. </summary>
        public IReadOnlyList<DiskImageData> Value { get; }
        /// <summary> The uri to fetch the next page of Images. Call ListNext() with this to fetch the next page of Images. </summary>
        public string NextLink { get; }
    }
}
