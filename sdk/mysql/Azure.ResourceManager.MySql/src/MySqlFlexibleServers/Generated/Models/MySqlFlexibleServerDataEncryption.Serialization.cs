// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerDataEncryption : IUtf8JsonSerializable, IJsonModel<MySqlFlexibleServerDataEncryption>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlFlexibleServerDataEncryption>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MySqlFlexibleServerDataEncryption>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerDataEncryption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerDataEncryption)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryUserAssignedIdentityId))
            {
                writer.WritePropertyName("primaryUserAssignedIdentityId"u8);
                writer.WriteStringValue(PrimaryUserAssignedIdentityId);
            }
            if (Optional.IsDefined(PrimaryKeyUri))
            {
                writer.WritePropertyName("primaryKeyURI"u8);
                writer.WriteStringValue(PrimaryKeyUri.AbsoluteUri);
            }
            if (Optional.IsDefined(GeoBackupUserAssignedIdentityId))
            {
                writer.WritePropertyName("geoBackupUserAssignedIdentityId"u8);
                writer.WriteStringValue(GeoBackupUserAssignedIdentityId);
            }
            if (Optional.IsDefined(GeoBackupKeyUri))
            {
                writer.WritePropertyName("geoBackupKeyURI"u8);
                writer.WriteStringValue(GeoBackupKeyUri.AbsoluteUri);
            }
            if (Optional.IsDefined(EncryptionType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(EncryptionType.Value.ToSerialString());
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

        MySqlFlexibleServerDataEncryption IJsonModel<MySqlFlexibleServerDataEncryption>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerDataEncryption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerDataEncryption)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlFlexibleServerDataEncryption(document.RootElement, options);
        }

        internal static MySqlFlexibleServerDataEncryption DeserializeMySqlFlexibleServerDataEncryption(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier primaryUserAssignedIdentityId = default;
            Uri primaryKeyUri = default;
            ResourceIdentifier geoBackupUserAssignedIdentityId = default;
            Uri geoBackupKeyUri = default;
            MySqlFlexibleServerDataEncryptionType? type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryUserAssignedIdentityId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryUserAssignedIdentityId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryKeyURI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryKeyUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("geoBackupUserAssignedIdentityId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    geoBackupUserAssignedIdentityId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("geoBackupKeyURI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    geoBackupKeyUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString().ToMySqlFlexibleServerDataEncryptionType();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MySqlFlexibleServerDataEncryption(
                primaryUserAssignedIdentityId,
                primaryKeyUri,
                geoBackupUserAssignedIdentityId,
                geoBackupKeyUri,
                type,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MySqlFlexibleServerDataEncryption>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerDataEncryption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServerDataEncryption)} does not support '{options.Format}' format.");
            }
        }

        MySqlFlexibleServerDataEncryption IPersistableModel<MySqlFlexibleServerDataEncryption>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerDataEncryption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMySqlFlexibleServerDataEncryption(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServerDataEncryption)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MySqlFlexibleServerDataEncryption>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
