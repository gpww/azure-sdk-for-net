// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeNetworkAdapterPosition : IUtf8JsonSerializable, IJsonModel<DataBoxEdgeNetworkAdapterPosition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxEdgeNetworkAdapterPosition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxEdgeNetworkAdapterPosition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeNetworkAdapterPosition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeNetworkAdapterPosition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(NetworkGroup))
            {
                writer.WritePropertyName("networkGroup"u8);
                writer.WriteStringValue(NetworkGroup.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
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

        DataBoxEdgeNetworkAdapterPosition IJsonModel<DataBoxEdgeNetworkAdapterPosition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeNetworkAdapterPosition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeNetworkAdapterPosition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeNetworkAdapterPosition(document.RootElement, options);
        }

        internal static DataBoxEdgeNetworkAdapterPosition DeserializeDataBoxEdgeNetworkAdapterPosition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataBoxEdgeNetworkGroup? networkGroup = default;
            int? port = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkGroup = new DataBoxEdgeNetworkGroup(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    port = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxEdgeNetworkAdapterPosition(networkGroup, port, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxEdgeNetworkAdapterPosition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeNetworkAdapterPosition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeNetworkAdapterPosition)} does not support '{options.Format}' format.");
            }
        }

        DataBoxEdgeNetworkAdapterPosition IPersistableModel<DataBoxEdgeNetworkAdapterPosition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeNetworkAdapterPosition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxEdgeNetworkAdapterPosition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeNetworkAdapterPosition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxEdgeNetworkAdapterPosition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
