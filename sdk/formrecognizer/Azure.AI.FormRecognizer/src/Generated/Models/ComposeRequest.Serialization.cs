// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.AI.FormRecognizer;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class ComposeRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("modelIds"u8);
            writer.WriteStartArray();
            foreach (var item in ModelIds)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(ModelName))
            {
                writer.WritePropertyName("modelName"u8);
                writer.WriteStringValue(ModelName);
            }
            writer.WriteEndObject();
        }
    }
}
