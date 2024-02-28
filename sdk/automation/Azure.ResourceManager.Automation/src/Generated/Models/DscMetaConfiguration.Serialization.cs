// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class DscMetaConfiguration : IUtf8JsonSerializable, IJsonModel<DscMetaConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DscMetaConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DscMetaConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscMetaConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DscMetaConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ConfigurationModeFrequencyMins.HasValue)
            {
                writer.WritePropertyName("configurationModeFrequencyMins"u8);
                writer.WriteNumberValue(ConfigurationModeFrequencyMins.Value);
            }
            if (RebootNodeIfNeeded.HasValue)
            {
                writer.WritePropertyName("rebootNodeIfNeeded"u8);
                writer.WriteBooleanValue(RebootNodeIfNeeded.Value);
            }
            if (ConfigurationMode != null)
            {
                writer.WritePropertyName("configurationMode"u8);
                writer.WriteStringValue(ConfigurationMode);
            }
            if (ActionAfterReboot != null)
            {
                writer.WritePropertyName("actionAfterReboot"u8);
                writer.WriteStringValue(ActionAfterReboot);
            }
            if (CertificateId != null)
            {
                writer.WritePropertyName("certificateId"u8);
                writer.WriteStringValue(CertificateId);
            }
            if (RefreshFrequencyMins.HasValue)
            {
                writer.WritePropertyName("refreshFrequencyMins"u8);
                writer.WriteNumberValue(RefreshFrequencyMins.Value);
            }
            if (AllowModuleOverwrite.HasValue)
            {
                writer.WritePropertyName("allowModuleOverwrite"u8);
                writer.WriteBooleanValue(AllowModuleOverwrite.Value);
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

        DscMetaConfiguration IJsonModel<DscMetaConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscMetaConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DscMetaConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDscMetaConfiguration(document.RootElement, options);
        }

        internal static DscMetaConfiguration DeserializeDscMetaConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? configurationModeFrequencyMins = default;
            bool? rebootNodeIfNeeded = default;
            string configurationMode = default;
            string actionAfterReboot = default;
            string certificateId = default;
            int? refreshFrequencyMins = default;
            bool? allowModuleOverwrite = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("configurationModeFrequencyMins"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configurationModeFrequencyMins = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rebootNodeIfNeeded"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rebootNodeIfNeeded = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("configurationMode"u8))
                {
                    configurationMode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionAfterReboot"u8))
                {
                    actionAfterReboot = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificateId"u8))
                {
                    certificateId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("refreshFrequencyMins"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    refreshFrequencyMins = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allowModuleOverwrite"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowModuleOverwrite = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DscMetaConfiguration(
                configurationModeFrequencyMins,
                rebootNodeIfNeeded,
                configurationMode,
                actionAfterReboot,
                certificateId,
                refreshFrequencyMins,
                allowModuleOverwrite,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DscMetaConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscMetaConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DscMetaConfiguration)} does not support '{options.Format}' format.");
            }
        }

        DscMetaConfiguration IPersistableModel<DscMetaConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DscMetaConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDscMetaConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DscMetaConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DscMetaConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
