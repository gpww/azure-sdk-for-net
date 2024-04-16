// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.IO;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.OpenAI;

public partial class ChatCompletionsOptions
{
    public string GetMessagesJson()
    {
        return GetObjectJson(Messages);
    }
    public string GetToolsJson()
    {
        return GetObjectJson(Tools);
    }
    private readonly MemoryStream _memoryStream = new MemoryStream();
    private readonly Utf8JsonWriter _jsonWriter;
    private readonly StreamReader _streamReader;

    public string GetObjectJson(object obj)
    {
        _jsonWriter.Reset();
        _jsonWriter.WriteObjectValue(obj);
        _jsonWriter.Flush();
        _memoryStream.Position = 0;
        var json = _streamReader.ReadToEnd();
        _memoryStream.SetLength(0);
        return json;
    }
}
