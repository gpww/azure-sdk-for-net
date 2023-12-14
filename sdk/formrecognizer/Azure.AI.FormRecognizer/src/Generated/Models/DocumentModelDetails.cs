// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Document model info. </summary>
    public partial class DocumentModelDetails
    {
        /// <summary> Initializes a new instance of <see cref="DocumentModelDetails"/>. </summary>
        /// <param name="modelId"> Unique document model name. </param>
        /// <param name="createdOn"> Date and time (UTC) when the document model was created. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> is null. </exception>
        internal DocumentModelDetails(string modelId, DateTimeOffset createdOn)
        {
            Argument.AssertNotNull(modelId, nameof(modelId));

            ModelId = modelId;
            CreatedOn = createdOn;
            Tags = new ChangeTrackingDictionary<string, string>();
            DocumentTypes = new ChangeTrackingDictionary<string, DocumentTypeDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="DocumentModelDetails"/>. </summary>
        /// <param name="modelId"> Unique document model name. </param>
        /// <param name="description"> Document model description. </param>
        /// <param name="createdOn"> Date and time (UTC) when the document model was created. </param>
        /// <param name="expiresOn"> Date and time (UTC) when the document model will expire. </param>
        /// <param name="serviceVersion"> API version used to create this document model. </param>
        /// <param name="tags"> List of key-value tag attributes associated with the document model. </param>
        /// <param name="documentTypes"> Supported document types. </param>
        internal DocumentModelDetails(string modelId, string description, DateTimeOffset createdOn, DateTimeOffset? expiresOn, string serviceVersion, IReadOnlyDictionary<string, string> tags, IReadOnlyDictionary<string, DocumentTypeDetails> documentTypes)
        {
            ModelId = modelId;
            Description = description;
            CreatedOn = createdOn;
            ExpiresOn = expiresOn;
            ServiceVersion = serviceVersion;
            Tags = tags;
            DocumentTypes = documentTypes;
        }

        /// <summary> Unique document model name. </summary>
        public string ModelId { get; }
        /// <summary> Document model description. </summary>
        public string Description { get; }
        /// <summary> List of key-value tag attributes associated with the document model. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
