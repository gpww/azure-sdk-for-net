// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PowerBIDedicated.Models
{
    /// <summary> An object that represents enumerating SKUs for new resources. </summary>
    internal partial class SkuEnumerationForNewResourceResult
    {
        /// <summary> Initializes a new instance of <see cref="SkuEnumerationForNewResourceResult"/>. </summary>
        internal SkuEnumerationForNewResourceResult()
        {
            Value = new ChangeTrackingList<CapacitySku>();
        }

        /// <summary> Initializes a new instance of <see cref="SkuEnumerationForNewResourceResult"/>. </summary>
        /// <param name="value"> The collection of available SKUs for new resources. </param>
        internal SkuEnumerationForNewResourceResult(IReadOnlyList<CapacitySku> value)
        {
            Value = value;
        }

        /// <summary> The collection of available SKUs for new resources. </summary>
        public IReadOnlyList<CapacitySku> Value { get; }
    }
}
