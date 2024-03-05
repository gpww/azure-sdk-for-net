// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class LocalUserNotAllowed : IUtf8JsonSerializable, IJsonModel<LocalUserNotAllowed>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LocalUserNotAllowed>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LocalUserNotAllowed>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocalUserNotAllowed>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LocalUserNotAllowed)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("allowlistValues"u8);
            writer.WriteStartArray();
            foreach (var item in AllowlistValues)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (options.Format != "W" && Optional.IsDefined(ValueType))
            {
                writer.WritePropertyName("valueType"u8);
                writer.WriteStringValue(ValueType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            writer.WritePropertyName("ruleType"u8);
            writer.WriteStringValue(RuleType);
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

        LocalUserNotAllowed IJsonModel<LocalUserNotAllowed>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocalUserNotAllowed>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LocalUserNotAllowed)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLocalUserNotAllowed(document.RootElement, options);
        }

        internal static LocalUserNotAllowed DeserializeLocalUserNotAllowed(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> allowlistValues = default;
            SecurityValueType? valueType = default;
            string displayName = default;
            string description = default;
            bool isEnabled = default;
            string ruleType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowlistValues"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowlistValues = array;
                    continue;
                }
                if (property.NameEquals("valueType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueType = new SecurityValueType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ruleType"u8))
                {
                    ruleType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LocalUserNotAllowed(
                displayName,
                description,
                isEnabled,
                ruleType,
                serializedAdditionalRawData,
                valueType,
                allowlistValues);
        }

        BinaryData IPersistableModel<LocalUserNotAllowed>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocalUserNotAllowed>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LocalUserNotAllowed)} does not support '{options.Format}' format.");
            }
        }

        LocalUserNotAllowed IPersistableModel<LocalUserNotAllowed>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocalUserNotAllowed>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLocalUserNotAllowed(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LocalUserNotAllowed)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LocalUserNotAllowed>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
