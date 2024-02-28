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
    public partial class GenericProtectedItem : IUtf8JsonSerializable, IJsonModel<GenericProtectedItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GenericProtectedItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GenericProtectedItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GenericProtectedItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GenericProtectedItem)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (FriendlyName != null)
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (PolicyState != null)
            {
                writer.WritePropertyName("policyState"u8);
                writer.WriteStringValue(PolicyState);
            }
            if (ProtectionState.HasValue)
            {
                writer.WritePropertyName("protectionState"u8);
                writer.WriteStringValue(ProtectionState.Value.ToString());
            }
            if (ProtectedItemId.HasValue)
            {
                writer.WritePropertyName("protectedItemId"u8);
                writer.WriteNumberValue(ProtectedItemId.Value);
            }
            if (!(SourceAssociations is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("sourceAssociations"u8);
                writer.WriteStartObject();
                foreach (var item in SourceAssociations)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (FabricName != null)
            {
                writer.WritePropertyName("fabricName"u8);
                writer.WriteStringValue(FabricName);
            }
            writer.WritePropertyName("protectedItemType"u8);
            writer.WriteStringValue(ProtectedItemType);
            if (options.Format != "W" && BackupManagementType.HasValue)
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            if (options.Format != "W" && WorkloadType.HasValue)
            {
                writer.WritePropertyName("workloadType"u8);
                writer.WriteStringValue(WorkloadType.Value.ToString());
            }
            if (ContainerName != null)
            {
                writer.WritePropertyName("containerName"u8);
                writer.WriteStringValue(ContainerName);
            }
            if (SourceResourceId != null)
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (PolicyId != null)
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
            if (LastRecoverOn.HasValue)
            {
                writer.WritePropertyName("lastRecoveryPoint"u8);
                writer.WriteStringValue(LastRecoverOn.Value, "O");
            }
            if (BackupSetName != null)
            {
                writer.WritePropertyName("backupSetName"u8);
                writer.WriteStringValue(BackupSetName);
            }
            if (CreateMode.HasValue)
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToString());
            }
            if (DeferredDeletedOn.HasValue)
            {
                writer.WritePropertyName("deferredDeleteTimeInUTC"u8);
                writer.WriteStringValue(DeferredDeletedOn.Value, "O");
            }
            if (IsScheduledForDeferredDelete.HasValue)
            {
                writer.WritePropertyName("isScheduledForDeferredDelete"u8);
                writer.WriteBooleanValue(IsScheduledForDeferredDelete.Value);
            }
            if (DeferredDeleteTimeRemaining != null)
            {
                writer.WritePropertyName("deferredDeleteTimeRemaining"u8);
                writer.WriteStringValue(DeferredDeleteTimeRemaining);
            }
            if (IsDeferredDeleteScheduleUpcoming.HasValue)
            {
                writer.WritePropertyName("isDeferredDeleteScheduleUpcoming"u8);
                writer.WriteBooleanValue(IsDeferredDeleteScheduleUpcoming.Value);
            }
            if (IsRehydrate.HasValue)
            {
                writer.WritePropertyName("isRehydrate"u8);
                writer.WriteBooleanValue(IsRehydrate.Value);
            }
            if (!(ResourceGuardOperationRequests is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("resourceGuardOperationRequests"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceGuardOperationRequests)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (IsArchiveEnabled.HasValue)
            {
                writer.WritePropertyName("isArchiveEnabled"u8);
                writer.WriteBooleanValue(IsArchiveEnabled.Value);
            }
            if (PolicyName != null)
            {
                writer.WritePropertyName("policyName"u8);
                writer.WriteStringValue(PolicyName);
            }
            if (SoftDeleteRetentionPeriodInDays.HasValue)
            {
                writer.WritePropertyName("softDeleteRetentionPeriodInDays"u8);
                writer.WriteNumberValue(SoftDeleteRetentionPeriodInDays.Value);
            }
            if (options.Format != "W" && VaultId != null)
            {
                writer.WritePropertyName("vaultId"u8);
                writer.WriteStringValue(VaultId);
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

        GenericProtectedItem IJsonModel<GenericProtectedItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GenericProtectedItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GenericProtectedItem)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGenericProtectedItem(document.RootElement, options);
        }

        internal static GenericProtectedItem DeserializeGenericProtectedItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string friendlyName = default;
            string policyState = default;
            BackupProtectionState? protectionState = default;
            long? protectedItemId = default;
            IDictionary<string, string> sourceAssociations = default;
            string fabricName = default;
            string protectedItemType = default;
            BackupManagementType? backupManagementType = default;
            BackupDataSourceType? workloadType = default;
            string containerName = default;
            ResourceIdentifier sourceResourceId = default;
            ResourceIdentifier policyId = default;
            DateTimeOffset? lastRecoveryPoint = default;
            string backupSetName = default;
            BackupCreateMode? createMode = default;
            DateTimeOffset? deferredDeleteTimeInUTC = default;
            bool? isScheduledForDeferredDelete = default;
            string deferredDeleteTimeRemaining = default;
            bool? isDeferredDeleteScheduleUpcoming = default;
            bool? isRehydrate = default;
            IList<string> resourceGuardOperationRequests = default;
            bool? isArchiveEnabled = default;
            string policyName = default;
            int? softDeleteRetentionPeriodInDays = default;
            string vaultId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyState"u8))
                {
                    policyState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionState = new BackupProtectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectedItemId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedItemId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("sourceAssociations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    sourceAssociations = dictionary;
                    continue;
                }
                if (property.NameEquals("fabricName"u8))
                {
                    fabricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemType"u8))
                {
                    protectedItemType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupManagementType = new BackupManagementType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("workloadType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workloadType = new BackupDataSourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastRecoveryPoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRecoveryPoint = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("backupSetName"u8))
                {
                    backupSetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createMode = new BackupCreateMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deferredDeleteTimeInUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deferredDeleteTimeInUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isScheduledForDeferredDelete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isScheduledForDeferredDelete = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("deferredDeleteTimeRemaining"u8))
                {
                    deferredDeleteTimeRemaining = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isDeferredDeleteScheduleUpcoming"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDeferredDeleteScheduleUpcoming = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isRehydrate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isRehydrate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("resourceGuardOperationRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    resourceGuardOperationRequests = array;
                    continue;
                }
                if (property.NameEquals("isArchiveEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isArchiveEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("policyName"u8))
                {
                    policyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("softDeleteRetentionPeriodInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    softDeleteRetentionPeriodInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("vaultId"u8))
                {
                    vaultId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GenericProtectedItem(
                protectedItemType,
                backupManagementType,
                workloadType,
                containerName,
                sourceResourceId,
                policyId,
                lastRecoveryPoint,
                backupSetName,
                createMode,
                deferredDeleteTimeInUTC,
                isScheduledForDeferredDelete,
                deferredDeleteTimeRemaining,
                isDeferredDeleteScheduleUpcoming,
                isRehydrate,
                resourceGuardOperationRequests ?? new ChangeTrackingList<string>(),
                isArchiveEnabled,
                policyName,
                softDeleteRetentionPeriodInDays,
                vaultId,
                serializedAdditionalRawData,
                friendlyName,
                policyState,
                protectionState,
                protectedItemId,
                sourceAssociations ?? new ChangeTrackingDictionary<string, string>(),
                fabricName);
        }

        BinaryData IPersistableModel<GenericProtectedItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GenericProtectedItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GenericProtectedItem)} does not support '{options.Format}' format.");
            }
        }

        GenericProtectedItem IPersistableModel<GenericProtectedItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GenericProtectedItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGenericProtectedItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GenericProtectedItem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GenericProtectedItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
