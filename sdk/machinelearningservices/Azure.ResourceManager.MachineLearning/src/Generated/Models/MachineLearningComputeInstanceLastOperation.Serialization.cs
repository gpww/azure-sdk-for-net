// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningComputeInstanceLastOperation : IUtf8JsonSerializable, IJsonModel<MachineLearningComputeInstanceLastOperation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningComputeInstanceLastOperation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningComputeInstanceLastOperation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeInstanceLastOperation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningComputeInstanceLastOperation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (OperationName.HasValue)
            {
                writer.WritePropertyName("operationName"u8);
                writer.WriteStringValue(OperationName.Value.ToString());
            }
            if (OperationOn.HasValue)
            {
                writer.WritePropertyName("operationTime"u8);
                writer.WriteStringValue(OperationOn.Value, "O");
            }
            if (OperationStatus.HasValue)
            {
                writer.WritePropertyName("operationStatus"u8);
                writer.WriteStringValue(OperationStatus.Value.ToString());
            }
            if (OperationTrigger.HasValue)
            {
                writer.WritePropertyName("operationTrigger"u8);
                writer.WriteStringValue(OperationTrigger.Value.ToString());
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

        MachineLearningComputeInstanceLastOperation IJsonModel<MachineLearningComputeInstanceLastOperation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeInstanceLastOperation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningComputeInstanceLastOperation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningComputeInstanceLastOperation(document.RootElement, options);
        }

        internal static MachineLearningComputeInstanceLastOperation DeserializeMachineLearningComputeInstanceLastOperation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineLearningOperationName? operationName = default;
            DateTimeOffset? operationTime = default;
            MachineLearningOperationStatus? operationStatus = default;
            MachineLearningOperationTrigger? operationTrigger = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationName = new MachineLearningOperationName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("operationStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationStatus = new MachineLearningOperationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operationTrigger"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationTrigger = new MachineLearningOperationTrigger(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningComputeInstanceLastOperation(operationName, operationTime, operationStatus, operationTrigger, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningComputeInstanceLastOperation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeInstanceLastOperation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningComputeInstanceLastOperation)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningComputeInstanceLastOperation IPersistableModel<MachineLearningComputeInstanceLastOperation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeInstanceLastOperation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningComputeInstanceLastOperation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningComputeInstanceLastOperation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningComputeInstanceLastOperation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
