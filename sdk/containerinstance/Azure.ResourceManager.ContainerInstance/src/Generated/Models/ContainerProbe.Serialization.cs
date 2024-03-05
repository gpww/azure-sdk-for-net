// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerInstance;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerProbe : IUtf8JsonSerializable, IJsonModel<ContainerProbe>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerProbe>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerProbe>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerProbe>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerProbe)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Exec))
            {
                writer.WritePropertyName("exec"u8);
                writer.WriteObjectValue(Exec);
            }
            if (Optional.IsDefined(HttpGet))
            {
                writer.WritePropertyName("httpGet"u8);
                writer.WriteObjectValue(HttpGet);
            }
            if (Optional.IsDefined(InitialDelayInSeconds))
            {
                writer.WritePropertyName("initialDelaySeconds"u8);
                writer.WriteNumberValue(InitialDelayInSeconds.Value);
            }
            if (Optional.IsDefined(PeriodInSeconds))
            {
                writer.WritePropertyName("periodSeconds"u8);
                writer.WriteNumberValue(PeriodInSeconds.Value);
            }
            if (Optional.IsDefined(FailureThreshold))
            {
                writer.WritePropertyName("failureThreshold"u8);
                writer.WriteNumberValue(FailureThreshold.Value);
            }
            if (Optional.IsDefined(SuccessThreshold))
            {
                writer.WritePropertyName("successThreshold"u8);
                writer.WriteNumberValue(SuccessThreshold.Value);
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                writer.WritePropertyName("timeoutSeconds"u8);
                writer.WriteNumberValue(TimeoutInSeconds.Value);
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

        ContainerProbe IJsonModel<ContainerProbe>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerProbe>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerProbe)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerProbe(document.RootElement, options);
        }

        internal static ContainerProbe DeserializeContainerProbe(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerExec exec = default;
            ContainerHttpGet httpGet = default;
            int? initialDelaySeconds = default;
            int? periodSeconds = default;
            int? failureThreshold = default;
            int? successThreshold = default;
            int? timeoutSeconds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("exec"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exec = ContainerExec.DeserializeContainerExec(property.Value, options);
                    continue;
                }
                if (property.NameEquals("httpGet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpGet = ContainerHttpGet.DeserializeContainerHttpGet(property.Value, options);
                    continue;
                }
                if (property.NameEquals("initialDelaySeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialDelaySeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("periodSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    periodSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("failureThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failureThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("successThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    successThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeoutSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeoutSeconds = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerProbe(
                exec,
                httpGet,
                initialDelaySeconds,
                periodSeconds,
                failureThreshold,
                successThreshold,
                timeoutSeconds,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerProbe>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerProbe>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerProbe)} does not support '{options.Format}' format.");
            }
        }

        ContainerProbe IPersistableModel<ContainerProbe>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerProbe>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerProbe(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerProbe)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerProbe>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
