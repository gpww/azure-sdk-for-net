// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> Result of listing the run history of an export. </summary>
    internal partial class ExportExecutionListResult
    {
        /// <summary> Initializes a new instance of <see cref="ExportExecutionListResult"/>. </summary>
        public ExportExecutionListResult()
        {
            Value = new ChangeTrackingList<ExportRun>();
        }

        /// <summary> Initializes a new instance of <see cref="ExportExecutionListResult"/>. </summary>
        /// <param name="value"> A list of export runs. </param>
        internal ExportExecutionListResult(IReadOnlyList<ExportRun> value)
        {
            Value = value;
        }

        /// <summary> A list of export runs. </summary>
        public IReadOnlyList<ExportRun> Value { get; }
    }
}
