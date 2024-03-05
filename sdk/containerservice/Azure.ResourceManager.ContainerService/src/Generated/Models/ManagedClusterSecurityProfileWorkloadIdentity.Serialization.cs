// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerService;

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class ManagedClusterSecurityProfileWorkloadIdentity : IUtf8JsonSerializable, IJsonModel<ManagedClusterSecurityProfileWorkloadIdentity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterSecurityProfileWorkloadIdentity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedClusterSecurityProfileWorkloadIdentity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfileWorkloadIdentity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterSecurityProfileWorkloadIdentity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsWorkloadIdentityEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsWorkloadIdentityEnabled.Value);
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

        ManagedClusterSecurityProfileWorkloadIdentity IJsonModel<ManagedClusterSecurityProfileWorkloadIdentity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfileWorkloadIdentity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterSecurityProfileWorkloadIdentity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterSecurityProfileWorkloadIdentity(document.RootElement, options);
        }

        internal static ManagedClusterSecurityProfileWorkloadIdentity DeserializeManagedClusterSecurityProfileWorkloadIdentity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedClusterSecurityProfileWorkloadIdentity(enabled, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterSecurityProfileWorkloadIdentity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfileWorkloadIdentity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterSecurityProfileWorkloadIdentity)} does not support '{options.Format}' format.");
            }
        }

        ManagedClusterSecurityProfileWorkloadIdentity IPersistableModel<ManagedClusterSecurityProfileWorkloadIdentity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterSecurityProfileWorkloadIdentity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterSecurityProfileWorkloadIdentity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterSecurityProfileWorkloadIdentity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterSecurityProfileWorkloadIdentity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
