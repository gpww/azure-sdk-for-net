// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.Hub.Service.Models
{
    public partial class CloudToDeviceMethodRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (MethodName != null)
            {
                writer.WritePropertyName("methodName"u8);
                writer.WriteStringValue(MethodName);
            }
            if (Payload != null)
            {
                writer.WritePropertyName("payload"u8);
                writer.WriteObjectValue(Payload);
            }
            if (ResponseTimeoutInSeconds.HasValue)
            {
                writer.WritePropertyName("responseTimeoutInSeconds"u8);
                writer.WriteNumberValue(ResponseTimeoutInSeconds.Value);
            }
            if (ConnectTimeoutInSeconds.HasValue)
            {
                writer.WritePropertyName("connectTimeoutInSeconds"u8);
                writer.WriteNumberValue(ConnectTimeoutInSeconds.Value);
            }
            writer.WriteEndObject();
        }

        internal static CloudToDeviceMethodRequest DeserializeCloudToDeviceMethodRequest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string methodName = default;
            object payload = default;
            int? responseTimeoutInSeconds = default;
            int? connectTimeoutInSeconds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("methodName"u8))
                {
                    methodName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("payload"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    payload = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("responseTimeoutInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    responseTimeoutInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("connectTimeoutInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectTimeoutInSeconds = property.Value.GetInt32();
                    continue;
                }
            }
            return new CloudToDeviceMethodRequest(methodName, payload, responseTimeoutInSeconds, connectTimeoutInSeconds);
        }
    }
}
