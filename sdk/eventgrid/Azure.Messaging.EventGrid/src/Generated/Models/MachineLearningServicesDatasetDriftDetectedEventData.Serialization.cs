// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(MachineLearningServicesDatasetDriftDetectedEventDataConverter))]
    public partial class MachineLearningServicesDatasetDriftDetectedEventData
    {
        internal static MachineLearningServicesDatasetDriftDetectedEventData DeserializeMachineLearningServicesDatasetDriftDetectedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string dataDriftId = default;
            string dataDriftName = default;
            string runId = default;
            string baseDatasetId = default;
            string targetDatasetId = default;
            double? driftCoefficient = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataDriftId"u8))
                {
                    dataDriftId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataDriftName"u8))
                {
                    dataDriftName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runId"u8))
                {
                    runId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("baseDatasetId"u8))
                {
                    baseDatasetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDatasetId"u8))
                {
                    targetDatasetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("driftCoefficient"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    driftCoefficient = property.Value.GetDouble();
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
            }
            return new MachineLearningServicesDatasetDriftDetectedEventData(
                dataDriftId,
                dataDriftName,
                runId,
                baseDatasetId,
                targetDatasetId,
                driftCoefficient,
                startTime,
                endTime);
        }

        internal partial class MachineLearningServicesDatasetDriftDetectedEventDataConverter : JsonConverter<MachineLearningServicesDatasetDriftDetectedEventData>
        {
            public override void Write(Utf8JsonWriter writer, MachineLearningServicesDatasetDriftDetectedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override MachineLearningServicesDatasetDriftDetectedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMachineLearningServicesDatasetDriftDetectedEventData(document.RootElement);
            }
        }
    }
}
