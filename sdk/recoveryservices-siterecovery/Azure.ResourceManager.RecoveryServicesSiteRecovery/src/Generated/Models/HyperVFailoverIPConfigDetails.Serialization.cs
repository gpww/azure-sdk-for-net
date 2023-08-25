// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class HyperVFailoverIPConfigDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IPConfigName))
            {
                writer.WritePropertyName("ipConfigName"u8);
                writer.WriteStringValue(IPConfigName);
            }
            if (Optional.IsDefined(IsPrimary))
            {
                writer.WritePropertyName("isPrimary"u8);
                writer.WriteBooleanValue(IsPrimary.Value);
            }
            if (Optional.IsDefined(IsSeletedForFailover))
            {
                writer.WritePropertyName("isSeletedForFailover"u8);
                writer.WriteBooleanValue(IsSeletedForFailover.Value);
            }
            if (Optional.IsDefined(RecoverySubnetName))
            {
                writer.WritePropertyName("recoverySubnetName"u8);
                writer.WriteStringValue(RecoverySubnetName);
            }
            if (Optional.IsDefined(RecoveryStaticIPAddress))
            {
                writer.WritePropertyName("recoveryStaticIPAddress"u8);
                writer.WriteStringValue(RecoveryStaticIPAddress.ToString());
            }
            if (Optional.IsDefined(RecoveryPublicIPAddressId))
            {
                writer.WritePropertyName("recoveryPublicIPAddressId"u8);
                writer.WriteStringValue(RecoveryPublicIPAddressId);
            }
            if (Optional.IsCollectionDefined(RecoveryLBBackendAddressPoolIds))
            {
                writer.WritePropertyName("recoveryLBBackendAddressPoolIds"u8);
                writer.WriteStartArray();
                foreach (var item in RecoveryLBBackendAddressPoolIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TfoSubnetName))
            {
                writer.WritePropertyName("tfoSubnetName"u8);
                writer.WriteStringValue(TfoSubnetName);
            }
            if (Optional.IsDefined(TfoStaticIPAddress))
            {
                writer.WritePropertyName("tfoStaticIPAddress"u8);
                writer.WriteStringValue(TfoStaticIPAddress.ToString());
            }
            if (Optional.IsDefined(TfoPublicIPAddressId))
            {
                writer.WritePropertyName("tfoPublicIPAddressId"u8);
                writer.WriteStringValue(TfoPublicIPAddressId);
            }
            if (Optional.IsCollectionDefined(TfoLBBackendAddressPoolIds))
            {
                writer.WritePropertyName("tfoLBBackendAddressPoolIds"u8);
                writer.WriteStartArray();
                foreach (var item in TfoLBBackendAddressPoolIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
