// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.AI.MetricsAdvisor;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class ServicePrincipalInKVParam : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keyVaultEndpoint"u8);
            writer.WriteStringValue(KeyVaultEndpoint);
            writer.WritePropertyName("keyVaultClientId"u8);
            writer.WriteStringValue(KeyVaultClientId);
            if (Optional.IsDefined(KeyVaultClientSecret))
            {
                writer.WritePropertyName("keyVaultClientSecret"u8);
                writer.WriteStringValue(KeyVaultClientSecret);
            }
            writer.WritePropertyName("servicePrincipalIdNameInKV"u8);
            writer.WriteStringValue(ServicePrincipalIdNameInKV);
            writer.WritePropertyName("servicePrincipalSecretNameInKV"u8);
            writer.WriteStringValue(ServicePrincipalSecretNameInKV);
            writer.WritePropertyName("tenantId"u8);
            writer.WriteStringValue(TenantId);
            writer.WriteEndObject();
        }

        internal static ServicePrincipalInKVParam DeserializeServicePrincipalInKVParam(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string keyVaultEndpoint = default;
            string keyVaultClientId = default;
            string keyVaultClientSecret = default;
            string servicePrincipalIdNameInKV = default;
            string servicePrincipalSecretNameInKV = default;
            string tenantId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultEndpoint"u8))
                {
                    keyVaultEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultClientId"u8))
                {
                    keyVaultClientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultClientSecret"u8))
                {
                    keyVaultClientSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("servicePrincipalIdNameInKV"u8))
                {
                    servicePrincipalIdNameInKV = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("servicePrincipalSecretNameInKV"u8))
                {
                    servicePrincipalSecretNameInKV = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    tenantId = property.Value.GetString();
                    continue;
                }
            }
            return new ServicePrincipalInKVParam(
                keyVaultEndpoint,
                keyVaultClientId,
                keyVaultClientSecret,
                servicePrincipalIdNameInKV,
                servicePrincipalSecretNameInKV,
                tenantId);
        }
    }
}
