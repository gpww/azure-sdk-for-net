// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkPlatformConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(PlatformType.ToString());
            if (Optional.IsDefined(AzureStackEdgeDevice))
            {
                writer.WritePropertyName("azureStackEdgeDevice"u8);
                JsonSerializer.Serialize(writer, AzureStackEdgeDevice);
            }
            if (Optional.IsDefined(AzureStackHciCluster))
            {
                writer.WritePropertyName("azureStackHciCluster"u8);
                JsonSerializer.Serialize(writer, AzureStackHciCluster);
            }
            if (Optional.IsDefined(ConnectedCluster))
            {
                writer.WritePropertyName("connectedCluster"u8);
                JsonSerializer.Serialize(writer, ConnectedCluster);
            }
            if (Optional.IsDefined(CustomLocation))
            {
                writer.WritePropertyName("customLocation"u8);
                JsonSerializer.Serialize(writer, CustomLocation);
            }
            writer.WriteEndObject();
        }

        internal static MobileNetworkPlatformConfiguration DeserializeMobileNetworkPlatformConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MobileNetworkPlatformType type = default;
            Optional<WritableSubResource> azureStackEdgeDevice = default;
            Optional<IReadOnlyList<WritableSubResource>> azureStackEdgeDevices = default;
            Optional<WritableSubResource> azureStackHciCluster = default;
            Optional<WritableSubResource> connectedCluster = default;
            Optional<WritableSubResource> customLocation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new MobileNetworkPlatformType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("azureStackEdgeDevice"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureStackEdgeDevice = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("azureStackEdgeDevices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    azureStackEdgeDevices = array;
                    continue;
                }
                if (property.NameEquals("azureStackHciCluster"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureStackHciCluster = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("connectedCluster"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectedCluster = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("customLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customLocation = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
            }
            return new MobileNetworkPlatformConfiguration(type, azureStackEdgeDevice, Optional.ToList(azureStackEdgeDevices), azureStackHciCluster, connectedCluster, customLocation);
        }
    }
}
