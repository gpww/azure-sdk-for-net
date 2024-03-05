// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnGatewayPacketCaptureStartContent : IUtf8JsonSerializable, IJsonModel<VpnGatewayPacketCaptureStartContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VpnGatewayPacketCaptureStartContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VpnGatewayPacketCaptureStartContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnGatewayPacketCaptureStartContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnGatewayPacketCaptureStartContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FilterData))
            {
                writer.WritePropertyName("filterData"u8);
                writer.WriteStringValue(FilterData);
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

        VpnGatewayPacketCaptureStartContent IJsonModel<VpnGatewayPacketCaptureStartContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnGatewayPacketCaptureStartContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnGatewayPacketCaptureStartContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnGatewayPacketCaptureStartContent(document.RootElement, options);
        }

        internal static VpnGatewayPacketCaptureStartContent DeserializeVpnGatewayPacketCaptureStartContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string filterData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filterData"u8))
                {
                    filterData = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VpnGatewayPacketCaptureStartContent(filterData, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VpnGatewayPacketCaptureStartContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnGatewayPacketCaptureStartContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VpnGatewayPacketCaptureStartContent)} does not support '{options.Format}' format.");
            }
        }

        VpnGatewayPacketCaptureStartContent IPersistableModel<VpnGatewayPacketCaptureStartContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnGatewayPacketCaptureStartContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVpnGatewayPacketCaptureStartContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VpnGatewayPacketCaptureStartContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VpnGatewayPacketCaptureStartContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
