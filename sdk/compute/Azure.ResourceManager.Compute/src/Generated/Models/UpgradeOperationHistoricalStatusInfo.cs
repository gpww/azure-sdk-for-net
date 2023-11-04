// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Virtual Machine Scale Set OS Upgrade History operation response. </summary>
    public partial class UpgradeOperationHistoricalStatusInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="UpgradeOperationHistoricalStatusInfo"/>. </summary>
        internal UpgradeOperationHistoricalStatusInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="UpgradeOperationHistoricalStatusInfo"/>. </summary>
        /// <param name="properties"> Information about the properties of the upgrade operation. </param>
        /// <param name="upgradeOperationHistoricalStatusInfoType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UpgradeOperationHistoricalStatusInfo(UpgradeOperationHistoricalStatusInfoProperties properties, string upgradeOperationHistoricalStatusInfoType, AzureLocation? location, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Properties = properties;
            UpgradeOperationHistoricalStatusInfoType = upgradeOperationHistoricalStatusInfoType;
            Location = location;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Information about the properties of the upgrade operation. </summary>
        public UpgradeOperationHistoricalStatusInfoProperties Properties { get; }
        /// <summary> Resource type. </summary>
        public string UpgradeOperationHistoricalStatusInfoType { get; }
        /// <summary> Resource location. </summary>
        public AzureLocation? Location { get; }
    }
}
