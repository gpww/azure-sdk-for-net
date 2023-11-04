// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The properties describe the recommended machine configuration for this Image Definition. These properties are updatable. </summary>
    public partial class RecommendedMachineConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RecommendedMachineConfiguration"/>. </summary>
        public RecommendedMachineConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RecommendedMachineConfiguration"/>. </summary>
        /// <param name="vCpus"> Describes the resource range. </param>
        /// <param name="memory"> Describes the resource range. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RecommendedMachineConfiguration(ResourceRange vCpus, ResourceRange memory, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VCpus = vCpus;
            Memory = memory;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Describes the resource range. </summary>
        public ResourceRange VCpus { get; set; }
        /// <summary> Describes the resource range. </summary>
        public ResourceRange Memory { get; set; }
    }
}
