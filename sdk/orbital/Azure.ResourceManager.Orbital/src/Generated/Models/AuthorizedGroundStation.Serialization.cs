// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Orbital.Models
{
    public partial class AuthorizedGroundStation : IUtf8JsonSerializable, IJsonModel<AuthorizedGroundStation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AuthorizedGroundStation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AuthorizedGroundStation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthorizedGroundStation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AuthorizedGroundStation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (GroundStationName != null)
            {
                writer.WritePropertyName("groundStation"u8);
                writer.WriteStringValue(GroundStationName);
            }
            if (ExpireOn.HasValue)
            {
                writer.WritePropertyName("expirationDate"u8);
                writer.WriteStringValue(ExpireOn.Value, "D");
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

        AuthorizedGroundStation IJsonModel<AuthorizedGroundStation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthorizedGroundStation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AuthorizedGroundStation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAuthorizedGroundStation(document.RootElement, options);
        }

        internal static AuthorizedGroundStation DeserializeAuthorizedGroundStation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string groundStation = default;
            DateTimeOffset? expirationDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groundStation"u8))
                {
                    groundStation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expirationDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AuthorizedGroundStation(groundStation, expirationDate, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AuthorizedGroundStation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthorizedGroundStation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AuthorizedGroundStation)} does not support '{options.Format}' format.");
            }
        }

        AuthorizedGroundStation IPersistableModel<AuthorizedGroundStation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthorizedGroundStation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAuthorizedGroundStation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AuthorizedGroundStation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AuthorizedGroundStation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
