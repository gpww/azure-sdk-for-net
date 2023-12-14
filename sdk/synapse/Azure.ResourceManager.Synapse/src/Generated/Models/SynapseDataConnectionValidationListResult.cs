// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The list Kusto data connection validation result. </summary>
    public partial class SynapseDataConnectionValidationListResult
    {
        /// <summary> Initializes a new instance of <see cref="SynapseDataConnectionValidationListResult"/>. </summary>
        internal SynapseDataConnectionValidationListResult()
        {
            Value = new ChangeTrackingList<SynapseDataConnectionValidationResult>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseDataConnectionValidationListResult"/>. </summary>
        /// <param name="value"> The list of Kusto data connection validation errors. </param>
        internal SynapseDataConnectionValidationListResult(IReadOnlyList<SynapseDataConnectionValidationResult> value)
        {
            Value = value;
        }

        /// <summary> The list of Kusto data connection validation errors. </summary>
        public IReadOnlyList<SynapseDataConnectionValidationResult> Value { get; }
    }
}
