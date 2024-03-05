// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.GuestConfiguration;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    public partial class GuestConfigurationAssignmentReportDetails : IUtf8JsonSerializable, IJsonModel<GuestConfigurationAssignmentReportDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GuestConfigurationAssignmentReportDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GuestConfigurationAssignmentReportDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationAssignmentReportDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GuestConfigurationAssignmentReportDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ComplianceStatus))
            {
                writer.WritePropertyName("complianceStatus"u8);
                writer.WriteStringValue(ComplianceStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(JobId))
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(OperationType))
            {
                writer.WritePropertyName("operationType"u8);
                writer.WriteStringValue(OperationType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Resources))
            {
                writer.WritePropertyName("resources"u8);
                writer.WriteStartArray();
                foreach (var item in Resources)
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

        GuestConfigurationAssignmentReportDetails IJsonModel<GuestConfigurationAssignmentReportDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationAssignmentReportDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GuestConfigurationAssignmentReportDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGuestConfigurationAssignmentReportDetails(document.RootElement, options);
        }

        internal static GuestConfigurationAssignmentReportDetails DeserializeGuestConfigurationAssignmentReportDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AssignedGuestConfigurationMachineComplianceStatus? complianceStatus = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            Guid? jobId = default;
            GuestConfigurationAssignmentReportType? operationType = default;
            IReadOnlyList<AssignmentReportResourceInfo> resources = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("complianceStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    complianceStatus = new AssignedGuestConfigurationMachineComplianceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("operationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationType = new GuestConfigurationAssignmentReportType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AssignmentReportResourceInfo> array = new List<AssignmentReportResourceInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AssignmentReportResourceInfo.DeserializeAssignmentReportResourceInfo(item, options));
                    }
                    resources = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GuestConfigurationAssignmentReportDetails(
                complianceStatus,
                startTime,
                endTime,
                jobId,
                operationType,
                resources ?? new ChangeTrackingList<AssignmentReportResourceInfo>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GuestConfigurationAssignmentReportDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationAssignmentReportDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GuestConfigurationAssignmentReportDetails)} does not support '{options.Format}' format.");
            }
        }

        GuestConfigurationAssignmentReportDetails IPersistableModel<GuestConfigurationAssignmentReportDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationAssignmentReportDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGuestConfigurationAssignmentReportDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GuestConfigurationAssignmentReportDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GuestConfigurationAssignmentReportDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
