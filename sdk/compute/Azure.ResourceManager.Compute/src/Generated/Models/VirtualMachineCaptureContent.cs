// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Capture Virtual Machine parameters. </summary>
    public partial class VirtualMachineCaptureContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineCaptureContent"/>. </summary>
        /// <param name="vhdPrefix"> The captured virtual hard disk's name prefix. </param>
        /// <param name="destinationContainerName"> The destination container name. </param>
        /// <param name="overwriteVhds"> Specifies whether to overwrite the destination virtual hard disk, in case of conflict. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vhdPrefix"/> or <paramref name="destinationContainerName"/> is null. </exception>
        public VirtualMachineCaptureContent(string vhdPrefix, string destinationContainerName, bool overwriteVhds)
        {
            Argument.AssertNotNull(vhdPrefix, nameof(vhdPrefix));
            Argument.AssertNotNull(destinationContainerName, nameof(destinationContainerName));

            VhdPrefix = vhdPrefix;
            DestinationContainerName = destinationContainerName;
            OverwriteVhds = overwriteVhds;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineCaptureContent"/>. </summary>
        /// <param name="vhdPrefix"> The captured virtual hard disk's name prefix. </param>
        /// <param name="destinationContainerName"> The destination container name. </param>
        /// <param name="overwriteVhds"> Specifies whether to overwrite the destination virtual hard disk, in case of conflict. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineCaptureContent(string vhdPrefix, string destinationContainerName, bool overwriteVhds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VhdPrefix = vhdPrefix;
            DestinationContainerName = destinationContainerName;
            OverwriteVhds = overwriteVhds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineCaptureContent"/> for deserialization. </summary>
        internal VirtualMachineCaptureContent()
        {
        }

        /// <summary> The captured virtual hard disk's name prefix. </summary>
        public string VhdPrefix { get; }
        /// <summary> The destination container name. </summary>
        public string DestinationContainerName { get; }
        /// <summary> Specifies whether to overwrite the destination virtual hard disk, in case of conflict. </summary>
        public bool OverwriteVhds { get; }
    }
}
