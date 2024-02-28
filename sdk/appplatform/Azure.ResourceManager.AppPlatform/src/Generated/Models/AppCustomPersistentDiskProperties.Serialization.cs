// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    [PersistableModelProxy(typeof(UnknownCustomPersistentDiskProperties))]
    public partial class AppCustomPersistentDiskProperties : IUtf8JsonSerializable, IJsonModel<AppCustomPersistentDiskProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppCustomPersistentDiskProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppCustomPersistentDiskProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppCustomPersistentDiskProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppCustomPersistentDiskProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(UnderlyingResourceType.ToString());
            writer.WritePropertyName("mountPath"u8);
            writer.WriteStringValue(MountPath);
            if (IsReadOnly.HasValue)
            {
                writer.WritePropertyName("readOnly"u8);
                writer.WriteBooleanValue(IsReadOnly.Value);
            }
            if (!(MountOptions is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("mountOptions"u8);
                writer.WriteStartArray();
                foreach (var item in MountOptions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        AppCustomPersistentDiskProperties IJsonModel<AppCustomPersistentDiskProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppCustomPersistentDiskProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppCustomPersistentDiskProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppCustomPersistentDiskProperties(document.RootElement, options);
        }

        internal static AppCustomPersistentDiskProperties DeserializeAppCustomPersistentDiskProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureFileVolume": return AppPlatformAzureFileVolume.DeserializeAppPlatformAzureFileVolume(element, options);
                }
            }
            return UnknownCustomPersistentDiskProperties.DeserializeUnknownCustomPersistentDiskProperties(element, options);
        }

        BinaryData IPersistableModel<AppCustomPersistentDiskProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppCustomPersistentDiskProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppCustomPersistentDiskProperties)} does not support '{options.Format}' format.");
            }
        }

        AppCustomPersistentDiskProperties IPersistableModel<AppCustomPersistentDiskProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppCustomPersistentDiskProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppCustomPersistentDiskProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppCustomPersistentDiskProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppCustomPersistentDiskProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
