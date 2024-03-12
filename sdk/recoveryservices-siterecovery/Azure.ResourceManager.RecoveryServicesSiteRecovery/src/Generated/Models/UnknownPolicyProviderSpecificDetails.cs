// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Unknown version of PolicyProviderSpecificDetails. </summary>
    internal partial class UnknownPolicyProviderSpecificDetails : PolicyProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of <see cref="UnknownPolicyProviderSpecificDetails"/>. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownPolicyProviderSpecificDetails(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            InstanceType = instanceType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownPolicyProviderSpecificDetails"/> for deserialization. </summary>
        internal UnknownPolicyProviderSpecificDetails()
        {
        }
    }
}
