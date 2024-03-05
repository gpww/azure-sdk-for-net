// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    internal partial class ManagedEnvironmentPropertiesPeerAuthentication : IUtf8JsonSerializable, IJsonModel<ManagedEnvironmentPropertiesPeerAuthentication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedEnvironmentPropertiesPeerAuthentication>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedEnvironmentPropertiesPeerAuthentication>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedEnvironmentPropertiesPeerAuthentication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedEnvironmentPropertiesPeerAuthentication)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Mtls))
            {
                writer.WritePropertyName("mtls"u8);
                writer.WriteObjectValue(Mtls);
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

        ManagedEnvironmentPropertiesPeerAuthentication IJsonModel<ManagedEnvironmentPropertiesPeerAuthentication>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedEnvironmentPropertiesPeerAuthentication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedEnvironmentPropertiesPeerAuthentication)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedEnvironmentPropertiesPeerAuthentication(document.RootElement, options);
        }

        internal static ManagedEnvironmentPropertiesPeerAuthentication DeserializeManagedEnvironmentPropertiesPeerAuthentication(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Mtls mtls = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mtls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mtls = Mtls.DeserializeMtls(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedEnvironmentPropertiesPeerAuthentication(mtls, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedEnvironmentPropertiesPeerAuthentication>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedEnvironmentPropertiesPeerAuthentication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedEnvironmentPropertiesPeerAuthentication)} does not support '{options.Format}' format.");
            }
        }

        ManagedEnvironmentPropertiesPeerAuthentication IPersistableModel<ManagedEnvironmentPropertiesPeerAuthentication>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedEnvironmentPropertiesPeerAuthentication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedEnvironmentPropertiesPeerAuthentication(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedEnvironmentPropertiesPeerAuthentication)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedEnvironmentPropertiesPeerAuthentication>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
