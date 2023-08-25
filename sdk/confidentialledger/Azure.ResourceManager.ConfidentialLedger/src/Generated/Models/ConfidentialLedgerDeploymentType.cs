// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    /// <summary> Object representing DeploymentType for Managed CCF. </summary>
    public partial class ConfidentialLedgerDeploymentType
    {
        /// <summary> Initializes a new instance of ConfidentialLedgerDeploymentType. </summary>
        public ConfidentialLedgerDeploymentType()
        {
        }

        /// <summary> Initializes a new instance of ConfidentialLedgerDeploymentType. </summary>
        /// <param name="languageRuntime"> Unique name for the Managed CCF. </param>
        /// <param name="appSourceUri"> Source Uri containing ManagedCCF code. </param>
        internal ConfidentialLedgerDeploymentType(ConfidentialLedgerLanguageRuntime? languageRuntime, Uri appSourceUri)
        {
            LanguageRuntime = languageRuntime;
            AppSourceUri = appSourceUri;
        }

        /// <summary> Unique name for the Managed CCF. </summary>
        public ConfidentialLedgerLanguageRuntime? LanguageRuntime { get; set; }
        /// <summary> Source Uri containing ManagedCCF code. </summary>
        public Uri AppSourceUri { get; set; }
    }
}
