// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Search.Documents.Indexes.Models;

namespace Azure.Search.Documents.Models
{
    /// <summary> Unknown version of CognitiveServicesAccount. </summary>
    internal partial class UnknownCognitiveServicesAccount : CognitiveServicesAccount
    {
        /// <summary> Initializes a new instance of <see cref="UnknownCognitiveServicesAccount"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of Azure AI service resource attached to a skillset. </param>
        /// <param name="description"> Description of the Azure AI service resource attached to a skillset. </param>
        internal UnknownCognitiveServicesAccount(string oDataType, string description) : base(oDataType, description)
        {
            ODataType = oDataType ?? "Unknown";
        }
    }
}
