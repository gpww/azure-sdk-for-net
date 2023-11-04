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
    /// <summary> The list capacity reservation operation response. </summary>
    internal partial class CapacityReservationListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CapacityReservationListResult"/>. </summary>
        /// <param name="value"> The list of capacity reservations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal CapacityReservationListResult(IEnumerable<CapacityReservationData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="CapacityReservationListResult"/>. </summary>
        /// <param name="value"> The list of capacity reservations. </param>
        /// <param name="nextLink"> The URI to fetch the next page of capacity reservations. Call ListNext() with this URI to fetch the next page of capacity reservations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CapacityReservationListResult(IReadOnlyList<CapacityReservationData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CapacityReservationListResult"/> for deserialization. </summary>
        internal CapacityReservationListResult()
        {
        }

        /// <summary> The list of capacity reservations. </summary>
        public IReadOnlyList<CapacityReservationData> Value { get; }
        /// <summary> The URI to fetch the next page of capacity reservations. Call ListNext() with this URI to fetch the next page of capacity reservations. </summary>
        public string NextLink { get; }
    }
}
