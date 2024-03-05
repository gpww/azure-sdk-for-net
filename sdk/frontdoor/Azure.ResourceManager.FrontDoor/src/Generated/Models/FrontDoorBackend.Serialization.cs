// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.FrontDoor;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class FrontDoorBackend : IUtf8JsonSerializable, IJsonModel<FrontDoorBackend>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FrontDoorBackend>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FrontDoorBackend>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorBackend>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorBackend)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Address))
            {
                writer.WritePropertyName("address"u8);
                writer.WriteStringValue(Address);
            }
            if (Optional.IsDefined(PrivateLinkAlias))
            {
                writer.WritePropertyName("privateLinkAlias"u8);
                writer.WriteStringValue(PrivateLinkAlias);
            }
            if (Optional.IsDefined(PrivateLinkResourceId))
            {
                if (PrivateLinkResourceId != null)
                {
                    writer.WritePropertyName("privateLinkResourceId"u8);
                    writer.WriteStringValue(PrivateLinkResourceId);
                }
                else
                {
                    writer.WriteNull("privateLinkResourceId");
                }
            }
            if (Optional.IsDefined(PrivateLinkLocation))
            {
                if (PrivateLinkLocation != null)
                {
                    writer.WritePropertyName("privateLinkLocation"u8);
                    writer.WriteStringValue(PrivateLinkLocation.Value);
                }
                else
                {
                    writer.WriteNull("privateLinkLocation");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(PrivateEndpointStatus))
            {
                if (PrivateEndpointStatus != null)
                {
                    writer.WritePropertyName("privateEndpointStatus"u8);
                    writer.WriteStringValue(PrivateEndpointStatus.Value.ToString());
                }
                else
                {
                    writer.WriteNull("privateEndpointStatus");
                }
            }
            if (Optional.IsDefined(PrivateLinkApprovalMessage))
            {
                writer.WritePropertyName("privateLinkApprovalMessage"u8);
                writer.WriteStringValue(PrivateLinkApprovalMessage);
            }
            if (Optional.IsDefined(HttpPort))
            {
                writer.WritePropertyName("httpPort"u8);
                writer.WriteNumberValue(HttpPort.Value);
            }
            if (Optional.IsDefined(HttpsPort))
            {
                writer.WritePropertyName("httpsPort"u8);
                writer.WriteNumberValue(HttpsPort.Value);
            }
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState"u8);
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(Weight))
            {
                writer.WritePropertyName("weight"u8);
                writer.WriteNumberValue(Weight.Value);
            }
            if (Optional.IsDefined(BackendHostHeader))
            {
                writer.WritePropertyName("backendHostHeader"u8);
                writer.WriteStringValue(BackendHostHeader);
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

        FrontDoorBackend IJsonModel<FrontDoorBackend>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorBackend>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorBackend)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFrontDoorBackend(document.RootElement, options);
        }

        internal static FrontDoorBackend DeserializeFrontDoorBackend(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string address = default;
            string privateLinkAlias = default;
            ResourceIdentifier privateLinkResourceId = default;
            AzureLocation? privateLinkLocation = default;
            BackendPrivateEndpointStatus? privateEndpointStatus = default;
            string privateLinkApprovalMessage = default;
            int? httpPort = default;
            int? httpsPort = default;
            BackendEnabledState? enabledState = default;
            int? priority = default;
            int? weight = default;
            string backendHostHeader = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("address"u8))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateLinkAlias"u8))
                {
                    privateLinkAlias = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateLinkResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        privateLinkResourceId = null;
                        continue;
                    }
                    privateLinkResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateLinkLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        privateLinkLocation = null;
                        continue;
                    }
                    privateLinkLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateEndpointStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        privateEndpointStatus = null;
                        continue;
                    }
                    privateEndpointStatus = new BackendPrivateEndpointStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateLinkApprovalMessage"u8))
                {
                    privateLinkApprovalMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("httpsPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpsPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enabledState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabledState = new BackendEnabledState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("weight"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    weight = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backendHostHeader"u8))
                {
                    backendHostHeader = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FrontDoorBackend(
                address,
                privateLinkAlias,
                privateLinkResourceId,
                privateLinkLocation,
                privateEndpointStatus,
                privateLinkApprovalMessage,
                httpPort,
                httpsPort,
                enabledState,
                priority,
                weight,
                backendHostHeader,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FrontDoorBackend>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorBackend>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FrontDoorBackend)} does not support '{options.Format}' format.");
            }
        }

        FrontDoorBackend IPersistableModel<FrontDoorBackend>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorBackend>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFrontDoorBackend(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FrontDoorBackend)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FrontDoorBackend>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
