// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.StorageSync;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class CloudTieringSpaceSavings : IUtf8JsonSerializable, IJsonModel<CloudTieringSpaceSavings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CloudTieringSpaceSavings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CloudTieringSpaceSavings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringSpaceSavings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudTieringSpaceSavings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdatedTimestamp"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(VolumeSizeInBytes))
            {
                writer.WritePropertyName("volumeSizeBytes"u8);
                writer.WriteNumberValue(VolumeSizeInBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CloudTotalSizeInBytes))
            {
                writer.WritePropertyName("totalSizeCloudBytes"u8);
                writer.WriteNumberValue(CloudTotalSizeInBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CachedSizeInBytes))
            {
                writer.WritePropertyName("cachedSizeBytes"u8);
                writer.WriteNumberValue(CachedSizeInBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SpaceSavingsPercent))
            {
                writer.WritePropertyName("spaceSavingsPercent"u8);
                writer.WriteNumberValue(SpaceSavingsPercent.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SpaceSavingsInBytes))
            {
                writer.WritePropertyName("spaceSavingsBytes"u8);
                writer.WriteNumberValue(SpaceSavingsInBytes.Value);
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

        CloudTieringSpaceSavings IJsonModel<CloudTieringSpaceSavings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringSpaceSavings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudTieringSpaceSavings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudTieringSpaceSavings(document.RootElement, options);
        }

        internal static CloudTieringSpaceSavings DeserializeCloudTieringSpaceSavings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? lastUpdatedTimestamp = default;
            long? volumeSizeBytes = default;
            long? totalSizeCloudBytes = default;
            long? cachedSizeBytes = default;
            int? spaceSavingsPercent = default;
            long? spaceSavingsBytes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastUpdatedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("volumeSizeBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    volumeSizeBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalSizeCloudBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalSizeCloudBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cachedSizeBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cachedSizeBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("spaceSavingsPercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    spaceSavingsPercent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("spaceSavingsBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    spaceSavingsBytes = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CloudTieringSpaceSavings(
                lastUpdatedTimestamp,
                volumeSizeBytes,
                totalSizeCloudBytes,
                cachedSizeBytes,
                spaceSavingsPercent,
                spaceSavingsBytes,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CloudTieringSpaceSavings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringSpaceSavings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CloudTieringSpaceSavings)} does not support '{options.Format}' format.");
            }
        }

        CloudTieringSpaceSavings IPersistableModel<CloudTieringSpaceSavings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudTieringSpaceSavings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCloudTieringSpaceSavings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CloudTieringSpaceSavings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CloudTieringSpaceSavings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
