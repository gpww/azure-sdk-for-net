// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Purview Configuration. </summary>
    public partial class PurviewConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="PurviewConfiguration"/>. </summary>
        public PurviewConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PurviewConfiguration"/>. </summary>
        /// <param name="purviewResourceId"> Purview Resource ID. </param>
        internal PurviewConfiguration(string purviewResourceId)
        {
            PurviewResourceId = purviewResourceId;
        }

        /// <summary> Purview Resource ID. </summary>
        public string PurviewResourceId { get; set; }
    }
}
