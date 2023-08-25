// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(RunNotebookSnapshotResponseConverter))]
    public partial class RunNotebookSnapshotResponse
    {
        internal static RunNotebookSnapshotResponse DeserializeRunNotebookSnapshotResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> message = default;
            Optional<RunNotebookSnapshotResult> result = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("result"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result = RunNotebookSnapshotResult.DeserializeRunNotebookSnapshotResult(property.Value);
                    continue;
                }
            }
            return new RunNotebookSnapshotResponse(message.Value, result.Value);
        }

        internal partial class RunNotebookSnapshotResponseConverter : JsonConverter<RunNotebookSnapshotResponse>
        {
            public override void Write(Utf8JsonWriter writer, RunNotebookSnapshotResponse model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override RunNotebookSnapshotResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeRunNotebookSnapshotResponse(document.RootElement);
            }
        }
    }
}
