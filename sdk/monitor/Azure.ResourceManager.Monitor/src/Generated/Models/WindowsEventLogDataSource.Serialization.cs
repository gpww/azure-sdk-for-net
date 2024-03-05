// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class WindowsEventLogDataSource : IUtf8JsonSerializable, IJsonModel<WindowsEventLogDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WindowsEventLogDataSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WindowsEventLogDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsEventLogDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WindowsEventLogDataSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Streams))
            {
                writer.WritePropertyName("streams"u8);
                writer.WriteStartArray();
                foreach (var item in Streams)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(XPathQueries))
            {
                writer.WritePropertyName("xPathQueries"u8);
                writer.WriteStartArray();
                foreach (var item in XPathQueries)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
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

        WindowsEventLogDataSource IJsonModel<WindowsEventLogDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsEventLogDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WindowsEventLogDataSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWindowsEventLogDataSource(document.RootElement, options);
        }

        internal static WindowsEventLogDataSource DeserializeWindowsEventLogDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<WindowsEventLogDataSourceStream> streams = default;
            IList<string> xPathQueries = default;
            string name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streams"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WindowsEventLogDataSourceStream> array = new List<WindowsEventLogDataSourceStream>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new WindowsEventLogDataSourceStream(item.GetString()));
                    }
                    streams = array;
                    continue;
                }
                if (property.NameEquals("xPathQueries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    xPathQueries = array;
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WindowsEventLogDataSource(streams ?? new ChangeTrackingList<WindowsEventLogDataSourceStream>(), xPathQueries ?? new ChangeTrackingList<string>(), name, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WindowsEventLogDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsEventLogDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WindowsEventLogDataSource)} does not support '{options.Format}' format.");
            }
        }

        WindowsEventLogDataSource IPersistableModel<WindowsEventLogDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsEventLogDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWindowsEventLogDataSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WindowsEventLogDataSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WindowsEventLogDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
