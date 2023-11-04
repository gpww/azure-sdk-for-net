// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The List VMSS VM Extension operation response. </summary>
    internal partial class VirtualMachineScaleSetVmExtensionsListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetVmExtensionsListResult"/>. </summary>
        internal VirtualMachineScaleSetVmExtensionsListResult()
        {
            Value = new ChangeTrackingList<VirtualMachineScaleSetVmExtensionData>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetVmExtensionsListResult"/>. </summary>
        /// <param name="value"> The list of VMSS VM extensions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetVmExtensionsListResult(IReadOnlyList<VirtualMachineScaleSetVmExtensionData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of VMSS VM extensions. </summary>
        public IReadOnlyList<VirtualMachineScaleSetVmExtensionData> Value { get; }
    }
}
