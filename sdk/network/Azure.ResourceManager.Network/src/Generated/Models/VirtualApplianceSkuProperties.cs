// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Network Virtual Appliance Sku Properties. </summary>
    public partial class VirtualApplianceSkuProperties
    {
        /// <summary> Initializes a new instance of <see cref="VirtualApplianceSkuProperties"/>. </summary>
        public VirtualApplianceSkuProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualApplianceSkuProperties"/>. </summary>
        /// <param name="vendor"> Virtual Appliance Vendor. </param>
        /// <param name="bundledScaleUnit"> Virtual Appliance Scale Unit. </param>
        /// <param name="marketPlaceVersion"> Virtual Appliance Version. </param>
        internal VirtualApplianceSkuProperties(string vendor, string bundledScaleUnit, string marketPlaceVersion)
        {
            Vendor = vendor;
            BundledScaleUnit = bundledScaleUnit;
            MarketPlaceVersion = marketPlaceVersion;
        }

        /// <summary> Virtual Appliance Vendor. </summary>
        public string Vendor { get; set; }
        /// <summary> Virtual Appliance Scale Unit. </summary>
        public string BundledScaleUnit { get; set; }
        /// <summary> Virtual Appliance Version. </summary>
        public string MarketPlaceVersion { get; set; }
    }
}
