// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> A secret. </summary>
    public partial class DevTestLabSecretPatch : DevTestLabResourcePatch
    {
        /// <summary> Initializes a new instance of <see cref="DevTestLabSecretPatch"/>. </summary>
        public DevTestLabSecretPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabSecretPatch"/>. </summary>
        /// <param name="tags"> The tags of the resource. </param>
        internal DevTestLabSecretPatch(IDictionary<string, string> tags) : base(tags)
        {
        }
    }
}
