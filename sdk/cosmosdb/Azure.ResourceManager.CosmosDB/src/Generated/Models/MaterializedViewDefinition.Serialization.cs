// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class MaterializedViewDefinition : IUtf8JsonSerializable, IJsonModel<MaterializedViewDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MaterializedViewDefinition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MaterializedViewDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaterializedViewDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaterializedViewDefinition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && SourceCollectionRid != null)
            {
                writer.WritePropertyName("sourceCollectionRid"u8);
                writer.WriteStringValue(SourceCollectionRid);
            }
            writer.WritePropertyName("sourceCollectionId"u8);
            writer.WriteStringValue(SourceCollectionId);
            writer.WritePropertyName("definition"u8);
            writer.WriteStringValue(Definition);
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

        MaterializedViewDefinition IJsonModel<MaterializedViewDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaterializedViewDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaterializedViewDefinition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMaterializedViewDefinition(document.RootElement, options);
        }

        internal static MaterializedViewDefinition DeserializeMaterializedViewDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourceCollectionRid = default;
            string sourceCollectionId = default;
            string definition = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceCollectionRid"u8))
                {
                    sourceCollectionRid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceCollectionId"u8))
                {
                    sourceCollectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("definition"u8))
                {
                    definition = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MaterializedViewDefinition(sourceCollectionRid, sourceCollectionId, definition, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MaterializedViewDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaterializedViewDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MaterializedViewDefinition)} does not support '{options.Format}' format.");
            }
        }

        MaterializedViewDefinition IPersistableModel<MaterializedViewDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaterializedViewDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMaterializedViewDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MaterializedViewDefinition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MaterializedViewDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
