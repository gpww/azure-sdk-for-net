// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ResourceHealth;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> The List of eventImpactedResources operation response. </summary>
    internal partial class EventImpactedResourceListResult
    {
        /// <summary> Initializes a new instance of EventImpactedResourceListResult. </summary>
        /// <param name="value"> The list of eventImpactedResources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal EventImpactedResourceListResult(IEnumerable<ResourceHealthEventImpactedResourceData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of EventImpactedResourceListResult. </summary>
        /// <param name="value"> The list of eventImpactedResources. </param>
        /// <param name="nextLink"> The URI to fetch the next page of events. Call ListNext() with this URI to fetch the next page of impacted resource. </param>
        internal EventImpactedResourceListResult(IReadOnlyList<ResourceHealthEventImpactedResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of eventImpactedResources. </summary>
        public IReadOnlyList<ResourceHealthEventImpactedResourceData> Value { get; }
        /// <summary> The URI to fetch the next page of events. Call ListNext() with this URI to fetch the next page of impacted resource. </summary>
        public string NextLink { get; }
    }
}
