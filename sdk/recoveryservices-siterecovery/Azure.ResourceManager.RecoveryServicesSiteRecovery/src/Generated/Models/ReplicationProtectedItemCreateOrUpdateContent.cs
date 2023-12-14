// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Enable protection input. </summary>
    public partial class ReplicationProtectedItemCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="ReplicationProtectedItemCreateOrUpdateContent"/>. </summary>
        public ReplicationProtectedItemCreateOrUpdateContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReplicationProtectedItemCreateOrUpdateContent"/>. </summary>
        /// <param name="properties"> Enable protection input properties. </param>
        internal ReplicationProtectedItemCreateOrUpdateContent(EnableProtectionProperties properties)
        {
            Properties = properties;
        }

        /// <summary> Enable protection input properties. </summary>
        public EnableProtectionProperties Properties { get; set; }
    }
}
