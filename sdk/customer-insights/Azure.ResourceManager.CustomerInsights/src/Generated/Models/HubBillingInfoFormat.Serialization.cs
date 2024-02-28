// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class HubBillingInfoFormat : IUtf8JsonSerializable, IJsonModel<HubBillingInfoFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HubBillingInfoFormat>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HubBillingInfoFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HubBillingInfoFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HubBillingInfoFormat)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (SkuName != null)
            {
                writer.WritePropertyName("skuName"u8);
                writer.WriteStringValue(SkuName);
            }
            if (MinUnits.HasValue)
            {
                writer.WritePropertyName("minUnits"u8);
                writer.WriteNumberValue(MinUnits.Value);
            }
            if (MaxUnits.HasValue)
            {
                writer.WritePropertyName("maxUnits"u8);
                writer.WriteNumberValue(MaxUnits.Value);
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

        HubBillingInfoFormat IJsonModel<HubBillingInfoFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HubBillingInfoFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HubBillingInfoFormat)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHubBillingInfoFormat(document.RootElement, options);
        }

        internal static HubBillingInfoFormat DeserializeHubBillingInfoFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string skuName = default;
            int? minUnits = default;
            int? maxUnits = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("skuName"u8))
                {
                    skuName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minUnits"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minUnits = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxUnits"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxUnits = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HubBillingInfoFormat(skuName, minUnits, maxUnits, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HubBillingInfoFormat>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HubBillingInfoFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HubBillingInfoFormat)} does not support '{options.Format}' format.");
            }
        }

        HubBillingInfoFormat IPersistableModel<HubBillingInfoFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HubBillingInfoFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHubBillingInfoFormat(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HubBillingInfoFormat)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HubBillingInfoFormat>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
