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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A UEFI key signature.
    /// </summary>
    public partial class UefiKey
    {
        /// <summary>
        /// Initializes a new instance of the UefiKey class.
        /// </summary>
        public UefiKey()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UefiKey class.
        /// </summary>
        /// <param name="type">The type of key signature. Possible values
        /// include: 'sha256', 'x509'</param>
        /// <param name="value">The value of the key signature.</param>
        public UefiKey(string type = default(string), IList<string> value = default(IList<string>))
        {
            Type = type;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of key signature. Possible values include:
        /// 'sha256', 'x509'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the value of the key signature.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<string> Value { get; set; }

    }
}
