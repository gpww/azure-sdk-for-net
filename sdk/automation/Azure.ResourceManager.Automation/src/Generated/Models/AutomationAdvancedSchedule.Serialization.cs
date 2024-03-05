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
    public partial class AutomationAdvancedSchedule : IUtf8JsonSerializable, IJsonModel<AutomationAdvancedSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutomationAdvancedSchedule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutomationAdvancedSchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationAdvancedSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationAdvancedSchedule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(WeekDays))
            {
                writer.WritePropertyName("weekDays"u8);
                writer.WriteStartArray();
                foreach (var item in WeekDays)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MonthDays))
            {
                writer.WritePropertyName("monthDays"u8);
                writer.WriteStartArray();
                foreach (var item in MonthDays)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MonthlyOccurrences))
            {
                writer.WritePropertyName("monthlyOccurrences"u8);
                writer.WriteStartArray();
                foreach (var item in MonthlyOccurrences)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        AutomationAdvancedSchedule IJsonModel<AutomationAdvancedSchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationAdvancedSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationAdvancedSchedule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationAdvancedSchedule(document.RootElement, options);
        }

        internal static AutomationAdvancedSchedule DeserializeAutomationAdvancedSchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> weekDays = default;
            IList<int> monthDays = default;
            IList<AutomationAdvancedScheduleMonthlyOccurrence> monthlyOccurrences = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("weekDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    weekDays = array;
                    continue;
                }
                if (property.NameEquals("monthDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    monthDays = array;
                    continue;
                }
                if (property.NameEquals("monthlyOccurrences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AutomationAdvancedScheduleMonthlyOccurrence> array = new List<AutomationAdvancedScheduleMonthlyOccurrence>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AutomationAdvancedScheduleMonthlyOccurrence.DeserializeAutomationAdvancedScheduleMonthlyOccurrence(item, options));
                    }
                    monthlyOccurrences = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AutomationAdvancedSchedule(weekDays ?? new ChangeTrackingList<string>(), monthDays ?? new ChangeTrackingList<int>(), monthlyOccurrences ?? new ChangeTrackingList<AutomationAdvancedScheduleMonthlyOccurrence>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutomationAdvancedSchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationAdvancedSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutomationAdvancedSchedule)} does not support '{options.Format}' format.");
            }
        }

        AutomationAdvancedSchedule IPersistableModel<AutomationAdvancedSchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationAdvancedSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutomationAdvancedSchedule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutomationAdvancedSchedule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutomationAdvancedSchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
