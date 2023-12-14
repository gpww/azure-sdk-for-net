// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Check Domain availability parameter. </summary>
    public partial class CognitiveServicesDomainAvailabilityContent
    {
        /// <summary> Initializes a new instance of <see cref="CognitiveServicesDomainAvailabilityContent"/>. </summary>
        /// <param name="subdomainName"> The subdomain name to use. </param>
        /// <param name="resourceType"> The Type of the resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subdomainName"/> is null. </exception>
        public CognitiveServicesDomainAvailabilityContent(string subdomainName, ResourceType resourceType)
        {
            Argument.AssertNotNull(subdomainName, nameof(subdomainName));

            SubdomainName = subdomainName;
            ResourceType = resourceType;
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesDomainAvailabilityContent"/>. </summary>
        /// <param name="subdomainName"> The subdomain name to use. </param>
        /// <param name="resourceType"> The Type of the resource. </param>
        /// <param name="kind"> The Kind of the resource. </param>
        internal CognitiveServicesDomainAvailabilityContent(string subdomainName, ResourceType resourceType, string kind)
        {
            SubdomainName = subdomainName;
            ResourceType = resourceType;
            Kind = kind;
        }

        /// <summary> The subdomain name to use. </summary>
        public string SubdomainName { get; }
        /// <summary> The Type of the resource. </summary>
        public ResourceType ResourceType { get; }
        /// <summary> The Kind of the resource. </summary>
        public string Kind { get; set; }
    }
}
