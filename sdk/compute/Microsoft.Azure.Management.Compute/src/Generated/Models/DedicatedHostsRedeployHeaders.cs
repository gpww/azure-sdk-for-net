// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for Redeploy operation.
    /// </summary>
    public partial class DedicatedHostsRedeployHeaders
    {
        /// <summary>
        /// Initializes a new instance of the DedicatedHostsRedeployHeaders
        /// class.
        /// </summary>
        public DedicatedHostsRedeployHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DedicatedHostsRedeployHeaders
        /// class.
        /// </summary>
        public DedicatedHostsRedeployHeaders(string location = default(string))
        {
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

    }
}
