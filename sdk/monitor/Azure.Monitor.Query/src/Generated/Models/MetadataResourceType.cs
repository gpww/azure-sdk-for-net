// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> Metadata about types of Azure resources, containing relevant tables, functions, etc. </summary>
    internal partial class MetadataResourceType
    {
        /// <summary> Initializes a new instance of <see cref="MetadataResourceType"/>. </summary>
        /// <param name="id"> The ID of the resource-type. </param>
        /// <param name="type"> The type of the resource-type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="type"/> is null. </exception>
        internal MetadataResourceType(string id, string type)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(type, nameof(type));

            Id = id;
            Type = type;
            Labels = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MetadataResourceType"/>. </summary>
        /// <param name="id"> The ID of the resource-type. </param>
        /// <param name="type"> The type of the resource-type. </param>
        /// <param name="displayName"> The display name of the resource-type. </param>
        /// <param name="description"> The description of the resource-type. </param>
        /// <param name="labels"> The user-defined labels of the resource-type. </param>
        /// <param name="tags"> The tags associated with the resource-type. </param>
        /// <param name="properties"> The properties of the resource-type. </param>
        /// <param name="related"> The related metadata items for the resource-type. </param>
        internal MetadataResourceType(string id, string type, string displayName, string description, IReadOnlyList<string> labels, object tags, object properties, MetadataResourceTypeRelated related)
        {
            Id = id;
            Type = type;
            DisplayName = displayName;
            Description = description;
            Labels = labels;
            Tags = tags;
            Properties = properties;
            Related = related;
        }

        /// <summary> The ID of the resource-type. </summary>
        public string Id { get; }
        /// <summary> The type of the resource-type. </summary>
        public string Type { get; }
        /// <summary> The display name of the resource-type. </summary>
        public string DisplayName { get; }
        /// <summary> The description of the resource-type. </summary>
        public string Description { get; }
        /// <summary> The user-defined labels of the resource-type. </summary>
        public IReadOnlyList<string> Labels { get; }
        /// <summary> The tags associated with the resource-type. </summary>
        public object Tags { get; }
        /// <summary> The properties of the resource-type. </summary>
        public object Properties { get; }
        /// <summary> The related metadata items for the resource-type. </summary>
        public MetadataResourceTypeRelated Related { get; }
    }
}
