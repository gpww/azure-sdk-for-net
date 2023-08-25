// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class GatewayCustomBgpIPAddressIPConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("ipConfigurationId"u8);
            writer.WriteStringValue(IPConfigurationId);
            writer.WritePropertyName("customBgpIpAddress"u8);
            writer.WriteStringValue(CustomBgpIPAddress);
            writer.WriteEndObject();
        }

        internal static GatewayCustomBgpIPAddressIPConfiguration DeserializeGatewayCustomBgpIPAddressIPConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ipConfigurationId = default;
            string customBgpIPAddress = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipConfigurationId"u8))
                {
                    ipConfigurationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customBgpIpAddress"u8))
                {
                    customBgpIPAddress = property.Value.GetString();
                    continue;
                }
            }
            return new GatewayCustomBgpIPAddressIPConfiguration(ipConfigurationId, customBgpIPAddress);
        }
    }
}
