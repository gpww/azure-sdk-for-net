// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LargeInstance.Models
{
    public partial class LargeInstanceNetworkProfile : IUtf8JsonSerializable, IJsonModel<LargeInstanceNetworkProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LargeInstanceNetworkProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LargeInstanceNetworkProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LargeInstanceNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LargeInstanceNetworkProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(NetworkInterfaces is ChangeTrackingList<LargeInstanceIPAddress> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("networkInterfaces"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkInterfaces)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && CircuitId != null)
            {
                writer.WritePropertyName("circuitId"u8);
                writer.WriteStringValue(CircuitId);
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

        LargeInstanceNetworkProfile IJsonModel<LargeInstanceNetworkProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LargeInstanceNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LargeInstanceNetworkProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLargeInstanceNetworkProfile(document.RootElement, options);
        }

        internal static LargeInstanceNetworkProfile DeserializeLargeInstanceNetworkProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<LargeInstanceIPAddress> networkInterfaces = default;
            string circuitId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkInterfaces"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LargeInstanceIPAddress> array = new List<LargeInstanceIPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LargeInstanceIPAddress.DeserializeLargeInstanceIPAddress(item, options));
                    }
                    networkInterfaces = array;
                    continue;
                }
                if (property.NameEquals("circuitId"u8))
                {
                    circuitId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LargeInstanceNetworkProfile(networkInterfaces ?? new ChangeTrackingList<LargeInstanceIPAddress>(), circuitId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LargeInstanceNetworkProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LargeInstanceNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LargeInstanceNetworkProfile)} does not support '{options.Format}' format.");
            }
        }

        LargeInstanceNetworkProfile IPersistableModel<LargeInstanceNetworkProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LargeInstanceNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLargeInstanceNetworkProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LargeInstanceNetworkProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LargeInstanceNetworkProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
