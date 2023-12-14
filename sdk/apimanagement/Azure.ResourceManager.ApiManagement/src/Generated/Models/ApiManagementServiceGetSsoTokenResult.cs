// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The response of the GetSsoToken operation. </summary>
    public partial class ApiManagementServiceGetSsoTokenResult
    {
        /// <summary> Initializes a new instance of <see cref="ApiManagementServiceGetSsoTokenResult"/>. </summary>
        internal ApiManagementServiceGetSsoTokenResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementServiceGetSsoTokenResult"/>. </summary>
        /// <param name="redirectUri"> Redirect URL to the Publisher Portal containing the SSO token. </param>
        internal ApiManagementServiceGetSsoTokenResult(Uri redirectUri)
        {
            RedirectUri = redirectUri;
        }

        /// <summary> Redirect URL to the Publisher Portal containing the SSO token. </summary>
        public Uri RedirectUri { get; }
    }
}
