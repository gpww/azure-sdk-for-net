// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> List of virtual network gateway vpn client connection health. </summary>
    public partial class VpnClientConnectionHealthDetailListResult
    {
        /// <summary> Initializes a new instance of <see cref="VpnClientConnectionHealthDetailListResult"/>. </summary>
        internal VpnClientConnectionHealthDetailListResult()
        {
            Value = new ChangeTrackingList<VpnClientConnectionHealthDetail>();
        }

        /// <summary> Initializes a new instance of <see cref="VpnClientConnectionHealthDetailListResult"/>. </summary>
        /// <param name="value"> List of vpn client connection health. </param>
        internal VpnClientConnectionHealthDetailListResult(IReadOnlyList<VpnClientConnectionHealthDetail> value)
        {
            Value = value;
        }

        /// <summary> List of vpn client connection health. </summary>
        public IReadOnlyList<VpnClientConnectionHealthDetail> Value { get; }
    }
}
