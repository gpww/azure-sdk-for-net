// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class CspmMonitorAzureDevOpsOffering : IUtf8JsonSerializable, IJsonModel<CspmMonitorAzureDevOpsOffering>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CspmMonitorAzureDevOpsOffering>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CspmMonitorAzureDevOpsOffering>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CspmMonitorAzureDevOpsOffering>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CspmMonitorAzureDevOpsOffering)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("offeringType"u8);
            writer.WriteStringValue(OfferingType.ToString());
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        CspmMonitorAzureDevOpsOffering IJsonModel<CspmMonitorAzureDevOpsOffering>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CspmMonitorAzureDevOpsOffering>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CspmMonitorAzureDevOpsOffering)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCspmMonitorAzureDevOpsOffering(document.RootElement, options);
        }

        internal static CspmMonitorAzureDevOpsOffering DeserializeCspmMonitorAzureDevOpsOffering(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OfferingType offeringType = default;
            string description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offeringType"u8))
                {
                    offeringType = new OfferingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CspmMonitorAzureDevOpsOffering(offeringType, description, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CspmMonitorAzureDevOpsOffering>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CspmMonitorAzureDevOpsOffering>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CspmMonitorAzureDevOpsOffering)} does not support '{options.Format}' format.");
            }
        }

        CspmMonitorAzureDevOpsOffering IPersistableModel<CspmMonitorAzureDevOpsOffering>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CspmMonitorAzureDevOpsOffering>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCspmMonitorAzureDevOpsOffering(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CspmMonitorAzureDevOpsOffering)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CspmMonitorAzureDevOpsOffering>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
