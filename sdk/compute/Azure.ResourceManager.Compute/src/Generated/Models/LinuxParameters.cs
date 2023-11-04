// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Input for InstallPatches on a Linux VM, as directly received by the API. </summary>
    public partial class LinuxParameters
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LinuxParameters"/>. </summary>
        public LinuxParameters()
        {
            ClassificationsToInclude = new ChangeTrackingList<VmGuestPatchClassificationForLinux>();
            PackageNameMasksToInclude = new ChangeTrackingList<string>();
            PackageNameMasksToExclude = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="LinuxParameters"/>. </summary>
        /// <param name="classificationsToInclude"> The update classifications to select when installing patches for Linux. </param>
        /// <param name="packageNameMasksToInclude"> packages to include in the patch operation. Format: packageName_packageVersion. </param>
        /// <param name="packageNameMasksToExclude"> packages to exclude in the patch operation. Format: packageName_packageVersion. </param>
        /// <param name="maintenanceRunId"> This is used as a maintenance run identifier for Auto VM Guest Patching in Linux. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LinuxParameters(IList<VmGuestPatchClassificationForLinux> classificationsToInclude, IList<string> packageNameMasksToInclude, IList<string> packageNameMasksToExclude, string maintenanceRunId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ClassificationsToInclude = classificationsToInclude;
            PackageNameMasksToInclude = packageNameMasksToInclude;
            PackageNameMasksToExclude = packageNameMasksToExclude;
            MaintenanceRunId = maintenanceRunId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The update classifications to select when installing patches for Linux. </summary>
        public IList<VmGuestPatchClassificationForLinux> ClassificationsToInclude { get; }
        /// <summary> packages to include in the patch operation. Format: packageName_packageVersion. </summary>
        public IList<string> PackageNameMasksToInclude { get; }
        /// <summary> packages to exclude in the patch operation. Format: packageName_packageVersion. </summary>
        public IList<string> PackageNameMasksToExclude { get; }
        /// <summary> This is used as a maintenance run identifier for Auto VM Guest Patching in Linux. </summary>
        public string MaintenanceRunId { get; set; }
    }
}
