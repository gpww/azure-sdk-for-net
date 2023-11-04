// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RollingUpgradeRunningStatus : IUtf8JsonSerializable, IJsonModel<RollingUpgradeRunningStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RollingUpgradeRunningStatus>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<RollingUpgradeRunningStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Code))
                {
                    writer.WritePropertyName("code"u8);
                    writer.WriteStringValue(Code.Value.ToSerialString());
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(StartOn))
                {
                    writer.WritePropertyName("startTime"u8);
                    writer.WriteStringValue(StartOn.Value, "O");
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(LastAction))
                {
                    writer.WritePropertyName("lastAction"u8);
                    writer.WriteStringValue(LastAction.Value.ToSerialString());
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(LastActionOn))
                {
                    writer.WritePropertyName("lastActionTime"u8);
                    writer.WriteStringValue(LastActionOn.Value, "O");
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        RollingUpgradeRunningStatus IJsonModel<RollingUpgradeRunningStatus>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRollingUpgradeRunningStatus(document.RootElement, options);
        }

        internal static RollingUpgradeRunningStatus DeserializeRollingUpgradeRunningStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<RollingUpgradeStatusCode> code = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<RollingUpgradeActionType> lastAction = default;
            Optional<DateTimeOffset> lastActionTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    code = property.Value.GetString().ToRollingUpgradeStatusCode();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastAction = property.Value.GetString().ToRollingUpgradeActionType();
                    continue;
                }
                if (property.NameEquals("lastActionTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastActionTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RollingUpgradeRunningStatus(Optional.ToNullable(code), Optional.ToNullable(startTime), Optional.ToNullable(lastAction), Optional.ToNullable(lastActionTime), serializedAdditionalRawData);
        }

        BinaryData IModel<RollingUpgradeRunningStatus>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RollingUpgradeRunningStatus IModel<RollingUpgradeRunningStatus>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRollingUpgradeRunningStatus(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<RollingUpgradeRunningStatus>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
