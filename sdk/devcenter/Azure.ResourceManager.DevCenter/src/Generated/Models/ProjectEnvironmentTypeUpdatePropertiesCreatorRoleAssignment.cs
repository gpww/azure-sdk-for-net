// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> The role definition assigned to the environment creator on backing resources. </summary>
    internal partial class ProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignment
    {
        /// <summary> Initializes a new instance of ProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignment. </summary>
        public ProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignment()
        {
            Roles = new ChangeTrackingDictionary<string, DevCenterEnvironmentRole>();
        }

        /// <summary> Initializes a new instance of ProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignment. </summary>
        /// <param name="roles"> A map of roles to assign to the environment creator. </param>
        internal ProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignment(IDictionary<string, DevCenterEnvironmentRole> roles)
        {
            Roles = roles;
        }

        /// <summary> A map of roles to assign to the environment creator. </summary>
        public IDictionary<string, DevCenterEnvironmentRole> Roles { get; }
    }
}
