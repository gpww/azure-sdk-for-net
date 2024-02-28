// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterLogAnalyticsProfile : IUtf8JsonSerializable, IJsonModel<ClusterLogAnalyticsProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterLogAnalyticsProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClusterLogAnalyticsProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterLogAnalyticsProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterLogAnalyticsProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("enabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            if (ApplicationLogs != null)
            {
                writer.WritePropertyName("applicationLogs"u8);
                writer.WriteObjectValue(ApplicationLogs);
            }
            if (IsMetricsEnabled.HasValue)
            {
                writer.WritePropertyName("metricsEnabled"u8);
                writer.WriteBooleanValue(IsMetricsEnabled.Value);
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

        ClusterLogAnalyticsProfile IJsonModel<ClusterLogAnalyticsProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterLogAnalyticsProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterLogAnalyticsProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterLogAnalyticsProfile(document.RootElement, options);
        }

        internal static ClusterLogAnalyticsProfile DeserializeClusterLogAnalyticsProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool enabled = default;
            ClusterLogAnalyticsApplicationLogs applicationLogs = default;
            bool? metricsEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("applicationLogs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationLogs = ClusterLogAnalyticsApplicationLogs.DeserializeClusterLogAnalyticsApplicationLogs(property.Value, options);
                    continue;
                }
                if (property.NameEquals("metricsEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metricsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClusterLogAnalyticsProfile(enabled, applicationLogs, metricsEnabled, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClusterLogAnalyticsProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterLogAnalyticsProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClusterLogAnalyticsProfile)} does not support '{options.Format}' format.");
            }
        }

        ClusterLogAnalyticsProfile IPersistableModel<ClusterLogAnalyticsProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterLogAnalyticsProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterLogAnalyticsProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterLogAnalyticsProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterLogAnalyticsProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
