// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Monitor.Query.Models
{
    /// <summary> Represents a metric metadata value. </summary>
    internal partial class MetadataValue
    {
        /// <summary> Initializes a new instance of <see cref="MetadataValue"/>. </summary>
        internal MetadataValue()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MetadataValue"/>. </summary>
        /// <param name="name"> The name of the metadata. </param>
        /// <param name="value"> The value of the metadata. </param>
        internal MetadataValue(LocalizableString name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary> The name of the metadata. </summary>
        public LocalizableString Name { get; }
        /// <summary> The value of the metadata. </summary>
        public string Value { get; }
    }
}
