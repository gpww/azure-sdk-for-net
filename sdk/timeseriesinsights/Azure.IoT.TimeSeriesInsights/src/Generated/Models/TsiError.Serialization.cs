// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.IoT.TimeSeriesInsights
{
    internal partial class TsiError
    {
        internal static TsiError DeserializeTsiError(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TimeSeriesOperationError error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = TimeSeriesOperationError.DeserializeTimeSeriesOperationError(property.Value);
                    continue;
                }
            }
            return new TsiError(error);
        }
    }
}
