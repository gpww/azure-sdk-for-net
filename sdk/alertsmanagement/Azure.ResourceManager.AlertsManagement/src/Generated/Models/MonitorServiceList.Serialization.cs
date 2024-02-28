// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class MonitorServiceList : IUtf8JsonSerializable, IJsonModel<MonitorServiceList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorServiceList>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitorServiceList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorServiceList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorServiceList)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("data"u8);
            writer.WriteStartArray();
            foreach (var item in Data)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("metadataIdentifier"u8);
            writer.WriteStringValue(MetadataIdentifier.ToString());
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

        MonitorServiceList IJsonModel<MonitorServiceList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorServiceList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorServiceList)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorServiceList(document.RootElement, options);
        }

        internal static MonitorServiceList DeserializeMonitorServiceList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<MonitorServiceDetails> data = default;
            ServiceAlertMetadataIdentifier metadataIdentifier = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("data"u8))
                {
                    List<MonitorServiceDetails> array = new List<MonitorServiceDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorServiceDetails.DeserializeMonitorServiceDetails(item, options));
                    }
                    data = array;
                    continue;
                }
                if (property.NameEquals("metadataIdentifier"u8))
                {
                    metadataIdentifier = new ServiceAlertMetadataIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MonitorServiceList(metadataIdentifier, serializedAdditionalRawData, data);
        }

        BinaryData IPersistableModel<MonitorServiceList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorServiceList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitorServiceList)} does not support '{options.Format}' format.");
            }
        }

        MonitorServiceList IPersistableModel<MonitorServiceList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorServiceList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitorServiceList(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitorServiceList)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorServiceList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
