// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Parameters supplied to Create/Update Tag operations. </summary>
    public partial class ApiManagementTagCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="ApiManagementTagCreateOrUpdateContent"/>. </summary>
        public ApiManagementTagCreateOrUpdateContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementTagCreateOrUpdateContent"/>. </summary>
        /// <param name="displayName"> Tag name. </param>
        internal ApiManagementTagCreateOrUpdateContent(string displayName)
        {
            DisplayName = displayName;
        }

        /// <summary> Tag name. </summary>
        public string DisplayName { get; set; }
    }
}
