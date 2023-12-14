// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> HTTP Proxy configuration for the VM. </summary>
    internal partial class HttpProxyConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="HttpProxyConfiguration"/>. </summary>
        public HttpProxyConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HttpProxyConfiguration"/>. </summary>
        /// <param name="httpsProxy"> Gets or sets httpsProxy url. </param>
        internal HttpProxyConfiguration(string httpsProxy)
        {
            HttpsProxy = httpsProxy;
        }

        /// <summary> Gets or sets httpsProxy url. </summary>
        public string HttpsProxy { get; set; }
    }
}
