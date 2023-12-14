// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AlertsManagement;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> List the alerts. </summary>
    internal partial class SmartGroupsList
    {
        /// <summary> Initializes a new instance of <see cref="SmartGroupsList"/>. </summary>
        internal SmartGroupsList()
        {
            Value = new ChangeTrackingList<SmartGroupData>();
        }

        /// <summary> Initializes a new instance of <see cref="SmartGroupsList"/>. </summary>
        /// <param name="nextLink"> URL to fetch the next set of alerts. </param>
        /// <param name="value"> List of alerts. </param>
        internal SmartGroupsList(string nextLink, IReadOnlyList<SmartGroupData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> URL to fetch the next set of alerts. </summary>
        public string NextLink { get; }
        /// <summary> List of alerts. </summary>
        public IReadOnlyList<SmartGroupData> Value { get; }
    }
}
