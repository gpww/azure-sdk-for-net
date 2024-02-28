// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Routing
{
    public partial class RouteMatrixQuery : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (GeoJsonMultiPointOrigins != null)
            {
                writer.WritePropertyName("origins"u8);
                writer.WriteObjectValue(GeoJsonMultiPointOrigins);
            }
            if (GeoJsonMultiPointDestinations != null)
            {
                writer.WritePropertyName("destinations"u8);
                writer.WriteObjectValue(GeoJsonMultiPointDestinations);
            }
            writer.WriteEndObject();
        }
    }
}
