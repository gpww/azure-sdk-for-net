// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class VmWorkloadSapHanaSystemWorkloadItem : IUtf8JsonSerializable, IJsonModel<VmWorkloadSapHanaSystemWorkloadItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VmWorkloadSapHanaSystemWorkloadItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VmWorkloadSapHanaSystemWorkloadItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadSapHanaSystemWorkloadItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmWorkloadSapHanaSystemWorkloadItem)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ParentName != null)
            {
                writer.WritePropertyName("parentName"u8);
                writer.WriteStringValue(ParentName);
            }
            if (ServerName != null)
            {
                writer.WritePropertyName("serverName"u8);
                writer.WriteStringValue(ServerName);
            }
            if (IsAutoProtectable.HasValue)
            {
                writer.WritePropertyName("isAutoProtectable"u8);
                writer.WriteBooleanValue(IsAutoProtectable.Value);
            }
            if (SubInquiredItemCount.HasValue)
            {
                writer.WritePropertyName("subinquireditemcount"u8);
                writer.WriteNumberValue(SubInquiredItemCount.Value);
            }
            if (SubWorkloadItemCount.HasValue)
            {
                writer.WritePropertyName("subWorkloadItemCount"u8);
                writer.WriteNumberValue(SubWorkloadItemCount.Value);
            }
            if (BackupManagementType != null)
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType);
            }
            if (WorkloadType != null)
            {
                writer.WritePropertyName("workloadType"u8);
                writer.WriteStringValue(WorkloadType);
            }
            writer.WritePropertyName("workloadItemType"u8);
            writer.WriteStringValue(WorkloadItemType);
            if (FriendlyName != null)
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (ProtectionState.HasValue)
            {
                writer.WritePropertyName("protectionState"u8);
                writer.WriteStringValue(ProtectionState.Value.ToString());
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

        VmWorkloadSapHanaSystemWorkloadItem IJsonModel<VmWorkloadSapHanaSystemWorkloadItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadSapHanaSystemWorkloadItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmWorkloadSapHanaSystemWorkloadItem)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVmWorkloadSapHanaSystemWorkloadItem(document.RootElement, options);
        }

        internal static VmWorkloadSapHanaSystemWorkloadItem DeserializeVmWorkloadSapHanaSystemWorkloadItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string parentName = default;
            string serverName = default;
            bool? isAutoProtectable = default;
            int? subinquireditemcount = default;
            int? subWorkloadItemCount = default;
            string backupManagementType = default;
            string workloadType = default;
            string workloadItemType = default;
            string friendlyName = default;
            BackupProtectionStatus? protectionState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parentName"u8))
                {
                    parentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverName"u8))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAutoProtectable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAutoProtectable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("subinquireditemcount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subinquireditemcount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("subWorkloadItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subWorkloadItemCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    backupManagementType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadType"u8))
                {
                    workloadType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadItemType"u8))
                {
                    workloadItemType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionState = new BackupProtectionStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VmWorkloadSapHanaSystemWorkloadItem(
                backupManagementType,
                workloadType,
                workloadItemType,
                friendlyName,
                protectionState,
                serializedAdditionalRawData,
                parentName,
                serverName,
                isAutoProtectable,
                subinquireditemcount,
                subWorkloadItemCount);
        }

        BinaryData IPersistableModel<VmWorkloadSapHanaSystemWorkloadItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadSapHanaSystemWorkloadItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VmWorkloadSapHanaSystemWorkloadItem)} does not support '{options.Format}' format.");
            }
        }

        VmWorkloadSapHanaSystemWorkloadItem IPersistableModel<VmWorkloadSapHanaSystemWorkloadItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadSapHanaSystemWorkloadItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVmWorkloadSapHanaSystemWorkloadItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VmWorkloadSapHanaSystemWorkloadItem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VmWorkloadSapHanaSystemWorkloadItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
