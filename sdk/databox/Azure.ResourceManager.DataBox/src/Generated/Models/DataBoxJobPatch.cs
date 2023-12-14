// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The JobResourceUpdateParameter. </summary>
    public partial class DataBoxJobPatch
    {
        /// <summary> Initializes a new instance of <see cref="DataBoxJobPatch"/>. </summary>
        public DataBoxJobPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxJobPatch"/>. </summary>
        /// <param name="tags"> The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). </param>
        /// <param name="identity"> Msi identity of the resource. </param>
        /// <param name="details"> Details of a job to be updated. </param>
        internal DataBoxJobPatch(IDictionary<string, string> tags, ManagedServiceIdentity identity, UpdateJobDetails details)
        {
            Tags = tags;
            Identity = identity;
            Details = details;
        }

        /// <summary> The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Msi identity of the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Details of a job to be updated. </summary>
        public UpdateJobDetails Details { get; set; }
    }
}
