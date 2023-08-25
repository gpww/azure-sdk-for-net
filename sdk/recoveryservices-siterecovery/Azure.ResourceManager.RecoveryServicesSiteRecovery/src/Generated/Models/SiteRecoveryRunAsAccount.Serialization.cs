// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryRunAsAccount
    {
        internal static SiteRecoveryRunAsAccount DeserializeSiteRecoveryRunAsAccount(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> accountId = default;
            Optional<string> accountName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountId"u8))
                {
                    accountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
            }
            return new SiteRecoveryRunAsAccount(accountId.Value, accountName.Value);
        }
    }
}
