// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    public partial class WidgetTypeResourceFormatData : IUtf8JsonSerializable, IJsonModel<WidgetTypeResourceFormatData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WidgetTypeResourceFormatData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WidgetTypeResourceFormatData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WidgetTypeResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WidgetTypeResourceFormatData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(WidgetTypeName))
            {
                writer.WritePropertyName("widgetTypeName"u8);
                writer.WriteStringValue(WidgetTypeName);
            }
            if (Optional.IsDefined(Definition))
            {
                writer.WritePropertyName("definition"u8);
                writer.WriteStringValue(Definition);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStartObject();
                foreach (var item in DisplayName)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ImageUri))
            {
                writer.WritePropertyName("imageUrl"u8);
                writer.WriteStringValue(ImageUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(WidgetVersion))
            {
                writer.WritePropertyName("widgetVersion"u8);
                writer.WriteStringValue(WidgetVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(Changed))
            {
                writer.WritePropertyName("changed"u8);
                writer.WriteStringValue(Changed.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Created))
            {
                writer.WritePropertyName("created"u8);
                writer.WriteStringValue(Created.Value, "O");
            }
            writer.WriteEndObject();
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

        WidgetTypeResourceFormatData IJsonModel<WidgetTypeResourceFormatData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WidgetTypeResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WidgetTypeResourceFormatData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWidgetTypeResourceFormatData(document.RootElement, options);
        }

        internal static WidgetTypeResourceFormatData DeserializeWidgetTypeResourceFormatData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string widgetTypeName = default;
            string definition = default;
            string description = default;
            IDictionary<string, string> displayName = default;
            Uri imageUrl = default;
            Guid? tenantId = default;
            string widgetVersion = default;
            DateTimeOffset? changed = default;
            DateTimeOffset? created = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("widgetTypeName"u8))
                        {
                            widgetTypeName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("definition"u8))
                        {
                            definition = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            displayName = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("imageUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            imageUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("widgetVersion"u8))
                        {
                            widgetVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("changed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            changed = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("created"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            created = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WidgetTypeResourceFormatData(
                id,
                name,
                type,
                systemData,
                widgetTypeName,
                definition,
                description,
                displayName ?? new ChangeTrackingDictionary<string, string>(),
                imageUrl,
                tenantId,
                widgetVersion,
                changed,
                created,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WidgetTypeResourceFormatData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WidgetTypeResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WidgetTypeResourceFormatData)} does not support '{options.Format}' format.");
            }
        }

        WidgetTypeResourceFormatData IPersistableModel<WidgetTypeResourceFormatData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WidgetTypeResourceFormatData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWidgetTypeResourceFormatData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WidgetTypeResourceFormatData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WidgetTypeResourceFormatData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
