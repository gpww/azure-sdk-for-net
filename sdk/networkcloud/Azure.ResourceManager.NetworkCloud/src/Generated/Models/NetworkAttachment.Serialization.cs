// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class NetworkAttachment : IUtf8JsonSerializable, IJsonModel<NetworkAttachment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkAttachment>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkAttachment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkAttachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkAttachment)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("attachedNetworkId"u8);
            writer.WriteStringValue(AttachedNetworkId);
            if (DefaultGateway.HasValue)
            {
                writer.WritePropertyName("defaultGateway"u8);
                writer.WriteStringValue(DefaultGateway.Value.ToString());
            }
            writer.WritePropertyName("ipAllocationMethod"u8);
            writer.WriteStringValue(IPAllocationMethod.ToString());
            if (IPv4Address != null)
            {
                writer.WritePropertyName("ipv4Address"u8);
                writer.WriteStringValue(IPv4Address);
            }
            if (IPv6Address != null)
            {
                writer.WritePropertyName("ipv6Address"u8);
                writer.WriteStringValue(IPv6Address);
            }
            if (options.Format != "W" && MacAddress != null)
            {
                writer.WritePropertyName("macAddress"u8);
                writer.WriteStringValue(MacAddress);
            }
            if (NetworkAttachmentName != null)
            {
                writer.WritePropertyName("networkAttachmentName"u8);
                writer.WriteStringValue(NetworkAttachmentName);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        NetworkAttachment IJsonModel<NetworkAttachment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkAttachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkAttachment)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkAttachment(document.RootElement, options);
        }

        internal static NetworkAttachment DeserializeNetworkAttachment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string attachedNetworkId = default;
            DefaultGateway? defaultGateway = default;
            VirtualMachineIPAllocationMethod ipAllocationMethod = default;
            string ipv4Address = default;
            string ipv6Address = default;
            string macAddress = default;
            string networkAttachmentName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("attachedNetworkId"u8))
                {
                    attachedNetworkId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultGateway"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultGateway = new DefaultGateway(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipAllocationMethod"u8))
                {
                    ipAllocationMethod = new VirtualMachineIPAllocationMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipv4Address"u8))
                {
                    ipv4Address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipv6Address"u8))
                {
                    ipv6Address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("macAddress"u8))
                {
                    macAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkAttachmentName"u8))
                {
                    networkAttachmentName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkAttachment(
                attachedNetworkId,
                defaultGateway,
                ipAllocationMethod,
                ipv4Address,
                ipv6Address,
                macAddress,
                networkAttachmentName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkAttachment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkAttachment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkAttachment)} does not support '{options.Format}' format.");
            }
        }

        NetworkAttachment IPersistableModel<NetworkAttachment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkAttachment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkAttachment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkAttachment)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkAttachment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
