// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureOperatorNexusNetworkFunctionTemplate : IUtf8JsonSerializable, IJsonModel<AzureOperatorNexusNetworkFunctionTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureOperatorNexusNetworkFunctionTemplate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureOperatorNexusNetworkFunctionTemplate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusNetworkFunctionTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureOperatorNexusNetworkFunctionTemplate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(NetworkFunctionApplications is ChangeTrackingList<AzureOperatorNexusNetworkFunctionApplication> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("networkFunctionApplications"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkFunctionApplications)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("nfviType"u8);
            writer.WriteStringValue(NfviType.ToString());
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

        AzureOperatorNexusNetworkFunctionTemplate IJsonModel<AzureOperatorNexusNetworkFunctionTemplate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusNetworkFunctionTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureOperatorNexusNetworkFunctionTemplate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureOperatorNexusNetworkFunctionTemplate(document.RootElement, options);
        }

        internal static AzureOperatorNexusNetworkFunctionTemplate DeserializeAzureOperatorNexusNetworkFunctionTemplate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<AzureOperatorNexusNetworkFunctionApplication> networkFunctionApplications = default;
            VirtualNetworkFunctionNfviType nfviType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkFunctionApplications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureOperatorNexusNetworkFunctionApplication> array = new List<AzureOperatorNexusNetworkFunctionApplication>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureOperatorNexusNetworkFunctionApplication.DeserializeAzureOperatorNexusNetworkFunctionApplication(item, options));
                    }
                    networkFunctionApplications = array;
                    continue;
                }
                if (property.NameEquals("nfviType"u8))
                {
                    nfviType = new VirtualNetworkFunctionNfviType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureOperatorNexusNetworkFunctionTemplate(nfviType, serializedAdditionalRawData, networkFunctionApplications ?? new ChangeTrackingList<AzureOperatorNexusNetworkFunctionApplication>());
        }

        BinaryData IPersistableModel<AzureOperatorNexusNetworkFunctionTemplate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusNetworkFunctionTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureOperatorNexusNetworkFunctionTemplate)} does not support '{options.Format}' format.");
            }
        }

        AzureOperatorNexusNetworkFunctionTemplate IPersistableModel<AzureOperatorNexusNetworkFunctionTemplate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusNetworkFunctionTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureOperatorNexusNetworkFunctionTemplate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureOperatorNexusNetworkFunctionTemplate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureOperatorNexusNetworkFunctionTemplate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
