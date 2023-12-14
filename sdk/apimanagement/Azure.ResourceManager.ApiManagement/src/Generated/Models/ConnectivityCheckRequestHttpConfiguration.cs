// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Configuration for HTTP or HTTPS requests. </summary>
    public partial class ConnectivityCheckRequestHttpConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="ConnectivityCheckRequestHttpConfiguration"/>. </summary>
        public ConnectivityCheckRequestHttpConfiguration()
        {
            ValidStatusCodes = new ChangeTrackingList<long>();
            Headers = new ChangeTrackingList<HttpHeaderConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="ConnectivityCheckRequestHttpConfiguration"/>. </summary>
        /// <param name="method"> The HTTP method to be used. </param>
        /// <param name="validStatusCodes"> List of HTTP status codes considered valid for the request response. </param>
        /// <param name="headers"> List of headers to be included in the request. </param>
        internal ConnectivityCheckRequestHttpConfiguration(HttpMethodConfiguration? method, IList<long> validStatusCodes, IList<HttpHeaderConfiguration> headers)
        {
            Method = method;
            ValidStatusCodes = validStatusCodes;
            Headers = headers;
        }

        /// <summary> The HTTP method to be used. </summary>
        public HttpMethodConfiguration? Method { get; set; }
        /// <summary> List of HTTP status codes considered valid for the request response. </summary>
        public IList<long> ValidStatusCodes { get; }
        /// <summary> List of headers to be included in the request. </summary>
        public IList<HttpHeaderConfiguration> Headers { get; }
    }
}
