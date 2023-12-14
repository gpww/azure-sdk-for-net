// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.StorageSync;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Array of ServerEndpoint. </summary>
    internal partial class ServerEndpointArray
    {
        /// <summary> Initializes a new instance of <see cref="ServerEndpointArray"/>. </summary>
        internal ServerEndpointArray()
        {
            Value = new ChangeTrackingList<StorageSyncServerEndpointData>();
        }

        /// <summary> Initializes a new instance of <see cref="ServerEndpointArray"/>. </summary>
        /// <param name="value"> Collection of ServerEndpoint. </param>
        internal ServerEndpointArray(IReadOnlyList<StorageSyncServerEndpointData> value)
        {
            Value = value;
        }

        /// <summary> Collection of ServerEndpoint. </summary>
        public IReadOnlyList<StorageSyncServerEndpointData> Value { get; }
    }
}
