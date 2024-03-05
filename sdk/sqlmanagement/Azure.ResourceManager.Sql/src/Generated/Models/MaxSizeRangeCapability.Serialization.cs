// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class MaxSizeRangeCapability : IUtf8JsonSerializable, IJsonModel<MaxSizeRangeCapability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MaxSizeRangeCapability>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MaxSizeRangeCapability>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaxSizeRangeCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaxSizeRangeCapability)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(MinValue))
            {
                writer.WritePropertyName("minValue"u8);
                writer.WriteObjectValue(MinValue);
            }
            if (options.Format != "W" && Optional.IsDefined(MaxValue))
            {
                writer.WritePropertyName("maxValue"u8);
                writer.WriteObjectValue(MaxValue);
            }
            if (options.Format != "W" && Optional.IsDefined(ScaleSize))
            {
                writer.WritePropertyName("scaleSize"u8);
                writer.WriteObjectValue(ScaleSize);
            }
            if (options.Format != "W" && Optional.IsDefined(LogSize))
            {
                writer.WritePropertyName("logSize"u8);
                writer.WriteObjectValue(LogSize);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
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

        MaxSizeRangeCapability IJsonModel<MaxSizeRangeCapability>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaxSizeRangeCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaxSizeRangeCapability)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMaxSizeRangeCapability(document.RootElement, options);
        }

        internal static MaxSizeRangeCapability DeserializeMaxSizeRangeCapability(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MaxSizeCapability minValue = default;
            MaxSizeCapability maxValue = default;
            MaxSizeCapability scaleSize = default;
            LogSizeCapability logSize = default;
            SqlCapabilityStatus? status = default;
            string reason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minValue = MaxSizeCapability.DeserializeMaxSizeCapability(property.Value, options);
                    continue;
                }
                if (property.NameEquals("maxValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxValue = MaxSizeCapability.DeserializeMaxSizeCapability(property.Value, options);
                    continue;
                }
                if (property.NameEquals("scaleSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scaleSize = MaxSizeCapability.DeserializeMaxSizeCapability(property.Value, options);
                    continue;
                }
                if (property.NameEquals("logSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logSize = LogSizeCapability.DeserializeLogSizeCapability(property.Value, options);
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToSqlCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MaxSizeRangeCapability(
                minValue,
                maxValue,
                scaleSize,
                logSize,
                status,
                reason,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MaxSizeRangeCapability>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaxSizeRangeCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MaxSizeRangeCapability)} does not support '{options.Format}' format.");
            }
        }

        MaxSizeRangeCapability IPersistableModel<MaxSizeRangeCapability>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaxSizeRangeCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMaxSizeRangeCapability(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MaxSizeRangeCapability)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MaxSizeRangeCapability>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
