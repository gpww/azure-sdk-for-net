// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Retrieves properties and media profiles of an ONVIF device. </summary>
    public partial class OnvifDeviceGetRequest : MethodRequest
    {
        /// <summary> Initializes a new instance of <see cref="OnvifDeviceGetRequest"/>. </summary>
        /// <param name="endpoint">
        /// Base class for endpoints.
        /// Please note <see cref="EndpointBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="TlsEndpoint"/> and <see cref="UnsecuredEndpoint"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public OnvifDeviceGetRequest(EndpointBase endpoint)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }

            Endpoint = endpoint;
            MethodName = "onvifDeviceGet";
        }

        /// <summary> Initializes a new instance of <see cref="OnvifDeviceGetRequest"/>. </summary>
        /// <param name="methodName"> Direct method method name. </param>
        /// <param name="apiVersion"> Video Analyzer API version. </param>
        /// <param name="endpoint">
        /// Base class for endpoints.
        /// Please note <see cref="EndpointBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="TlsEndpoint"/> and <see cref="UnsecuredEndpoint"/>.
        /// </param>
        internal OnvifDeviceGetRequest(string methodName, string apiVersion, EndpointBase endpoint) : base(methodName, apiVersion)
        {
            Endpoint = endpoint;
            MethodName = methodName ?? "onvifDeviceGet";
        }

        /// <summary>
        /// Base class for endpoints.
        /// Please note <see cref="EndpointBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="TlsEndpoint"/> and <see cref="UnsecuredEndpoint"/>.
        /// </summary>
        public EndpointBase Endpoint { get; set; }
    }
}
