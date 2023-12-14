// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Read-only system metadata associated with a resource. </summary>
    public partial class SystemData
    {
        /// <summary> Initializes a new instance of <see cref="SystemData"/>. </summary>
        public SystemData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SystemData"/>. </summary>
        /// <param name="createdAt"> Date and time when this resource was first created. Value is represented in UTC according to the ISO8601 date format. </param>
        /// <param name="lastModifiedAt"> Date and time when this resource was last modified. Value is represented in UTC according to the ISO8601 date format. </param>
        internal SystemData(DateTimeOffset? createdAt, DateTimeOffset? lastModifiedAt)
        {
            CreatedAt = createdAt;
            LastModifiedAt = lastModifiedAt;
        }

        /// <summary> Date and time when this resource was first created. Value is represented in UTC according to the ISO8601 date format. </summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary> Date and time when this resource was last modified. Value is represented in UTC according to the ISO8601 date format. </summary>
        public DateTimeOffset? LastModifiedAt { get; set; }
    }
}
