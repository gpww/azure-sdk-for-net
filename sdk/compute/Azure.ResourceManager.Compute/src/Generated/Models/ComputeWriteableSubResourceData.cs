// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The ComputeWriteableSubResourceData. </summary>
    public partial class ComputeWriteableSubResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ComputeWriteableSubResourceData"/>. </summary>
        public ComputeWriteableSubResourceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ComputeWriteableSubResourceData"/>. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComputeWriteableSubResourceData(ResourceIdentifier id, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}
