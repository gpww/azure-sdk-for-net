// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class ApplicationInsightsComponentDataVolumeCap : IUtf8JsonSerializable, IJsonModel<ApplicationInsightsComponentDataVolumeCap>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationInsightsComponentDataVolumeCap>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplicationInsightsComponentDataVolumeCap>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentDataVolumeCap>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentDataVolumeCap)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Cap.HasValue)
            {
                writer.WritePropertyName("Cap"u8);
                writer.WriteNumberValue(Cap.Value);
            }
            if (options.Format != "W" && ResetTime.HasValue)
            {
                writer.WritePropertyName("ResetTime"u8);
                writer.WriteNumberValue(ResetTime.Value);
            }
            if (WarningThreshold.HasValue)
            {
                writer.WritePropertyName("WarningThreshold"u8);
                writer.WriteNumberValue(WarningThreshold.Value);
            }
            if (IsStopSendNotificationWhenHitThreshold.HasValue)
            {
                writer.WritePropertyName("StopSendNotificationWhenHitThreshold"u8);
                writer.WriteBooleanValue(IsStopSendNotificationWhenHitThreshold.Value);
            }
            if (IsStopSendNotificationWhenHitCap.HasValue)
            {
                writer.WritePropertyName("StopSendNotificationWhenHitCap"u8);
                writer.WriteBooleanValue(IsStopSendNotificationWhenHitCap.Value);
            }
            if (options.Format != "W" && MaxHistoryCap.HasValue)
            {
                writer.WritePropertyName("MaxHistoryCap"u8);
                writer.WriteNumberValue(MaxHistoryCap.Value);
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

        ApplicationInsightsComponentDataVolumeCap IJsonModel<ApplicationInsightsComponentDataVolumeCap>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentDataVolumeCap>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentDataVolumeCap)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationInsightsComponentDataVolumeCap(document.RootElement, options);
        }

        internal static ApplicationInsightsComponentDataVolumeCap DeserializeApplicationInsightsComponentDataVolumeCap(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float? cap = default;
            int? resetTime = default;
            int? warningThreshold = default;
            bool? stopSendNotificationWhenHitThreshold = default;
            bool? stopSendNotificationWhenHitCap = default;
            float? maxHistoryCap = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Cap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cap = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("ResetTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resetTime = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("WarningThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    warningThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("StopSendNotificationWhenHitThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stopSendNotificationWhenHitThreshold = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("StopSendNotificationWhenHitCap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stopSendNotificationWhenHitCap = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("MaxHistoryCap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxHistoryCap = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationInsightsComponentDataVolumeCap(
                cap,
                resetTime,
                warningThreshold,
                stopSendNotificationWhenHitThreshold,
                stopSendNotificationWhenHitCap,
                maxHistoryCap,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationInsightsComponentDataVolumeCap>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentDataVolumeCap>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationInsightsComponentDataVolumeCap)} does not support '{options.Format}' format.");
            }
        }

        ApplicationInsightsComponentDataVolumeCap IPersistableModel<ApplicationInsightsComponentDataVolumeCap>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentDataVolumeCap>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationInsightsComponentDataVolumeCap(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationInsightsComponentDataVolumeCap)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationInsightsComponentDataVolumeCap>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
