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
    public partial class VirtualMachineSizeProperties : IUtf8JsonSerializable, IJsonModel<VirtualMachineSizeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineSizeProperties>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<VirtualMachineSizeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VCpusAvailable))
            {
                writer.WritePropertyName("vCPUsAvailable"u8);
                writer.WriteNumberValue(VCpusAvailable.Value);
            }
            if (Optional.IsDefined(VCpusPerCore))
            {
                writer.WritePropertyName("vCPUsPerCore"u8);
                writer.WriteNumberValue(VCpusPerCore.Value);
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

        VirtualMachineSizeProperties IJsonModel<VirtualMachineSizeProperties>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineSizeProperties(document.RootElement, options);
        }

        internal static VirtualMachineSizeProperties DeserializeVirtualMachineSizeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> vCpusAvailable = default;
            Optional<int> vCpusPerCore = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vCPUsAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vCpusAvailable = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("vCPUsPerCore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vCpusPerCore = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineSizeProperties(Optional.ToNullable(vCpusAvailable), Optional.ToNullable(vCpusPerCore), serializedAdditionalRawData);
        }

        BinaryData IModel<VirtualMachineSizeProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        VirtualMachineSizeProperties IModel<VirtualMachineSizeProperties>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeVirtualMachineSizeProperties(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<VirtualMachineSizeProperties>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
