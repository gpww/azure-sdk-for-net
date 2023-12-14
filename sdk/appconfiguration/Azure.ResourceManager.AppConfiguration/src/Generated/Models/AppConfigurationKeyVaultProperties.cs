// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppConfiguration.Models
{
    /// <summary> Settings concerning key vault encryption for a configuration store. </summary>
    public partial class AppConfigurationKeyVaultProperties
    {
        /// <summary> Initializes a new instance of <see cref="AppConfigurationKeyVaultProperties"/>. </summary>
        public AppConfigurationKeyVaultProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppConfigurationKeyVaultProperties"/>. </summary>
        /// <param name="keyIdentifier"> The URI of the key vault key used to encrypt data. </param>
        /// <param name="identityClientId"> The client id of the identity which will be used to access key vault. </param>
        internal AppConfigurationKeyVaultProperties(string keyIdentifier, string identityClientId)
        {
            KeyIdentifier = keyIdentifier;
            IdentityClientId = identityClientId;
        }

        /// <summary> The URI of the key vault key used to encrypt data. </summary>
        public string KeyIdentifier { get; set; }
        /// <summary> The client id of the identity which will be used to access key vault. </summary>
        public string IdentityClientId { get; set; }
    }
}
