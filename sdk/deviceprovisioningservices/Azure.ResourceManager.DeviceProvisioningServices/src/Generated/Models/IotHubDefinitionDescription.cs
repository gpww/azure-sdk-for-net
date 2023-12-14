// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> Description of the IoT hub. </summary>
    public partial class IotHubDefinitionDescription
    {
        /// <summary> Initializes a new instance of <see cref="IotHubDefinitionDescription"/>. </summary>
        /// <param name="connectionString"> Connection string of the IoT hub. </param>
        /// <param name="location"> ARM region of the IoT hub. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionString"/> is null. </exception>
        public IotHubDefinitionDescription(string connectionString, AzureLocation location)
        {
            Argument.AssertNotNull(connectionString, nameof(connectionString));

            ConnectionString = connectionString;
            Location = location;
        }

        /// <summary> Initializes a new instance of <see cref="IotHubDefinitionDescription"/>. </summary>
        /// <param name="applyAllocationPolicy"> flag for applying allocationPolicy or not for a given iot hub. </param>
        /// <param name="allocationWeight"> weight to apply for a given iot h. </param>
        /// <param name="name"> Host name of the IoT hub. </param>
        /// <param name="connectionString"> Connection string of the IoT hub. </param>
        /// <param name="location"> ARM region of the IoT hub. </param>
        internal IotHubDefinitionDescription(bool? applyAllocationPolicy, int? allocationWeight, string name, string connectionString, AzureLocation location)
        {
            ApplyAllocationPolicy = applyAllocationPolicy;
            AllocationWeight = allocationWeight;
            Name = name;
            ConnectionString = connectionString;
            Location = location;
        }

        /// <summary> flag for applying allocationPolicy or not for a given iot hub. </summary>
        public bool? ApplyAllocationPolicy { get; set; }
        /// <summary> weight to apply for a given iot h. </summary>
        public int? AllocationWeight { get; set; }
        /// <summary> Host name of the IoT hub. </summary>
        public string Name { get; }
        /// <summary> Connection string of the IoT hub. </summary>
        public string ConnectionString { get; set; }
        /// <summary> ARM region of the IoT hub. </summary>
        public AzureLocation Location { get; set; }
    }
}
