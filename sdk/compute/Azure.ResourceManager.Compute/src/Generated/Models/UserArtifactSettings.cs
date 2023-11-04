// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Additional settings for the VM app that contains the target package and config file name when it is deployed to target VM or VM scale set. </summary>
    public partial class UserArtifactSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="UserArtifactSettings"/>. </summary>
        public UserArtifactSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="UserArtifactSettings"/>. </summary>
        /// <param name="packageFileName"> Optional. The name to assign the downloaded package file on the VM. This is limited to 4096 characters. If not specified, the package file will be named the same as the Gallery Application name. </param>
        /// <param name="configFileName"> Optional. The name to assign the downloaded config file on the VM. This is limited to 4096 characters. If not specified, the config file will be named the Gallery Application name appended with "_config". </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UserArtifactSettings(string packageFileName, string configFileName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PackageFileName = packageFileName;
            ConfigFileName = configFileName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Optional. The name to assign the downloaded package file on the VM. This is limited to 4096 characters. If not specified, the package file will be named the same as the Gallery Application name. </summary>
        public string PackageFileName { get; set; }
        /// <summary> Optional. The name to assign the downloaded config file on the VM. This is limited to 4096 characters. If not specified, the config file will be named the Gallery Application name appended with "_config". </summary>
        public string ConfigFileName { get; set; }
    }
}
