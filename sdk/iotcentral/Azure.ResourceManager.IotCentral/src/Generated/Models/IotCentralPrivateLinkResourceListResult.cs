// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.IotCentral;

namespace Azure.ResourceManager.IotCentral.Models
{
    /// <summary> A list of private link resources. </summary>
    internal partial class IotCentralPrivateLinkResourceListResult
    {
        /// <summary> Initializes a new instance of <see cref="IotCentralPrivateLinkResourceListResult"/>. </summary>
        internal IotCentralPrivateLinkResourceListResult()
        {
            Value = new ChangeTrackingList<IotCentralPrivateLinkResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="IotCentralPrivateLinkResourceListResult"/>. </summary>
        /// <param name="value"> Array of private link resources. </param>
        internal IotCentralPrivateLinkResourceListResult(IReadOnlyList<IotCentralPrivateLinkResourceData> value)
        {
            Value = value;
        }

        /// <summary> Array of private link resources. </summary>
        public IReadOnlyList<IotCentralPrivateLinkResourceData> Value { get; }
    }
}
