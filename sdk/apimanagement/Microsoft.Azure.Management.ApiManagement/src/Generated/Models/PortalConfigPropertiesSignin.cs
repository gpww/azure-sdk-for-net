// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PortalConfigPropertiesSignin
    {
        /// <summary>
        /// Initializes a new instance of the PortalConfigPropertiesSignin
        /// class.
        /// </summary>
        public PortalConfigPropertiesSignin()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PortalConfigPropertiesSignin
        /// class.
        /// </summary>
        /// <param name="require">Redirect anonymous users to the sign-in
        /// page.</param>
        public PortalConfigPropertiesSignin(bool? require = default(bool?))
        {
            Require = require;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets redirect anonymous users to the sign-in page.
        /// </summary>
        [JsonProperty(PropertyName = "require")]
        public bool? Require { get; set; }

    }
}
