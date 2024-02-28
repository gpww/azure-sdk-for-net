// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Quota.Models
{
    public partial class QuotaUsagesProperties : IUtf8JsonSerializable, IJsonModel<QuotaUsagesProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QuotaUsagesProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<QuotaUsagesProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaUsagesProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QuotaUsagesProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Usages != null)
            {
                writer.WritePropertyName("usages"u8);
                writer.WriteObjectValue(Usages);
            }
            if (options.Format != "W" && Unit != null)
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteObjectValue(Name);
            }
            if (ResourceTypeName != null)
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceTypeName);
            }
            if (options.Format != "W" && QuotaPeriod.HasValue)
            {
                writer.WritePropertyName("quotaPeriod"u8);
                writer.WriteStringValue(QuotaPeriod.Value, "P");
            }
            if (options.Format != "W" && IsQuotaApplicable.HasValue)
            {
                writer.WritePropertyName("isQuotaApplicable"u8);
                writer.WriteBooleanValue(IsQuotaApplicable.Value);
            }
            if (Properties != null)
            {
                writer.WritePropertyName("properties"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Properties);
#else
                using (JsonDocument document = JsonDocument.Parse(Properties))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        QuotaUsagesProperties IJsonModel<QuotaUsagesProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaUsagesProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QuotaUsagesProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQuotaUsagesProperties(document.RootElement, options);
        }

        internal static QuotaUsagesProperties DeserializeQuotaUsagesProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            QuotaUsagesObject usages = default;
            string unit = default;
            QuotaRequestResourceName name = default;
            string resourceType = default;
            TimeSpan? quotaPeriod = default;
            bool? isQuotaApplicable = default;
            BinaryData properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("usages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usages = QuotaUsagesObject.DeserializeQuotaUsagesObject(property.Value, options);
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = QuotaRequestResourceName.DeserializeQuotaRequestResourceName(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quotaPeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quotaPeriod = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("isQuotaApplicable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isQuotaApplicable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new QuotaUsagesProperties(
                usages,
                unit,
                name,
                resourceType,
                quotaPeriod,
                isQuotaApplicable,
                properties,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QuotaUsagesProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaUsagesProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(QuotaUsagesProperties)} does not support '{options.Format}' format.");
            }
        }

        QuotaUsagesProperties IPersistableModel<QuotaUsagesProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaUsagesProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeQuotaUsagesProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(QuotaUsagesProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<QuotaUsagesProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
