// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using ClientModel.Tests.ClientShared;
using System.ClientModel.Primitives;
using System.ClientModel.Tests.Client.Models.ResourceManager.Resources;
using System.Collections.Generic;
using System.Text.Json;

namespace System.ClientModel.Tests.Client.Models.ResourceManager.Compute
{
    public partial class AvailabilitySetData : IJsonModel<AvailabilitySetData>
    {
        void IJsonModel<AvailabilitySetData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            Serialize(writer, options);
        }

        private void Serialize(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == "J")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id.ToString());
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.ToString());
            }
            if (OptionalProperty.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (OptionalProperty.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (OptionalProperty.IsDefined(PlatformUpdateDomainCount))
            {
                writer.WritePropertyName("platformUpdateDomainCount"u8);
                writer.WriteNumberValue(PlatformUpdateDomainCount.Value);
            }
            if (OptionalProperty.IsDefined(PlatformFaultDomainCount))
            {
                writer.WritePropertyName("platformFaultDomainCount"u8);
                writer.WriteNumberValue(PlatformFaultDomainCount.Value);
            }
            if (OptionalProperty.IsCollectionDefined(VirtualMachines))
            {
                writer.WritePropertyName("virtualMachines"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualMachines)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (OptionalProperty.IsDefined(ProximityPlacementGroup))
            {
                writer.WritePropertyName("proximityPlacementGroup"u8);
                JsonSerializer.Serialize(writer, ProximityPlacementGroup);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        public static AvailabilitySetData DeserializeAvailabilitySetData(JsonElement element, ModelReaderWriterOptions options = default)
        {
            options ??= ModelReaderWriterHelper.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OptionalProperty<ComputeSku> sku = default;
            OptionalProperty<IDictionary<string, string>> tags = default;
            string location = default;
            string id = default;
            string name = default;
            string type = default;
            OptionalProperty<SystemData> systemData = default;
            OptionalProperty<int> platformUpdateDomainCount = default;
            OptionalProperty<int> platformFaultDomainCount = default;
            OptionalProperty<IList<WritableSubResource>> virtualMachines = default;
            OptionalProperty<WritableSubResource> proximityPlacementGroup = default;
            OptionalProperty<IReadOnlyList<InstanceViewStatus>> statuses = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = ComputeSku.DeserializeComputeSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("platformUpdateDomainCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            platformUpdateDomainCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("platformFaultDomainCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            platformFaultDomainCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("virtualMachines"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            virtualMachines = array;
                            continue;
                        }
                        if (property0.NameEquals("proximityPlacementGroup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            proximityPlacementGroup = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("statuses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<InstanceViewStatus> array = new List<InstanceViewStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(InstanceViewStatus.DeserializeInstanceViewStatus(item, options));
                            }
                            statuses = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AvailabilitySetData(id, name, type, systemData.Value, OptionalProperty.ToDictionary(tags), location, sku.Value, OptionalProperty.ToNullable(platformUpdateDomainCount), OptionalProperty.ToNullable(platformFaultDomainCount), OptionalProperty.ToList(virtualMachines), proximityPlacementGroup, OptionalProperty.ToList(statuses));
        }

        AvailabilitySetData IPersistableModel<AvailabilitySetData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAvailabilitySetData(doc.RootElement, options);
        }

        private struct AvailabilitySetDataProperties
        {
            public OptionalProperty<ComputeSku> Sku { get; set; }
            public OptionalProperty<IDictionary<string, string>> Tags { get; set; }
            public string Location { get; set; }
            public string Id { get; set; }
            public string Name { get; set; }
            public string ResourceType { get; set; }
            public OptionalProperty<SystemData> SystemData { get; set; }
            public OptionalProperty<int> PlatformUpdateDomainCount { get; set; }
            public OptionalProperty<int> PlatformFaultDomainCount { get; set; }
            public OptionalProperty<IList<WritableSubResource>> VirtualMachines { get; set; }
            public OptionalProperty<WritableSubResource> ProximityPlacementGroup { get; set; }
            public OptionalProperty<IReadOnlyList<InstanceViewStatus>> Statuses { get; set; }
        }

        AvailabilitySetData IJsonModel<AvailabilitySetData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailabilitySetData(doc.RootElement, options);
        }

        BinaryData IPersistableModel<AvailabilitySetData>.Write(ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            return ModelReaderWriter.Write(this, options);
        }

        string IPersistableModel<AvailabilitySetData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
