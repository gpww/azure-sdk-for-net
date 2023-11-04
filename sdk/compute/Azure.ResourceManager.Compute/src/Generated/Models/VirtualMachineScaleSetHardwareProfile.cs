// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the hardware settings for the virtual machine scale set. </summary>
    internal partial class VirtualMachineScaleSetHardwareProfile
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetHardwareProfile"/>. </summary>
        public VirtualMachineScaleSetHardwareProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetHardwareProfile"/>. </summary>
        /// <param name="vmSizeProperties"> Specifies the properties for customizing the size of the virtual machine. Minimum api-version: 2021-11-01. Please follow the instructions in [VM Customization](https://aka.ms/vmcustomization) for more details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetHardwareProfile(VirtualMachineSizeProperties vmSizeProperties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VmSizeProperties = vmSizeProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the properties for customizing the size of the virtual machine. Minimum api-version: 2021-11-01. Please follow the instructions in [VM Customization](https://aka.ms/vmcustomization) for more details. </summary>
        public VirtualMachineSizeProperties VmSizeProperties { get; set; }
    }
}
