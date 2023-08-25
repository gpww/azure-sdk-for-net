// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    internal partial class ApplicationInsightsComponentAnalyticsItemProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FunctionAlias))
            {
                writer.WritePropertyName("functionAlias"u8);
                writer.WriteStringValue(FunctionAlias);
            }
            writer.WriteEndObject();
        }

        internal static ApplicationInsightsComponentAnalyticsItemProperties DeserializeApplicationInsightsComponentAnalyticsItemProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> functionAlias = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("functionAlias"u8))
                {
                    functionAlias = property.Value.GetString();
                    continue;
                }
            }
            return new ApplicationInsightsComponentAnalyticsItemProperties(functionAlias.Value);
        }
    }
}
