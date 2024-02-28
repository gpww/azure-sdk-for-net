// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Get Operation response object. </summary>
    public partial class DocumentModelComposeOperationDetails : OperationDetails
    {
        /// <summary> Initializes a new instance of <see cref="DocumentModelComposeOperationDetails"/>. </summary>
        /// <param name="operationId"> Operation ID. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="createdDateTime"> Date and time (UTC) when the operation was created. </param>
        /// <param name="lastUpdatedDateTime"> Date and time (UTC) when the status was last updated. </param>
        /// <param name="resourceLocation"> URL of the resource targeted by this operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> or <paramref name="resourceLocation"/> is null. </exception>
        internal DocumentModelComposeOperationDetails(string operationId, OperationStatus status, DateTimeOffset createdDateTime, DateTimeOffset lastUpdatedDateTime, Uri resourceLocation) : base(operationId, status, createdDateTime, lastUpdatedDateTime, resourceLocation)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }
            if (resourceLocation == null)
            {
                throw new ArgumentNullException(nameof(resourceLocation));
            }

            Kind = OperationKind.DocumentModelCompose;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentModelComposeOperationDetails"/>. </summary>
        /// <param name="operationId"> Operation ID. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="percentCompleted"> Operation progress (0-100). </param>
        /// <param name="createdDateTime"> Date and time (UTC) when the operation was created. </param>
        /// <param name="lastUpdatedDateTime"> Date and time (UTC) when the status was last updated. </param>
        /// <param name="kind"> Type of operation. </param>
        /// <param name="resourceLocation"> URL of the resource targeted by this operation. </param>
        /// <param name="apiVersion"> API version used to create this operation. </param>
        /// <param name="tags"> List of key-value tag attributes associated with the document model. </param>
        /// <param name="error"> Encountered error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="result"> Operation result upon success. </param>
        internal DocumentModelComposeOperationDetails(string operationId, OperationStatus status, int? percentCompleted, DateTimeOffset createdDateTime, DateTimeOffset lastUpdatedDateTime, OperationKind kind, Uri resourceLocation, string apiVersion, IReadOnlyDictionary<string, string> tags, DocumentIntelligenceError error, IDictionary<string, BinaryData> serializedAdditionalRawData, DocumentModelDetails result) : base(operationId, status, percentCompleted, createdDateTime, lastUpdatedDateTime, kind, resourceLocation, apiVersion, tags, error, serializedAdditionalRawData)
        {
            Result = result;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentModelComposeOperationDetails"/> for deserialization. </summary>
        internal DocumentModelComposeOperationDetails()
        {
        }

        /// <summary> Operation result upon success. </summary>
        public DocumentModelDetails Result { get; }
    }
}
