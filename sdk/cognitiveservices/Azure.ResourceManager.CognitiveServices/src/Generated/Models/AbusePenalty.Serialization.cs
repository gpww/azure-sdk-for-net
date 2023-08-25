// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class AbusePenalty
    {
        internal static AbusePenalty DeserializeAbusePenalty(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AbusePenaltyAction> action = default;
            Optional<float> rateLimitPercentage = default;
            Optional<DateTimeOffset> expiration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("action"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    action = new AbusePenaltyAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rateLimitPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rateLimitPercentage = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("expiration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiration = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new AbusePenalty(Optional.ToNullable(action), Optional.ToNullable(rateLimitPercentage), Optional.ToNullable(expiration));
        }
    }
}
