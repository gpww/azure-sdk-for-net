// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    public partial class DocumentPage
    {
        internal static DocumentPage DeserializeDocumentPage(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int pageNumber = default;
            Optional<float> angle = default;
            Optional<float> width = default;
            Optional<float> height = default;
            Optional<LengthUnit> unit = default;
            IReadOnlyList<DocumentSpan> spans = default;
            Optional<IReadOnlyList<DocumentWord>> words = default;
            Optional<IReadOnlyList<DocumentSelectionMark>> selectionMarks = default;
            Optional<IReadOnlyList<DocumentLine>> lines = default;
            Optional<IReadOnlyList<DocumentBarcode>> barcodes = default;
            Optional<IReadOnlyList<DocumentFormula>> formulas = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pageNumber"u8))
                {
                    pageNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("angle"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    angle = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("width"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    width = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("height"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    height = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unit = new LengthUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("spans"u8))
                {
                    List<DocumentSpan> array = new List<DocumentSpan>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentSpan.DeserializeDocumentSpan(item));
                    }
                    spans = array;
                    continue;
                }
                if (property.NameEquals("words"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentWord> array = new List<DocumentWord>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentWord.DeserializeDocumentWord(item));
                    }
                    words = array;
                    continue;
                }
                if (property.NameEquals("selectionMarks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentSelectionMark> array = new List<DocumentSelectionMark>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentSelectionMark.DeserializeDocumentSelectionMark(item));
                    }
                    selectionMarks = array;
                    continue;
                }
                if (property.NameEquals("lines"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentLine> array = new List<DocumentLine>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentLine.DeserializeDocumentLine(item));
                    }
                    lines = array;
                    continue;
                }
                if (property.NameEquals("barcodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentBarcode> array = new List<DocumentBarcode>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentBarcode.DeserializeDocumentBarcode(item));
                    }
                    barcodes = array;
                    continue;
                }
                if (property.NameEquals("formulas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentFormula> array = new List<DocumentFormula>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentFormula.DeserializeDocumentFormula(item));
                    }
                    formulas = array;
                    continue;
                }
            }
            return new DocumentPage(pageNumber, Optional.ToNullable(angle), Optional.ToNullable(width), Optional.ToNullable(height), Optional.ToNullable(unit), spans, Optional.ToList(words), Optional.ToList(selectionMarks), Optional.ToList(lines), Optional.ToList(barcodes), Optional.ToList(formulas));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DocumentPage FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDocumentPage(document.RootElement);
        }
    }
}
