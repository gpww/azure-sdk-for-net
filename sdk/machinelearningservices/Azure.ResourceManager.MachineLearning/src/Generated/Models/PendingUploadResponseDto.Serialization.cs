// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class PendingUploadResponseDto : IUtf8JsonSerializable, IJsonModel<PendingUploadResponseDto>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PendingUploadResponseDto>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PendingUploadResponseDto>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PendingUploadResponseDto>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PendingUploadResponseDto)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (BlobReferenceForConsumption != null)
            {
                if (BlobReferenceForConsumption != null)
                {
                    writer.WritePropertyName("blobReferenceForConsumption"u8);
                    writer.WriteObjectValue(BlobReferenceForConsumption);
                }
                else
                {
                    writer.WriteNull("blobReferenceForConsumption");
                }
            }
            if (PendingUploadId != null)
            {
                if (PendingUploadId != null)
                {
                    writer.WritePropertyName("pendingUploadId"u8);
                    writer.WriteStringValue(PendingUploadId);
                }
                else
                {
                    writer.WriteNull("pendingUploadId");
                }
            }
            if (PendingUploadType.HasValue)
            {
                writer.WritePropertyName("pendingUploadType"u8);
                writer.WriteStringValue(PendingUploadType.Value.ToString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        PendingUploadResponseDto IJsonModel<PendingUploadResponseDto>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PendingUploadResponseDto>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PendingUploadResponseDto)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePendingUploadResponseDto(document.RootElement, options);
        }

        internal static PendingUploadResponseDto DeserializePendingUploadResponseDto(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BlobReferenceForConsumptionDto blobReferenceForConsumption = default;
            string pendingUploadId = default;
            PendingUploadType? pendingUploadType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blobReferenceForConsumption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        blobReferenceForConsumption = null;
                        continue;
                    }
                    blobReferenceForConsumption = BlobReferenceForConsumptionDto.DeserializeBlobReferenceForConsumptionDto(property.Value, options);
                    continue;
                }
                if (property.NameEquals("pendingUploadId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        pendingUploadId = null;
                        continue;
                    }
                    pendingUploadId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pendingUploadType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pendingUploadType = new PendingUploadType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PendingUploadResponseDto(blobReferenceForConsumption, pendingUploadId, pendingUploadType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PendingUploadResponseDto>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PendingUploadResponseDto>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PendingUploadResponseDto)} does not support '{options.Format}' format.");
            }
        }

        PendingUploadResponseDto IPersistableModel<PendingUploadResponseDto>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PendingUploadResponseDto>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePendingUploadResponseDto(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PendingUploadResponseDto)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PendingUploadResponseDto>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
