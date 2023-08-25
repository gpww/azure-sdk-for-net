// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class RouteCriterion : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(RoutePrefix))
            {
                writer.WritePropertyName("routePrefix"u8);
                writer.WriteStartArray();
                foreach (var item in RoutePrefix)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Community))
            {
                writer.WritePropertyName("community"u8);
                writer.WriteStartArray();
                foreach (var item in Community)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AsPath))
            {
                writer.WritePropertyName("asPath"u8);
                writer.WriteStartArray();
                foreach (var item in AsPath)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MatchCondition))
            {
                writer.WritePropertyName("matchCondition"u8);
                writer.WriteStringValue(MatchCondition.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static RouteCriterion DeserializeRouteCriterion(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> routePrefix = default;
            Optional<IList<string>> community = default;
            Optional<IList<string>> asPath = default;
            Optional<RouteMapMatchCondition> matchCondition = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routePrefix"u8))
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
                    routePrefix = array;
                    continue;
                }
                if (property.NameEquals("community"u8))
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
                    community = array;
                    continue;
                }
                if (property.NameEquals("asPath"u8))
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
                    asPath = array;
                    continue;
                }
                if (property.NameEquals("matchCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    matchCondition = new RouteMapMatchCondition(property.Value.GetString());
                    continue;
                }
            }
            return new RouteCriterion(Optional.ToList(routePrefix), Optional.ToList(community), Optional.ToList(asPath), Optional.ToNullable(matchCondition));
        }
    }
}
