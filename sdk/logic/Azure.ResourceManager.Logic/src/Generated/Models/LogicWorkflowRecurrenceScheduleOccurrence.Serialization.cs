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
    public partial class LogicWorkflowRecurrenceScheduleOccurrence : IUtf8JsonSerializable, IJsonModel<LogicWorkflowRecurrenceScheduleOccurrence>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicWorkflowRecurrenceScheduleOccurrence>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LogicWorkflowRecurrenceScheduleOccurrence>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowRecurrenceScheduleOccurrence>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicWorkflowRecurrenceScheduleOccurrence)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Day))
            {
                writer.WritePropertyName("day"u8);
                writer.WriteStringValue(Day.Value.ToSerialString());
            }
            if (Optional.IsDefined(Occurrence))
            {
                writer.WritePropertyName("occurrence"u8);
                writer.WriteNumberValue(Occurrence.Value);
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

        LogicWorkflowRecurrenceScheduleOccurrence IJsonModel<LogicWorkflowRecurrenceScheduleOccurrence>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowRecurrenceScheduleOccurrence>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicWorkflowRecurrenceScheduleOccurrence)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicWorkflowRecurrenceScheduleOccurrence(document.RootElement, options);
        }

        internal static LogicWorkflowRecurrenceScheduleOccurrence DeserializeLogicWorkflowRecurrenceScheduleOccurrence(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LogicWorkflowDayOfWeek? day = default;
            int? occurrence = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("day"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    day = property.Value.GetString().ToLogicWorkflowDayOfWeek();
                    continue;
                }
                if (property.NameEquals("occurrence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    occurrence = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LogicWorkflowRecurrenceScheduleOccurrence(day, occurrence, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LogicWorkflowRecurrenceScheduleOccurrence>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowRecurrenceScheduleOccurrence>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LogicWorkflowRecurrenceScheduleOccurrence)} does not support '{options.Format}' format.");
            }
        }

        LogicWorkflowRecurrenceScheduleOccurrence IPersistableModel<LogicWorkflowRecurrenceScheduleOccurrence>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowRecurrenceScheduleOccurrence>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogicWorkflowRecurrenceScheduleOccurrence(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogicWorkflowRecurrenceScheduleOccurrence)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogicWorkflowRecurrenceScheduleOccurrence>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
