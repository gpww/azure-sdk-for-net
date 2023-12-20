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
    /// Specifies ProxyAgent settings while creating the virtual machine.
    /// Minimum api-version: 2023-09-01.
    /// </summary>
    public partial class ProxyAgentSettings
    {
        /// <summary>
        /// Initializes a new instance of the ProxyAgentSettings class.
        /// </summary>
        public ProxyAgentSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProxyAgentSettings class.
        /// </summary>
        /// <param name="enabled">Specifies whether ProxyAgent feature should
        /// be enabled on the virtual machine or virtual machine scale
        /// set.</param>
        /// <param name="mode">Specifies the mode that ProxyAgent will execute
        /// on if the feature is enabled. ProxyAgent will start to audit or
        /// monitor but not enforce access control over requests to host
        /// endpoints in Audit mode, while in Enforce mode it will enforce
        /// access control. The default value is Enforce mode. Possible values
        /// include: 'Audit', 'Enforce'</param>
        /// <param name="keyIncarnationId">Increase the value of this property
        /// allows user to reset the key used for securing communication
        /// channel between guest and host.</param>
        public ProxyAgentSettings(bool? enabled = default(bool?), string mode = default(string), int? keyIncarnationId = default(int?))
        {
            Enabled = enabled;
            Mode = mode;
            KeyIncarnationId = keyIncarnationId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies whether ProxyAgent feature should be enabled
        /// on the virtual machine or virtual machine scale set.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets specifies the mode that ProxyAgent will execute on if
        /// the feature is enabled. ProxyAgent will start to audit or monitor
        /// but not enforce access control over requests to host endpoints in
        /// Audit mode, while in Enforce mode it will enforce access control.
        /// The default value is Enforce mode. Possible values include:
        /// 'Audit', 'Enforce'
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or sets increase the value of this property allows user to
        /// reset the key used for securing communication channel between guest
        /// and host.
        /// </summary>
        [JsonProperty(PropertyName = "keyIncarnationId")]
        public int? KeyIncarnationId { get; set; }

    }
}
