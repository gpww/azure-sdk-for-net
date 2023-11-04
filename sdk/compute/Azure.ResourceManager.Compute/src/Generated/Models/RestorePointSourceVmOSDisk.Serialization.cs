// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RestorePointSourceVmOSDisk : IUtf8JsonSerializable, IJsonModel<RestorePointSourceVmOSDisk>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RestorePointSourceVmOSDisk>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<RestorePointSourceVmOSDisk>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(OSType))
                {
                    writer.WritePropertyName("osType"u8);
                    writer.WriteStringValue(OSType.Value.ToString());
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(EncryptionSettings))
                {
                    writer.WritePropertyName("encryptionSettings"u8);
                    writer.WriteObjectValue(EncryptionSettings);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Name))
                {
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(Name);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Caching))
                {
                    writer.WritePropertyName("caching"u8);
                    writer.WriteStringValue(Caching.Value.ToSerialString());
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(DiskSizeGB))
                {
                    writer.WritePropertyName("diskSizeGB"u8);
                    writer.WriteNumberValue(DiskSizeGB.Value);
                }
            }
            if (Optional.IsDefined(ManagedDisk))
            {
                writer.WritePropertyName("managedDisk"u8);
                writer.WriteObjectValue(ManagedDisk);
            }
            if (Optional.IsDefined(DiskRestorePoint))
            {
                writer.WritePropertyName("diskRestorePoint"u8);
                writer.WriteObjectValue(DiskRestorePoint);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(WriteAcceleratorEnabled))
                {
                    writer.WritePropertyName("writeAcceleratorEnabled"u8);
                    writer.WriteBooleanValue(WriteAcceleratorEnabled.Value);
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        RestorePointSourceVmOSDisk IJsonModel<RestorePointSourceVmOSDisk>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRestorePointSourceVmOSDisk(document.RootElement, options);
        }

        internal static RestorePointSourceVmOSDisk DeserializeRestorePointSourceVmOSDisk(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<OperatingSystemType> osType = default;
            Optional<DiskEncryptionSettings> encryptionSettings = default;
            Optional<string> name = default;
            Optional<CachingType> caching = default;
            Optional<int> diskSizeGB = default;
            Optional<VirtualMachineManagedDisk> managedDisk = default;
            Optional<DiskRestorePointAttributes> diskRestorePoint = default;
            Optional<bool> writeAcceleratorEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osType = new OperatingSystemType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("encryptionSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptionSettings = DiskEncryptionSettings.DeserializeDiskEncryptionSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("caching"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    caching = property.Value.GetString().ToCachingType();
                    continue;
                }
                if (property.NameEquals("diskSizeGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("managedDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedDisk = VirtualMachineManagedDisk.DeserializeVirtualMachineManagedDisk(property.Value);
                    continue;
                }
                if (property.NameEquals("diskRestorePoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskRestorePoint = DiskRestorePointAttributes.DeserializeDiskRestorePointAttributes(property.Value);
                    continue;
                }
                if (property.NameEquals("writeAcceleratorEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeAcceleratorEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RestorePointSourceVmOSDisk(Optional.ToNullable(osType), encryptionSettings.Value, name.Value, Optional.ToNullable(caching), Optional.ToNullable(diskSizeGB), managedDisk.Value, diskRestorePoint.Value, Optional.ToNullable(writeAcceleratorEnabled), serializedAdditionalRawData);
        }

        BinaryData IModel<RestorePointSourceVmOSDisk>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RestorePointSourceVmOSDisk IModel<RestorePointSourceVmOSDisk>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRestorePointSourceVmOSDisk(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<RestorePointSourceVmOSDisk>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
