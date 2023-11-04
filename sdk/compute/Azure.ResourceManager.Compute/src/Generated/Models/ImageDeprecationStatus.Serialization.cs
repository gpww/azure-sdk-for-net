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
    public partial class ImageDeprecationStatus : IUtf8JsonSerializable, IJsonModel<ImageDeprecationStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImageDeprecationStatus>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ImageDeprecationStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ImageState))
            {
                writer.WritePropertyName("imageState"u8);
                writer.WriteStringValue(ImageState.Value.ToString());
            }
            if (Optional.IsDefined(ScheduledDeprecationOn))
            {
                writer.WritePropertyName("scheduledDeprecationTime"u8);
                writer.WriteStringValue(ScheduledDeprecationOn.Value, "O");
            }
            if (Optional.IsDefined(AlternativeOption))
            {
                writer.WritePropertyName("alternativeOption"u8);
                writer.WriteObjectValue(AlternativeOption);
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

        ImageDeprecationStatus IJsonModel<ImageDeprecationStatus>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImageDeprecationStatus(document.RootElement, options);
        }

        internal static ImageDeprecationStatus DeserializeImageDeprecationStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ImageState> imageState = default;
            Optional<DateTimeOffset> scheduledDeprecationTime = default;
            Optional<ImageAlternativeOption> alternativeOption = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageState = new ImageState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scheduledDeprecationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduledDeprecationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("alternativeOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    alternativeOption = ImageAlternativeOption.DeserializeImageAlternativeOption(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImageDeprecationStatus(Optional.ToNullable(imageState), Optional.ToNullable(scheduledDeprecationTime), alternativeOption.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<ImageDeprecationStatus>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ImageDeprecationStatus IModel<ImageDeprecationStatus>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeImageDeprecationStatus(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ImageDeprecationStatus>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
