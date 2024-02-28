// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2ASwitchProtectionContent : IUtf8JsonSerializable, IJsonModel<A2ASwitchProtectionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<A2ASwitchProtectionContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<A2ASwitchProtectionContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2ASwitchProtectionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2ASwitchProtectionContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (RecoveryContainerId != null)
            {
                writer.WritePropertyName("recoveryContainerId"u8);
                writer.WriteStringValue(RecoveryContainerId);
            }
            if (!(VmDisks is ChangeTrackingList<A2AVmDiskDetails> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("vmDisks"u8);
                writer.WriteStartArray();
                foreach (var item in VmDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(VmManagedDisks is ChangeTrackingList<A2AVmManagedDiskDetails> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("vmManagedDisks"u8);
                writer.WriteStartArray();
                foreach (var item in VmManagedDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (RecoveryResourceGroupId != null)
            {
                writer.WritePropertyName("recoveryResourceGroupId"u8);
                writer.WriteStringValue(RecoveryResourceGroupId);
            }
            if (RecoveryCloudServiceId != null)
            {
                writer.WritePropertyName("recoveryCloudServiceId"u8);
                writer.WriteStringValue(RecoveryCloudServiceId);
            }
            if (RecoveryAvailabilitySetId != null)
            {
                writer.WritePropertyName("recoveryAvailabilitySetId"u8);
                writer.WriteStringValue(RecoveryAvailabilitySetId);
            }
            if (PolicyId != null)
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
            if (RecoveryBootDiagStorageAccountId != null)
            {
                writer.WritePropertyName("recoveryBootDiagStorageAccountId"u8);
                writer.WriteStringValue(RecoveryBootDiagStorageAccountId);
            }
            if (RecoveryAvailabilityZone != null)
            {
                writer.WritePropertyName("recoveryAvailabilityZone"u8);
                writer.WriteStringValue(RecoveryAvailabilityZone);
            }
            if (RecoveryProximityPlacementGroupId != null)
            {
                writer.WritePropertyName("recoveryProximityPlacementGroupId"u8);
                writer.WriteStringValue(RecoveryProximityPlacementGroupId);
            }
            if (RecoveryVirtualMachineScaleSetId != null)
            {
                writer.WritePropertyName("recoveryVirtualMachineScaleSetId"u8);
                writer.WriteStringValue(RecoveryVirtualMachineScaleSetId);
            }
            if (RecoveryCapacityReservationGroupId != null)
            {
                writer.WritePropertyName("recoveryCapacityReservationGroupId"u8);
                writer.WriteStringValue(RecoveryCapacityReservationGroupId);
            }
            if (DiskEncryptionInfo != null)
            {
                writer.WritePropertyName("diskEncryptionInfo"u8);
                writer.WriteObjectValue(DiskEncryptionInfo);
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

        A2ASwitchProtectionContent IJsonModel<A2ASwitchProtectionContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2ASwitchProtectionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2ASwitchProtectionContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeA2ASwitchProtectionContent(document.RootElement, options);
        }

        internal static A2ASwitchProtectionContent DeserializeA2ASwitchProtectionContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier recoveryContainerId = default;
            IList<A2AVmDiskDetails> vmDisks = default;
            IList<A2AVmManagedDiskDetails> vmManagedDisks = default;
            ResourceIdentifier recoveryResourceGroupId = default;
            string recoveryCloudServiceId = default;
            ResourceIdentifier recoveryAvailabilitySetId = default;
            ResourceIdentifier policyId = default;
            ResourceIdentifier recoveryBootDiagStorageAccountId = default;
            string recoveryAvailabilityZone = default;
            ResourceIdentifier recoveryProximityPlacementGroupId = default;
            ResourceIdentifier recoveryVirtualMachineScaleSetId = default;
            ResourceIdentifier recoveryCapacityReservationGroupId = default;
            SiteRecoveryDiskEncryptionInfo diskEncryptionInfo = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryContainerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryContainerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vmDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<A2AVmDiskDetails> array = new List<A2AVmDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(A2AVmDiskDetails.DeserializeA2AVmDiskDetails(item, options));
                    }
                    vmDisks = array;
                    continue;
                }
                if (property.NameEquals("vmManagedDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<A2AVmManagedDiskDetails> array = new List<A2AVmManagedDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(A2AVmManagedDiskDetails.DeserializeA2AVmManagedDiskDetails(item, options));
                    }
                    vmManagedDisks = array;
                    continue;
                }
                if (property.NameEquals("recoveryResourceGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryCloudServiceId"u8))
                {
                    recoveryCloudServiceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryAvailabilitySetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryAvailabilitySetId = new ResourceIdentifier(property.Value.GetString());
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
                if (property.NameEquals("recoveryBootDiagStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryBootDiagStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryAvailabilityZone"u8))
                {
                    recoveryAvailabilityZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryProximityPlacementGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryProximityPlacementGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryVirtualMachineScaleSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryVirtualMachineScaleSetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryCapacityReservationGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryCapacityReservationGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskEncryptionInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionInfo = SiteRecoveryDiskEncryptionInfo.DeserializeSiteRecoveryDiskEncryptionInfo(property.Value, options);
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
            return new A2ASwitchProtectionContent(
                instanceType,
                serializedAdditionalRawData,
                recoveryContainerId,
                vmDisks ?? new ChangeTrackingList<A2AVmDiskDetails>(),
                vmManagedDisks ?? new ChangeTrackingList<A2AVmManagedDiskDetails>(),
                recoveryResourceGroupId,
                recoveryCloudServiceId,
                recoveryAvailabilitySetId,
                policyId,
                recoveryBootDiagStorageAccountId,
                recoveryAvailabilityZone,
                recoveryProximityPlacementGroupId,
                recoveryVirtualMachineScaleSetId,
                recoveryCapacityReservationGroupId,
                diskEncryptionInfo);
        }

        BinaryData IPersistableModel<A2ASwitchProtectionContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2ASwitchProtectionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(A2ASwitchProtectionContent)} does not support '{options.Format}' format.");
            }
        }

        A2ASwitchProtectionContent IPersistableModel<A2ASwitchProtectionContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2ASwitchProtectionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeA2ASwitchProtectionContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(A2ASwitchProtectionContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<A2ASwitchProtectionContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
