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

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class HostPoolPatch : IUtf8JsonSerializable, IJsonModel<HostPoolPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HostPoolPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HostPoolPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostPoolPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HostPoolPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
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
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (FriendlyName != null)
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (CustomRdpProperty != null)
            {
                writer.WritePropertyName("customRdpProperty"u8);
                writer.WriteStringValue(CustomRdpProperty);
            }
            if (MaxSessionLimit.HasValue)
            {
                writer.WritePropertyName("maxSessionLimit"u8);
                writer.WriteNumberValue(MaxSessionLimit.Value);
            }
            if (PersonalDesktopAssignmentType.HasValue)
            {
                writer.WritePropertyName("personalDesktopAssignmentType"u8);
                writer.WriteStringValue(PersonalDesktopAssignmentType.Value.ToString());
            }
            if (LoadBalancerType.HasValue)
            {
                writer.WritePropertyName("loadBalancerType"u8);
                writer.WriteStringValue(LoadBalancerType.Value.ToString());
            }
            if (Ring.HasValue)
            {
                writer.WritePropertyName("ring"u8);
                writer.WriteNumberValue(Ring.Value);
            }
            if (IsValidationEnvironment.HasValue)
            {
                writer.WritePropertyName("validationEnvironment"u8);
                writer.WriteBooleanValue(IsValidationEnvironment.Value);
            }
            if (RegistrationInfo != null)
            {
                writer.WritePropertyName("registrationInfo"u8);
                writer.WriteObjectValue(RegistrationInfo);
            }
            if (VmTemplate != null)
            {
                writer.WritePropertyName("vmTemplate"u8);
                writer.WriteStringValue(VmTemplate);
            }
            if (SsoAdfsAuthority != null)
            {
                writer.WritePropertyName("ssoadfsAuthority"u8);
                writer.WriteStringValue(SsoAdfsAuthority);
            }
            if (SsoClientId != null)
            {
                writer.WritePropertyName("ssoClientId"u8);
                writer.WriteStringValue(SsoClientId);
            }
            if (SsoClientSecretKeyVaultPath != null)
            {
                writer.WritePropertyName("ssoClientSecretKeyVaultPath"u8);
                writer.WriteStringValue(SsoClientSecretKeyVaultPath);
            }
            if (SsoSecretType.HasValue)
            {
                writer.WritePropertyName("ssoSecretType"u8);
                writer.WriteStringValue(SsoSecretType.Value.ToString());
            }
            if (PreferredAppGroupType.HasValue)
            {
                writer.WritePropertyName("preferredAppGroupType"u8);
                writer.WriteStringValue(PreferredAppGroupType.Value.ToString());
            }
            if (StartVmOnConnect.HasValue)
            {
                writer.WritePropertyName("startVMOnConnect"u8);
                writer.WriteBooleanValue(StartVmOnConnect.Value);
            }
            if (PublicNetworkAccess.HasValue)
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (AgentUpdate != null)
            {
                writer.WritePropertyName("agentUpdate"u8);
                writer.WriteObjectValue(AgentUpdate);
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

        HostPoolPatch IJsonModel<HostPoolPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostPoolPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HostPoolPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHostPoolPatch(document.RootElement, options);
        }

        internal static HostPoolPatch DeserializeHostPoolPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string friendlyName = default;
            string description = default;
            string customRdpProperty = default;
            int? maxSessionLimit = default;
            PersonalDesktopAssignmentType? personalDesktopAssignmentType = default;
            HostPoolLoadBalancerType? loadBalancerType = default;
            int? ring = default;
            bool? validationEnvironment = default;
            HostPoolRegistrationInfoPatch registrationInfo = default;
            string vmTemplate = default;
            string ssoadfsAuthority = default;
            string ssoClientId = default;
            string ssoClientSecretKeyVaultPath = default;
            HostPoolSsoSecretType? ssoSecretType = default;
            PreferredAppGroupType? preferredAppGroupType = default;
            bool? startVmOnConnect = default;
            HostPoolPublicNetworkAccess? publicNetworkAccess = default;
            SessionHostAgentUpdatePatchProperties agentUpdate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customRdpProperty"u8))
                        {
                            customRdpProperty = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maxSessionLimit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxSessionLimit = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("personalDesktopAssignmentType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            personalDesktopAssignmentType = new PersonalDesktopAssignmentType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            loadBalancerType = new HostPoolLoadBalancerType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ring"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ring = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("validationEnvironment"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            validationEnvironment = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("registrationInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            registrationInfo = HostPoolRegistrationInfoPatch.DeserializeHostPoolRegistrationInfoPatch(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("vmTemplate"u8))
                        {
                            vmTemplate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ssoadfsAuthority"u8))
                        {
                            ssoadfsAuthority = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ssoClientId"u8))
                        {
                            ssoClientId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ssoClientSecretKeyVaultPath"u8))
                        {
                            ssoClientSecretKeyVaultPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ssoSecretType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ssoSecretType = new HostPoolSsoSecretType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("preferredAppGroupType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            preferredAppGroupType = new PreferredAppGroupType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startVMOnConnect"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startVmOnConnect = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new HostPoolPublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("agentUpdate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            agentUpdate = SessionHostAgentUpdatePatchProperties.DeserializeSessionHostAgentUpdatePatchProperties(property0.Value, options);
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
            return new HostPoolPatch(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                friendlyName,
                description,
                customRdpProperty,
                maxSessionLimit,
                personalDesktopAssignmentType,
                loadBalancerType,
                ring,
                validationEnvironment,
                registrationInfo,
                vmTemplate,
                ssoadfsAuthority,
                ssoClientId,
                ssoClientSecretKeyVaultPath,
                ssoSecretType,
                preferredAppGroupType,
                startVmOnConnect,
                publicNetworkAccess,
                agentUpdate,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HostPoolPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostPoolPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HostPoolPatch)} does not support '{options.Format}' format.");
            }
        }

        HostPoolPatch IPersistableModel<HostPoolPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostPoolPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHostPoolPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HostPoolPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HostPoolPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
