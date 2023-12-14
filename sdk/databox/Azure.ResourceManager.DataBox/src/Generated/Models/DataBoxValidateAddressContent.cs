// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The requirements to validate customer address where the device needs to be shipped. </summary>
    public partial class DataBoxValidateAddressContent : DataBoxValidationInputContent
    {
        /// <summary> Initializes a new instance of <see cref="DataBoxValidateAddressContent"/>. </summary>
        /// <param name="shippingAddress"> Shipping address of the customer. </param>
        /// <param name="deviceType"> Device type to be used for the job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="shippingAddress"/> is null. </exception>
        public DataBoxValidateAddressContent(DataBoxShippingAddress shippingAddress, DataBoxSkuName deviceType)
        {
            Argument.AssertNotNull(shippingAddress, nameof(shippingAddress));

            ShippingAddress = shippingAddress;
            DeviceType = deviceType;
            ValidationType = DataBoxValidationInputDiscriminator.ValidateAddress;
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxValidateAddressContent"/>. </summary>
        /// <param name="validationType"> Identifies the type of validation request. </param>
        /// <param name="shippingAddress"> Shipping address of the customer. </param>
        /// <param name="deviceType"> Device type to be used for the job. </param>
        /// <param name="transportPreferences"> Preferences related to the shipment logistics of the sku. </param>
        internal DataBoxValidateAddressContent(DataBoxValidationInputDiscriminator validationType, DataBoxShippingAddress shippingAddress, DataBoxSkuName deviceType, TransportPreferences transportPreferences) : base(validationType)
        {
            ShippingAddress = shippingAddress;
            DeviceType = deviceType;
            TransportPreferences = transportPreferences;
            ValidationType = validationType;
        }

        /// <summary> Shipping address of the customer. </summary>
        public DataBoxShippingAddress ShippingAddress { get; }
        /// <summary> Device type to be used for the job. </summary>
        public DataBoxSkuName DeviceType { get; }
        /// <summary> Preferences related to the shipment logistics of the sku. </summary>
        public TransportPreferences TransportPreferences { get; set; }
    }
}
