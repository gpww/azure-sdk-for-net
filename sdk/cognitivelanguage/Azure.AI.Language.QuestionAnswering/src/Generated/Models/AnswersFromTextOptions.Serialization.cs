// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.QuestionAnswering
{
    public partial class AnswersFromTextOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("question"u8);
            writer.WriteStringValue(Question);
            writer.WritePropertyName("records"u8);
            writer.WriteStartArray();
            foreach (var item in TextDocuments)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Language != null)
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            if (StringIndexType.HasValue)
            {
                writer.WritePropertyName("stringIndexType"u8);
                writer.WriteStringValue(StringIndexType.Value.ToString());
            }
            writer.WriteEndObject();
        }
    }
}
