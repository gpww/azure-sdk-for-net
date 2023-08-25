// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VnetRoute : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StaticRoutesConfig))
            {
                writer.WritePropertyName("staticRoutesConfig"u8);
                writer.WriteObjectValue(StaticRoutesConfig);
            }
            if (Optional.IsCollectionDefined(StaticRoutes))
            {
                writer.WritePropertyName("staticRoutes"u8);
                writer.WriteStartArray();
                foreach (var item in StaticRoutes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static VnetRoute DeserializeVnetRoute(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StaticRoutesConfig> staticRoutesConfig = default;
            Optional<IList<StaticRoute>> staticRoutes = default;
            Optional<IReadOnlyList<WritableSubResource>> bgpConnections = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("staticRoutesConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    staticRoutesConfig = StaticRoutesConfig.DeserializeStaticRoutesConfig(property.Value);
                    continue;
                }
                if (property.NameEquals("staticRoutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StaticRoute> array = new List<StaticRoute>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StaticRoute.DeserializeStaticRoute(item));
                    }
                    staticRoutes = array;
                    continue;
                }
                if (property.NameEquals("bgpConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    bgpConnections = array;
                    continue;
                }
            }
            return new VnetRoute(staticRoutesConfig.Value, Optional.ToList(staticRoutes), Optional.ToList(bgpConnections));
        }
    }
}
