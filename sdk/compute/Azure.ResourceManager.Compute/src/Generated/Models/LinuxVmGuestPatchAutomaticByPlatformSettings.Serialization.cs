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
    public partial class LinuxVmGuestPatchAutomaticByPlatformSettings : IUtf8JsonSerializable, IJsonModel<LinuxVmGuestPatchAutomaticByPlatformSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LinuxVmGuestPatchAutomaticByPlatformSettings>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<LinuxVmGuestPatchAutomaticByPlatformSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RebootSetting))
            {
                writer.WritePropertyName("rebootSetting"u8);
                writer.WriteStringValue(RebootSetting.Value.ToString());
            }
            if (Optional.IsDefined(BypassPlatformSafetyChecksOnUserSchedule))
            {
                writer.WritePropertyName("bypassPlatformSafetyChecksOnUserSchedule"u8);
                writer.WriteBooleanValue(BypassPlatformSafetyChecksOnUserSchedule.Value);
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

        LinuxVmGuestPatchAutomaticByPlatformSettings IJsonModel<LinuxVmGuestPatchAutomaticByPlatformSettings>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLinuxVmGuestPatchAutomaticByPlatformSettings(document.RootElement, options);
        }

        internal static LinuxVmGuestPatchAutomaticByPlatformSettings DeserializeLinuxVmGuestPatchAutomaticByPlatformSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LinuxVmGuestPatchAutomaticByPlatformRebootSetting> rebootSetting = default;
            Optional<bool> bypassPlatformSafetyChecksOnUserSchedule = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rebootSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rebootSetting = new LinuxVmGuestPatchAutomaticByPlatformRebootSetting(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("bypassPlatformSafetyChecksOnUserSchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bypassPlatformSafetyChecksOnUserSchedule = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LinuxVmGuestPatchAutomaticByPlatformSettings(Optional.ToNullable(rebootSetting), Optional.ToNullable(bypassPlatformSafetyChecksOnUserSchedule), serializedAdditionalRawData);
        }

        BinaryData IModel<LinuxVmGuestPatchAutomaticByPlatformSettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        LinuxVmGuestPatchAutomaticByPlatformSettings IModel<LinuxVmGuestPatchAutomaticByPlatformSettings>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeLinuxVmGuestPatchAutomaticByPlatformSettings(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<LinuxVmGuestPatchAutomaticByPlatformSettings>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
