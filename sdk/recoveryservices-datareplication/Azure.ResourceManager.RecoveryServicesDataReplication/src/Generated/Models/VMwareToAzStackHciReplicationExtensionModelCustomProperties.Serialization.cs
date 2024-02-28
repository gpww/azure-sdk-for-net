// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class VMwareToAzStackHciReplicationExtensionModelCustomProperties : IUtf8JsonSerializable, IJsonModel<VMwareToAzStackHciReplicationExtensionModelCustomProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareToAzStackHciReplicationExtensionModelCustomProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VMwareToAzStackHciReplicationExtensionModelCustomProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciReplicationExtensionModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareToAzStackHciReplicationExtensionModelCustomProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("vmwareFabricArmId"u8);
            writer.WriteStringValue(VmwareFabricArmId);
            if (options.Format != "W" && VmwareSiteId != null)
            {
                writer.WritePropertyName("vmwareSiteId"u8);
                writer.WriteStringValue(VmwareSiteId);
            }
            writer.WritePropertyName("azStackHciFabricArmId"u8);
            writer.WriteStringValue(AzStackHciFabricArmId);
            if (options.Format != "W" && AzStackHciSiteId != null)
            {
                writer.WritePropertyName("azStackHciSiteId"u8);
                writer.WriteStringValue(AzStackHciSiteId);
            }
            if (StorageAccountId != null)
            {
                writer.WritePropertyName("storageAccountId"u8);
                writer.WriteStringValue(StorageAccountId);
            }
            if (StorageAccountSasSecretName != null)
            {
                writer.WritePropertyName("storageAccountSasSecretName"u8);
                writer.WriteStringValue(StorageAccountSasSecretName);
            }
            if (options.Format != "W" && AsrServiceUri != null)
            {
                writer.WritePropertyName("asrServiceUri"u8);
                writer.WriteStringValue(AsrServiceUri.AbsoluteUri);
            }
            if (options.Format != "W" && RcmServiceUri != null)
            {
                writer.WritePropertyName("rcmServiceUri"u8);
                writer.WriteStringValue(RcmServiceUri.AbsoluteUri);
            }
            if (options.Format != "W" && GatewayServiceUri != null)
            {
                writer.WritePropertyName("gatewayServiceUri"u8);
                writer.WriteStringValue(GatewayServiceUri.AbsoluteUri);
            }
            if (options.Format != "W" && SourceGatewayServiceId != null)
            {
                writer.WritePropertyName("sourceGatewayServiceId"u8);
                writer.WriteStringValue(SourceGatewayServiceId);
            }
            if (options.Format != "W" && TargetGatewayServiceId != null)
            {
                writer.WritePropertyName("targetGatewayServiceId"u8);
                writer.WriteStringValue(TargetGatewayServiceId);
            }
            if (options.Format != "W" && SourceStorageContainerName != null)
            {
                writer.WritePropertyName("sourceStorageContainerName"u8);
                writer.WriteStringValue(SourceStorageContainerName);
            }
            if (options.Format != "W" && TargetStorageContainerName != null)
            {
                writer.WritePropertyName("targetStorageContainerName"u8);
                writer.WriteStringValue(TargetStorageContainerName);
            }
            if (options.Format != "W" && ResourceLocation != null)
            {
                writer.WritePropertyName("resourceLocation"u8);
                writer.WriteStringValue(ResourceLocation);
            }
            if (options.Format != "W" && SubscriptionId != null)
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (options.Format != "W" && ResourceGroup != null)
            {
                writer.WritePropertyName("resourceGroup"u8);
                writer.WriteStringValue(ResourceGroup);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        VMwareToAzStackHciReplicationExtensionModelCustomProperties IJsonModel<VMwareToAzStackHciReplicationExtensionModelCustomProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciReplicationExtensionModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareToAzStackHciReplicationExtensionModelCustomProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareToAzStackHciReplicationExtensionModelCustomProperties(document.RootElement, options);
        }

        internal static VMwareToAzStackHciReplicationExtensionModelCustomProperties DeserializeVMwareToAzStackHciReplicationExtensionModelCustomProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier vmwareFabricArmId = default;
            ResourceIdentifier vmwareSiteId = default;
            ResourceIdentifier azStackHciFabricArmId = default;
            ResourceIdentifier azStackHciSiteId = default;
            ResourceIdentifier storageAccountId = default;
            string storageAccountSasSecretName = default;
            Uri asrServiceUri = default;
            Uri rcmServiceUri = default;
            Uri gatewayServiceUri = default;
            string sourceGatewayServiceId = default;
            string targetGatewayServiceId = default;
            string sourceStorageContainerName = default;
            string targetStorageContainerName = default;
            string resourceLocation = default;
            string subscriptionId = default;
            string resourceGroup = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmwareFabricArmId"u8))
                {
                    vmwareFabricArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vmwareSiteId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmwareSiteId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("azStackHciFabricArmId"u8))
                {
                    azStackHciFabricArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("azStackHciSiteId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azStackHciSiteId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountSasSecretName"u8))
                {
                    storageAccountSasSecretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("asrServiceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    asrServiceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rcmServiceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rcmServiceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("gatewayServiceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gatewayServiceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceGatewayServiceId"u8))
                {
                    sourceGatewayServiceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetGatewayServiceId"u8))
                {
                    targetGatewayServiceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceStorageContainerName"u8))
                {
                    sourceStorageContainerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetStorageContainerName"u8))
                {
                    targetStorageContainerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceLocation"u8))
                {
                    resourceLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VMwareToAzStackHciReplicationExtensionModelCustomProperties(
                instanceType,
                serializedAdditionalRawData,
                vmwareFabricArmId,
                vmwareSiteId,
                azStackHciFabricArmId,
                azStackHciSiteId,
                storageAccountId,
                storageAccountSasSecretName,
                asrServiceUri,
                rcmServiceUri,
                gatewayServiceUri,
                sourceGatewayServiceId,
                targetGatewayServiceId,
                sourceStorageContainerName,
                targetStorageContainerName,
                resourceLocation,
                subscriptionId,
                resourceGroup);
        }

        BinaryData IPersistableModel<VMwareToAzStackHciReplicationExtensionModelCustomProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciReplicationExtensionModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VMwareToAzStackHciReplicationExtensionModelCustomProperties)} does not support '{options.Format}' format.");
            }
        }

        VMwareToAzStackHciReplicationExtensionModelCustomProperties IPersistableModel<VMwareToAzStackHciReplicationExtensionModelCustomProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareToAzStackHciReplicationExtensionModelCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVMwareToAzStackHciReplicationExtensionModelCustomProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VMwareToAzStackHciReplicationExtensionModelCustomProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareToAzStackHciReplicationExtensionModelCustomProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
