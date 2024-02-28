// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Redis;

namespace Azure.ResourceManager.Redis.Models
{
    internal partial class RedisCacheAccessPolicyList : IUtf8JsonSerializable, IJsonModel<RedisCacheAccessPolicyList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RedisCacheAccessPolicyList>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RedisCacheAccessPolicyList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisCacheAccessPolicyList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisCacheAccessPolicyList)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Value is ChangeTrackingList<RedisCacheAccessPolicyData> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && NextLink != null)
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        RedisCacheAccessPolicyList IJsonModel<RedisCacheAccessPolicyList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisCacheAccessPolicyList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisCacheAccessPolicyList)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRedisCacheAccessPolicyList(document.RootElement, options);
        }

        internal static RedisCacheAccessPolicyList DeserializeRedisCacheAccessPolicyList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<RedisCacheAccessPolicyData> value = default;
            string nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RedisCacheAccessPolicyData> array = new List<RedisCacheAccessPolicyData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RedisCacheAccessPolicyData.DeserializeRedisCacheAccessPolicyData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RedisCacheAccessPolicyList(value ?? new ChangeTrackingList<RedisCacheAccessPolicyData>(), nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RedisCacheAccessPolicyList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisCacheAccessPolicyList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RedisCacheAccessPolicyList)} does not support '{options.Format}' format.");
            }
        }

        RedisCacheAccessPolicyList IPersistableModel<RedisCacheAccessPolicyList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisCacheAccessPolicyList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRedisCacheAccessPolicyList(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RedisCacheAccessPolicyList)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RedisCacheAccessPolicyList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
