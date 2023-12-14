// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Defines the virtual machine configuration. </summary>
    public partial class SapVirtualMachineConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="SapVirtualMachineConfiguration"/>. </summary>
        /// <param name="vmSize"> The virtual machine size. </param>
        /// <param name="imageReference"> The image reference. </param>
        /// <param name="osProfile"> The OS profile. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmSize"/>, <paramref name="imageReference"/> or <paramref name="osProfile"/> is null. </exception>
        public SapVirtualMachineConfiguration(string vmSize, SapImageReference imageReference, SapOSProfile osProfile)
        {
            Argument.AssertNotNull(vmSize, nameof(vmSize));
            Argument.AssertNotNull(imageReference, nameof(imageReference));
            Argument.AssertNotNull(osProfile, nameof(osProfile));

            VmSize = vmSize;
            ImageReference = imageReference;
            OSProfile = osProfile;
        }

        /// <summary> The virtual machine size. </summary>
        public string VmSize { get; set; }
        /// <summary> The image reference. </summary>
        public SapImageReference ImageReference { get; set; }
        /// <summary> The OS profile. </summary>
        public SapOSProfile OSProfile { get; set; }
    }
}
