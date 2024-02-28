// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class LineRegistration : IUtf8JsonSerializable, IJsonModel<LineRegistration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LineRegistration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LineRegistration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LineRegistration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LineRegistration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && GeneratedId != null)
            {
                writer.WritePropertyName("generatedId"u8);
                writer.WriteStringValue(GeneratedId);
            }
            if (ChannelSecret != null)
            {
                writer.WritePropertyName("channelSecret"u8);
                writer.WriteStringValue(ChannelSecret);
            }
            if (ChannelAccessToken != null)
            {
                writer.WritePropertyName("channelAccessToken"u8);
                writer.WriteStringValue(ChannelAccessToken);
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

        LineRegistration IJsonModel<LineRegistration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LineRegistration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LineRegistration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLineRegistration(document.RootElement, options);
        }

        internal static LineRegistration DeserializeLineRegistration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string generatedId = default;
            string channelSecret = default;
            string channelAccessToken = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("generatedId"u8))
                {
                    generatedId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelSecret"u8))
                {
                    channelSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelAccessToken"u8))
                {
                    channelAccessToken = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LineRegistration(generatedId, channelSecret, channelAccessToken, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LineRegistration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LineRegistration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LineRegistration)} does not support '{options.Format}' format.");
            }
        }

        LineRegistration IPersistableModel<LineRegistration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LineRegistration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLineRegistration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LineRegistration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LineRegistration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
