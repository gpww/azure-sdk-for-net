// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    public partial class P2SConnectionConfiguration : IUtf8JsonSerializable, IJsonModel<P2SConnectionConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<P2SConnectionConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<P2SConnectionConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<P2SConnectionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(P2SConnectionConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && ResourceType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (VpnClientAddressPool != null)
            {
                writer.WritePropertyName("vpnClientAddressPool"u8);
                writer.WriteObjectValue(VpnClientAddressPool);
            }
            if (RoutingConfiguration != null)
            {
                writer.WritePropertyName("routingConfiguration"u8);
                writer.WriteObjectValue(RoutingConfiguration);
            }
            if (EnableInternetSecurity.HasValue)
            {
                writer.WritePropertyName("enableInternetSecurity"u8);
                writer.WriteBooleanValue(EnableInternetSecurity.Value);
            }
            if (options.Format != "W" && !(ConfigurationPolicyGroupAssociations is ChangeTrackingList<WritableSubResource> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("configurationPolicyGroupAssociations"u8);
                writer.WriteStartArray();
                foreach (var item in ConfigurationPolicyGroupAssociations)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(PreviousConfigurationPolicyGroupAssociations is ChangeTrackingList<VpnServerConfigurationPolicyGroupData> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("previousConfigurationPolicyGroupAssociations"u8);
                writer.WriteStartArray();
                foreach (var item in PreviousConfigurationPolicyGroupAssociations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        P2SConnectionConfiguration IJsonModel<P2SConnectionConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<P2SConnectionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(P2SConnectionConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeP2SConnectionConfiguration(document.RootElement, options);
        }

        internal static P2SConnectionConfiguration DeserializeP2SConnectionConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            AddressSpace vpnClientAddressPool = default;
            RoutingConfiguration routingConfiguration = default;
            bool? enableInternetSecurity = default;
            IReadOnlyList<WritableSubResource> configurationPolicyGroupAssociations = default;
            IReadOnlyList<VpnServerConfigurationPolicyGroupData> previousConfigurationPolicyGroupAssociations = default;
            NetworkProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("vpnClientAddressPool"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vpnClientAddressPool = AddressSpace.DeserializeAddressSpace(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("routingConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routingConfiguration = RoutingConfiguration.DeserializeRoutingConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("enableInternetSecurity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableInternetSecurity = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("configurationPolicyGroupAssociations"u8))
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
                            configurationPolicyGroupAssociations = array;
                            continue;
                        }
                        if (property0.NameEquals("previousConfigurationPolicyGroupAssociations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VpnServerConfigurationPolicyGroupData> array = new List<VpnServerConfigurationPolicyGroupData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnServerConfigurationPolicyGroupData.DeserializeVpnServerConfigurationPolicyGroupData(item, options));
                            }
                            previousConfigurationPolicyGroupAssociations = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
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
            return new P2SConnectionConfiguration(
                id,
                name,
                type,
                serializedAdditionalRawData,
                etag,
                vpnClientAddressPool,
                routingConfiguration,
                enableInternetSecurity,
                configurationPolicyGroupAssociations ?? new ChangeTrackingList<WritableSubResource>(),
                previousConfigurationPolicyGroupAssociations ?? new ChangeTrackingList<VpnServerConfigurationPolicyGroupData>(),
                provisioningState);
        }

        BinaryData IPersistableModel<P2SConnectionConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<P2SConnectionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(P2SConnectionConfiguration)} does not support '{options.Format}' format.");
            }
        }

        P2SConnectionConfiguration IPersistableModel<P2SConnectionConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<P2SConnectionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeP2SConnectionConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(P2SConnectionConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<P2SConnectionConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
