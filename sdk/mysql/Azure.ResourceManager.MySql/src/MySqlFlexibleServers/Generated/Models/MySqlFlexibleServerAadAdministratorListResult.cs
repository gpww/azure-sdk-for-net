// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MySql.FlexibleServers;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> A List of azure ad administrators. </summary>
    internal partial class MySqlFlexibleServerAadAdministratorListResult
    {
        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerAadAdministratorListResult"/>. </summary>
        internal MySqlFlexibleServerAadAdministratorListResult()
        {
            Value = new ChangeTrackingList<MySqlFlexibleServerAadAdministratorData>();
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerAadAdministratorListResult"/>. </summary>
        /// <param name="value"> The list of azure ad administrator of a server. </param>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        internal MySqlFlexibleServerAadAdministratorListResult(IReadOnlyList<MySqlFlexibleServerAadAdministratorData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of azure ad administrator of a server. </summary>
        public IReadOnlyList<MySqlFlexibleServerAadAdministratorData> Value { get; }
        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
    }
}
