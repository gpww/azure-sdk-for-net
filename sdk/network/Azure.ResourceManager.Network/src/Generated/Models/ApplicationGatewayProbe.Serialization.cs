// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayProbe : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsDefined(Host))
            {
                writer.WritePropertyName("host"u8);
                writer.WriteStringValue(Host);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(IntervalInSeconds))
            {
                writer.WritePropertyName("interval"u8);
                writer.WriteNumberValue(IntervalInSeconds.Value);
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteNumberValue(TimeoutInSeconds.Value);
            }
            if (Optional.IsDefined(UnhealthyThreshold))
            {
                writer.WritePropertyName("unhealthyThreshold"u8);
                writer.WriteNumberValue(UnhealthyThreshold.Value);
            }
            if (Optional.IsDefined(PickHostNameFromBackendHttpSettings))
            {
                writer.WritePropertyName("pickHostNameFromBackendHttpSettings"u8);
                writer.WriteBooleanValue(PickHostNameFromBackendHttpSettings.Value);
            }
            if (Optional.IsDefined(PickHostNameFromBackendSettings))
            {
                writer.WritePropertyName("pickHostNameFromBackendSettings"u8);
                writer.WriteBooleanValue(PickHostNameFromBackendSettings.Value);
            }
            if (Optional.IsDefined(MinServers))
            {
                writer.WritePropertyName("minServers"u8);
                writer.WriteNumberValue(MinServers.Value);
            }
            if (Optional.IsDefined(Match))
            {
                writer.WritePropertyName("match"u8);
                writer.WriteObjectValue(Match);
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayProbe DeserializeApplicationGatewayProbe(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<ApplicationGatewayProtocol> protocol = default;
            Optional<string> host = default;
            Optional<string> path = default;
            Optional<int> interval = default;
            Optional<int> timeout = default;
            Optional<int> unhealthyThreshold = default;
            Optional<bool> pickHostNameFromBackendHttpSettings = default;
            Optional<bool> pickHostNameFromBackendSettings = default;
            Optional<int> minServers = default;
            Optional<ApplicationGatewayProbeHealthResponseMatch> match = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<int> port = default;
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
                        if (property0.NameEquals("protocol"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protocol = new ApplicationGatewayProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("host"u8))
                        {
                            host = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("path"u8))
                        {
                            path = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("interval"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            interval = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("timeout"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeout = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("unhealthyThreshold"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            unhealthyThreshold = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("pickHostNameFromBackendHttpSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pickHostNameFromBackendHttpSettings = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("pickHostNameFromBackendSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pickHostNameFromBackendSettings = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("minServers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minServers = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("match"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            match = ApplicationGatewayProbeHealthResponseMatch.DeserializeApplicationGatewayProbeHealthResponseMatch(property0.Value);
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
                        if (property0.NameEquals("port"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            port = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApplicationGatewayProbe(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(etag), Optional.ToNullable(protocol), host.Value, path.Value, Optional.ToNullable(interval), Optional.ToNullable(timeout), Optional.ToNullable(unhealthyThreshold), Optional.ToNullable(pickHostNameFromBackendHttpSettings), Optional.ToNullable(pickHostNameFromBackendSettings), Optional.ToNullable(minServers), match.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(port));
        }
    }
}
