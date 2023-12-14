// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Collection of available workload profiles in the location. </summary>
    internal partial class AvailableWorkloadProfilesCollection
    {
        /// <summary> Initializes a new instance of <see cref="AvailableWorkloadProfilesCollection"/>. </summary>
        /// <param name="value"> Collection of workload profiles. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal AvailableWorkloadProfilesCollection(IEnumerable<ContainerAppAvailableWorkloadProfile> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AvailableWorkloadProfilesCollection"/>. </summary>
        /// <param name="value"> Collection of workload profiles. </param>
        /// <param name="nextLink"> Link to next page of resources. </param>
        internal AvailableWorkloadProfilesCollection(IReadOnlyList<ContainerAppAvailableWorkloadProfile> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of workload profiles. </summary>
        public IReadOnlyList<ContainerAppAvailableWorkloadProfile> Value { get; }
        /// <summary> Link to next page of resources. </summary>
        public string NextLink { get; }
    }
}
