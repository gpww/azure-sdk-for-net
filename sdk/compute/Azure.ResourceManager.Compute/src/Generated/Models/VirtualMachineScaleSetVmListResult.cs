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
    /// <summary> The List Virtual Machine Scale Set VMs operation response. </summary>
    internal partial class VirtualMachineScaleSetVmListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetVmListResult"/>. </summary>
        /// <param name="value"> The list of virtual machine scale sets VMs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal VirtualMachineScaleSetVmListResult(IEnumerable<VirtualMachineScaleSetVmData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetVmListResult"/>. </summary>
        /// <param name="value"> The list of virtual machine scale sets VMs. </param>
        /// <param name="nextLink"> The uri to fetch the next page of Virtual Machine Scale Set VMs. Call ListNext() with this to fetch the next page of VMSS VMs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetVmListResult(IReadOnlyList<VirtualMachineScaleSetVmData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetVmListResult"/> for deserialization. </summary>
        internal VirtualMachineScaleSetVmListResult()
        {
        }

        /// <summary> The list of virtual machine scale sets VMs. </summary>
        public IReadOnlyList<VirtualMachineScaleSetVmData> Value { get; }
        /// <summary> The uri to fetch the next page of Virtual Machine Scale Set VMs. Call ListNext() with this to fetch the next page of VMSS VMs. </summary>
        public string NextLink { get; }
    }
}
