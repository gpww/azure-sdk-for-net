// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightNameAvailabilityContent : IUtf8JsonSerializable, IJsonModel<HDInsightNameAvailabilityContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightNameAvailabilityContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HDInsightNameAvailabilityContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightNameAvailabilityContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightNameAvailabilityContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (ResourceType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
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

        HDInsightNameAvailabilityContent IJsonModel<HDInsightNameAvailabilityContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightNameAvailabilityContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightNameAvailabilityContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightNameAvailabilityContent(document.RootElement, options);
        }

        internal static HDInsightNameAvailabilityContent DeserializeHDInsightNameAvailabilityContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            ResourceType? type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HDInsightNameAvailabilityContent(name, type, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightNameAvailabilityContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightNameAvailabilityContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightNameAvailabilityContent)} does not support '{options.Format}' format.");
            }
        }

        HDInsightNameAvailabilityContent IPersistableModel<HDInsightNameAvailabilityContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightNameAvailabilityContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHDInsightNameAvailabilityContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightNameAvailabilityContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightNameAvailabilityContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
