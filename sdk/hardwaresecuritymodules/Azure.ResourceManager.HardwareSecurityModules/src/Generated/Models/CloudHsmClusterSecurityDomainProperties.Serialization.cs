// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HardwareSecurityModules.Models
{
    public partial class CloudHsmClusterSecurityDomainProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FipsState))
            {
                writer.WritePropertyName("fipsState"u8);
                writer.WriteNumberValue(FipsState.Value);
            }
            if (Optional.IsDefined(ActivationStatus))
            {
                writer.WritePropertyName("activationStatus"u8);
                writer.WriteStringValue(ActivationStatus);
            }
            writer.WriteEndObject();
        }

        internal static CloudHsmClusterSecurityDomainProperties DeserializeCloudHsmClusterSecurityDomainProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> fipsState = default;
            Optional<string> activationStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fipsState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fipsState = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("activationStatus"u8))
                {
                    activationStatus = property.Value.GetString();
                    continue;
                }
            }
            return new CloudHsmClusterSecurityDomainProperties(Optional.ToNullable(fipsState), activationStatus.Value);
        }
    }
}
