// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Workloads;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class CentralServerFullResourceNames : IUtf8JsonSerializable, IJsonModel<CentralServerFullResourceNames>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CentralServerFullResourceNames>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CentralServerFullResourceNames>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CentralServerFullResourceNames>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CentralServerFullResourceNames)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(VirtualMachines))
            {
                writer.WritePropertyName("virtualMachines"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualMachines)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AvailabilitySetName))
            {
                writer.WritePropertyName("availabilitySetName"u8);
                writer.WriteStringValue(AvailabilitySetName);
            }
            if (Optional.IsDefined(LoadBalancer))
            {
                writer.WritePropertyName("loadBalancer"u8);
                writer.WriteObjectValue(LoadBalancer);
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

        CentralServerFullResourceNames IJsonModel<CentralServerFullResourceNames>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CentralServerFullResourceNames>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CentralServerFullResourceNames)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCentralServerFullResourceNames(document.RootElement, options);
        }

        internal static CentralServerFullResourceNames DeserializeCentralServerFullResourceNames(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<VirtualMachineResourceNames> virtualMachines = default;
            string availabilitySetName = default;
            LoadBalancerResourceNames loadBalancer = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualMachines"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualMachineResourceNames> array = new List<VirtualMachineResourceNames>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineResourceNames.DeserializeVirtualMachineResourceNames(item, options));
                    }
                    virtualMachines = array;
                    continue;
                }
                if (property.NameEquals("availabilitySetName"u8))
                {
                    availabilitySetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loadBalancer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loadBalancer = LoadBalancerResourceNames.DeserializeLoadBalancerResourceNames(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CentralServerFullResourceNames(virtualMachines ?? new ChangeTrackingList<VirtualMachineResourceNames>(), availabilitySetName, loadBalancer, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CentralServerFullResourceNames>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CentralServerFullResourceNames>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CentralServerFullResourceNames)} does not support '{options.Format}' format.");
            }
        }

        CentralServerFullResourceNames IPersistableModel<CentralServerFullResourceNames>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CentralServerFullResourceNames>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCentralServerFullResourceNames(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CentralServerFullResourceNames)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CentralServerFullResourceNames>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
