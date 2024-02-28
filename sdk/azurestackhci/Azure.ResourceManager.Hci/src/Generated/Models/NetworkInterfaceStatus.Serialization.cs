// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class NetworkInterfaceStatus : IUtf8JsonSerializable, IJsonModel<NetworkInterfaceStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkInterfaceStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkInterfaceStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkInterfaceStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ErrorCode != null)
            {
                writer.WritePropertyName("errorCode"u8);
                writer.WriteStringValue(ErrorCode);
            }
            if (ErrorMessage != null)
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (ProvisioningStatus != null)
            {
                writer.WritePropertyName("provisioningStatus"u8);
                writer.WriteObjectValue(ProvisioningStatus);
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

        NetworkInterfaceStatus IJsonModel<NetworkInterfaceStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkInterfaceStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkInterfaceStatus(document.RootElement, options);
        }

        internal static NetworkInterfaceStatus DeserializeNetworkInterfaceStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string errorCode = default;
            string errorMessage = default;
            NetworkInterfaceStatusProvisioningStatus provisioningStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errorCode"u8))
                {
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningStatus = NetworkInterfaceStatusProvisioningStatus.DeserializeNetworkInterfaceStatusProvisioningStatus(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkInterfaceStatus(errorCode, errorMessage, provisioningStatus, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkInterfaceStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkInterfaceStatus)} does not support '{options.Format}' format.");
            }
        }

        NetworkInterfaceStatus IPersistableModel<NetworkInterfaceStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkInterfaceStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkInterfaceStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkInterfaceStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
