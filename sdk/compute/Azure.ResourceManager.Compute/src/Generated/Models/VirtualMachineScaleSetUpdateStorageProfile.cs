// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a virtual machine scale set storage profile. </summary>
    public partial class VirtualMachineScaleSetUpdateStorageProfile
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetUpdateStorageProfile"/>. </summary>
        public VirtualMachineScaleSetUpdateStorageProfile()
        {
            DataDisks = new ChangeTrackingList<VirtualMachineScaleSetDataDisk>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetUpdateStorageProfile"/>. </summary>
        /// <param name="imageReference"> The image reference. </param>
        /// <param name="osDisk"> The OS disk. </param>
        /// <param name="dataDisks"> The data disks. </param>
        /// <param name="diskControllerType"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetUpdateStorageProfile(ImageReference imageReference, VirtualMachineScaleSetUpdateOSDisk osDisk, IList<VirtualMachineScaleSetDataDisk> dataDisks, string diskControllerType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ImageReference = imageReference;
            OSDisk = osDisk;
            DataDisks = dataDisks;
            DiskControllerType = diskControllerType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The image reference. </summary>
        public ImageReference ImageReference { get; set; }
        /// <summary> The OS disk. </summary>
        public VirtualMachineScaleSetUpdateOSDisk OSDisk { get; set; }
        /// <summary> The data disks. </summary>
        public IList<VirtualMachineScaleSetDataDisk> DataDisks { get; }
        /// <summary> Gets or sets the disk controller type. </summary>
        public string DiskControllerType { get; set; }
    }
}
