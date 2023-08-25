// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class FirewallPolicyIntrusionDetectionConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(SignatureOverrides))
            {
                writer.WritePropertyName("signatureOverrides"u8);
                writer.WriteStartArray();
                foreach (var item in SignatureOverrides)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(BypassTrafficSettings))
            {
                writer.WritePropertyName("bypassTrafficSettings"u8);
                writer.WriteStartArray();
                foreach (var item in BypassTrafficSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PrivateRanges))
            {
                writer.WritePropertyName("privateRanges"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateRanges)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static FirewallPolicyIntrusionDetectionConfiguration DeserializeFirewallPolicyIntrusionDetectionConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<FirewallPolicyIntrusionDetectionSignatureSpecification>> signatureOverrides = default;
            Optional<IList<FirewallPolicyIntrusionDetectionBypassTrafficSpecifications>> bypassTrafficSettings = default;
            Optional<IList<string>> privateRanges = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("signatureOverrides"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FirewallPolicyIntrusionDetectionSignatureSpecification> array = new List<FirewallPolicyIntrusionDetectionSignatureSpecification>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FirewallPolicyIntrusionDetectionSignatureSpecification.DeserializeFirewallPolicyIntrusionDetectionSignatureSpecification(item));
                    }
                    signatureOverrides = array;
                    continue;
                }
                if (property.NameEquals("bypassTrafficSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FirewallPolicyIntrusionDetectionBypassTrafficSpecifications> array = new List<FirewallPolicyIntrusionDetectionBypassTrafficSpecifications>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FirewallPolicyIntrusionDetectionBypassTrafficSpecifications.DeserializeFirewallPolicyIntrusionDetectionBypassTrafficSpecifications(item));
                    }
                    bypassTrafficSettings = array;
                    continue;
                }
                if (property.NameEquals("privateRanges"u8))
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
                    privateRanges = array;
                    continue;
                }
            }
            return new FirewallPolicyIntrusionDetectionConfiguration(Optional.ToList(signatureOverrides), Optional.ToList(bypassTrafficSettings), Optional.ToList(privateRanges));
        }
    }
}
