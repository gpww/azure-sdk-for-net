// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class BootDiagnosticsInstanceView : IUtf8JsonSerializable, IJsonModel<BootDiagnosticsInstanceView>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BootDiagnosticsInstanceView>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BootDiagnosticsInstanceView>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BootDiagnosticsInstanceView>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BootDiagnosticsInstanceView)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ConsoleScreenshotBlobUri != null)
            {
                writer.WritePropertyName("consoleScreenshotBlobUri"u8);
                writer.WriteStringValue(ConsoleScreenshotBlobUri.AbsoluteUri);
            }
            if (options.Format != "W" && SerialConsoleLogBlobUri != null)
            {
                writer.WritePropertyName("serialConsoleLogBlobUri"u8);
                writer.WriteStringValue(SerialConsoleLogBlobUri.AbsoluteUri);
            }
            if (options.Format != "W" && Status != null)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status);
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

        BootDiagnosticsInstanceView IJsonModel<BootDiagnosticsInstanceView>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BootDiagnosticsInstanceView>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BootDiagnosticsInstanceView)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBootDiagnosticsInstanceView(document.RootElement, options);
        }

        internal static BootDiagnosticsInstanceView DeserializeBootDiagnosticsInstanceView(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri consoleScreenshotBlobUri = default;
            Uri serialConsoleLogBlobUri = default;
            InstanceViewStatus status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("consoleScreenshotBlobUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    consoleScreenshotBlobUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serialConsoleLogBlobUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serialConsoleLogBlobUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = InstanceViewStatus.DeserializeInstanceViewStatus(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BootDiagnosticsInstanceView(consoleScreenshotBlobUri, serialConsoleLogBlobUri, status, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BootDiagnosticsInstanceView>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BootDiagnosticsInstanceView>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BootDiagnosticsInstanceView)} does not support '{options.Format}' format.");
            }
        }

        BootDiagnosticsInstanceView IPersistableModel<BootDiagnosticsInstanceView>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BootDiagnosticsInstanceView>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBootDiagnosticsInstanceView(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BootDiagnosticsInstanceView)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BootDiagnosticsInstanceView>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
