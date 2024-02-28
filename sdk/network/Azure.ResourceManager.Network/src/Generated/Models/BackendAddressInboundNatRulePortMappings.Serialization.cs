// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class BackendAddressInboundNatRulePortMappings : IUtf8JsonSerializable, IJsonModel<BackendAddressInboundNatRulePortMappings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackendAddressInboundNatRulePortMappings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackendAddressInboundNatRulePortMappings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendAddressInboundNatRulePortMappings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackendAddressInboundNatRulePortMappings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(InboundNatRulePortMappings is ChangeTrackingList<InboundNatRulePortMapping> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("inboundNatRulePortMappings"u8);
                writer.WriteStartArray();
                foreach (var item in InboundNatRulePortMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        BackendAddressInboundNatRulePortMappings IJsonModel<BackendAddressInboundNatRulePortMappings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendAddressInboundNatRulePortMappings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackendAddressInboundNatRulePortMappings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackendAddressInboundNatRulePortMappings(document.RootElement, options);
        }

        internal static BackendAddressInboundNatRulePortMappings DeserializeBackendAddressInboundNatRulePortMappings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<InboundNatRulePortMapping> inboundNatRulePortMappings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inboundNatRulePortMappings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InboundNatRulePortMapping> array = new List<InboundNatRulePortMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InboundNatRulePortMapping.DeserializeInboundNatRulePortMapping(item, options));
                    }
                    inboundNatRulePortMappings = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackendAddressInboundNatRulePortMappings(inboundNatRulePortMappings ?? new ChangeTrackingList<InboundNatRulePortMapping>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackendAddressInboundNatRulePortMappings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendAddressInboundNatRulePortMappings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackendAddressInboundNatRulePortMappings)} does not support '{options.Format}' format.");
            }
        }

        BackendAddressInboundNatRulePortMappings IPersistableModel<BackendAddressInboundNatRulePortMappings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendAddressInboundNatRulePortMappings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackendAddressInboundNatRulePortMappings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackendAddressInboundNatRulePortMappings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackendAddressInboundNatRulePortMappings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
