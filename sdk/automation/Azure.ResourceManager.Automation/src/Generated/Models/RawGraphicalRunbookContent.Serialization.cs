// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Automation;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class RawGraphicalRunbookContent : IUtf8JsonSerializable, IJsonModel<RawGraphicalRunbookContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RawGraphicalRunbookContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RawGraphicalRunbookContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RawGraphicalRunbookContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RawGraphicalRunbookContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SchemaVersion))
            {
                writer.WritePropertyName("schemaVersion"u8);
                writer.WriteStringValue(SchemaVersion);
            }
            if (Optional.IsDefined(RunbookDefinition))
            {
                writer.WritePropertyName("runbookDefinition"u8);
                writer.WriteStringValue(RunbookDefinition);
            }
            if (Optional.IsDefined(RunbookType))
            {
                writer.WritePropertyName("runbookType"u8);
                writer.WriteStringValue(RunbookType.Value.ToString());
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

        RawGraphicalRunbookContent IJsonModel<RawGraphicalRunbookContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RawGraphicalRunbookContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RawGraphicalRunbookContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRawGraphicalRunbookContent(document.RootElement, options);
        }

        internal static RawGraphicalRunbookContent DeserializeRawGraphicalRunbookContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string schemaVersion = default;
            string runbookDefinition = default;
            GraphRunbookType? runbookType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("schemaVersion"u8))
                {
                    schemaVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runbookDefinition"u8))
                {
                    runbookDefinition = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runbookType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runbookType = new GraphRunbookType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RawGraphicalRunbookContent(schemaVersion, runbookDefinition, runbookType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RawGraphicalRunbookContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RawGraphicalRunbookContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RawGraphicalRunbookContent)} does not support '{options.Format}' format.");
            }
        }

        RawGraphicalRunbookContent IPersistableModel<RawGraphicalRunbookContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RawGraphicalRunbookContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRawGraphicalRunbookContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RawGraphicalRunbookContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RawGraphicalRunbookContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
