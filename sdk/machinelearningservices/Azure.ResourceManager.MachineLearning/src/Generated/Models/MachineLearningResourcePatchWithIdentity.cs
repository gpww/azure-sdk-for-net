// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Strictly used in update requests. </summary>
    public partial class MachineLearningResourcePatchWithIdentity : MachineLearningResourcePatch
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningResourcePatchWithIdentity"/>. </summary>
        public MachineLearningResourcePatchWithIdentity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningResourcePatchWithIdentity"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="identity"> Managed service identity (system assigned and/or user assigned identities). </param>
        internal MachineLearningResourcePatchWithIdentity(IDictionary<string, string> tags, MachineLearningPartialManagedServiceIdentity identity) : base(tags)
        {
            Identity = identity;
        }

        /// <summary> Managed service identity (system assigned and/or user assigned identities). </summary>
        public MachineLearningPartialManagedServiceIdentity Identity { get; set; }
    }
}
