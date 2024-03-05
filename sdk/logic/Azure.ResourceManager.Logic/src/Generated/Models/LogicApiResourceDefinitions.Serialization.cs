// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicApiResourceDefinitions : IUtf8JsonSerializable, IJsonModel<LogicApiResourceDefinitions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicApiResourceDefinitions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LogicApiResourceDefinitions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiResourceDefinitions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicApiResourceDefinitions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OriginalSwaggerUri))
            {
                writer.WritePropertyName("originalSwaggerUrl"u8);
                writer.WriteStringValue(OriginalSwaggerUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ModifiedSwaggerUri))
            {
                writer.WritePropertyName("modifiedSwaggerUrl"u8);
                writer.WriteStringValue(ModifiedSwaggerUri.AbsoluteUri);
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

        LogicApiResourceDefinitions IJsonModel<LogicApiResourceDefinitions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiResourceDefinitions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicApiResourceDefinitions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicApiResourceDefinitions(document.RootElement, options);
        }

        internal static LogicApiResourceDefinitions DeserializeLogicApiResourceDefinitions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri originalSwaggerUrl = default;
            Uri modifiedSwaggerUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("originalSwaggerUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    originalSwaggerUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("modifiedSwaggerUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modifiedSwaggerUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LogicApiResourceDefinitions(originalSwaggerUrl, modifiedSwaggerUrl, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LogicApiResourceDefinitions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiResourceDefinitions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LogicApiResourceDefinitions)} does not support '{options.Format}' format.");
            }
        }

        LogicApiResourceDefinitions IPersistableModel<LogicApiResourceDefinitions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiResourceDefinitions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogicApiResourceDefinitions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogicApiResourceDefinitions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogicApiResourceDefinitions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
