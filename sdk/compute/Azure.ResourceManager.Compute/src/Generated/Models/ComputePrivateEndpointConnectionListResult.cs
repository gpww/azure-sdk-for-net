// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> A list of private link resources. </summary>
    internal partial class ComputePrivateEndpointConnectionListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ComputePrivateEndpointConnectionListResult"/>. </summary>
        internal ComputePrivateEndpointConnectionListResult()
        {
            Value = new ChangeTrackingList<ComputePrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="ComputePrivateEndpointConnectionListResult"/>. </summary>
        /// <param name="value"> Array of private endpoint connections. </param>
        /// <param name="nextLink"> The uri to fetch the next page of snapshots. Call ListNext() with this to fetch the next page of snapshots. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComputePrivateEndpointConnectionListResult(IReadOnlyList<ComputePrivateEndpointConnectionData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Array of private endpoint connections. </summary>
        public IReadOnlyList<ComputePrivateEndpointConnectionData> Value { get; }
        /// <summary> The uri to fetch the next page of snapshots. Call ListNext() with this to fetch the next page of snapshots. </summary>
        public string NextLink { get; }
    }
}
