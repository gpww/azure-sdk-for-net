// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class EdgeKubernetesNodeInfo : IUtf8JsonSerializable, IJsonModel<EdgeKubernetesNodeInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeKubernetesNodeInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EdgeKubernetesNodeInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeKubernetesNodeInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeKubernetesNodeInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(NodeType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(NodeType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IPConfiguration))
            {
                writer.WritePropertyName("ipConfiguration"u8);
                writer.WriteStartArray();
                foreach (var item in IPConfiguration)
                {
                    writer.WriteObjectValue(item);
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

        EdgeKubernetesNodeInfo IJsonModel<EdgeKubernetesNodeInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeKubernetesNodeInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeKubernetesNodeInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeKubernetesNodeInfo(document.RootElement, options);
        }

        internal static EdgeKubernetesNodeInfo DeserializeEdgeKubernetesNodeInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            EdgeKubernetesNodeType? type = default;
            IReadOnlyList<EdgeKubernetesIPConfiguration> ipConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new EdgeKubernetesNodeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EdgeKubernetesIPConfiguration> array = new List<EdgeKubernetesIPConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EdgeKubernetesIPConfiguration.DeserializeEdgeKubernetesIPConfiguration(item, options));
                    }
                    ipConfiguration = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EdgeKubernetesNodeInfo(name, type, ipConfiguration ?? new ChangeTrackingList<EdgeKubernetesIPConfiguration>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdgeKubernetesNodeInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeKubernetesNodeInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EdgeKubernetesNodeInfo)} does not support '{options.Format}' format.");
            }
        }

        EdgeKubernetesNodeInfo IPersistableModel<EdgeKubernetesNodeInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeKubernetesNodeInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEdgeKubernetesNodeInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeKubernetesNodeInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeKubernetesNodeInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
