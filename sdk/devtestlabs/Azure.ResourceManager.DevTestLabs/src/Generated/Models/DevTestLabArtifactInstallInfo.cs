// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Properties of an artifact. </summary>
    public partial class DevTestLabArtifactInstallInfo
    {
        /// <summary> Initializes a new instance of DevTestLabArtifactInstallInfo. </summary>
        public DevTestLabArtifactInstallInfo()
        {
            Parameters = new ChangeTrackingList<DevTestLabArtifactParameter>();
        }

        /// <summary> Initializes a new instance of DevTestLabArtifactInstallInfo. </summary>
        /// <param name="artifactId"> The artifact's identifier. </param>
        /// <param name="artifactTitle"> The artifact's title. </param>
        /// <param name="parameters"> The parameters of the artifact. </param>
        /// <param name="status"> The status of the artifact. </param>
        /// <param name="deploymentStatusMessage"> The status message from the deployment. </param>
        /// <param name="vmExtensionStatusMessage"> The status message from the virtual machine extension. </param>
        /// <param name="installOn"> The time that the artifact starts to install on the virtual machine. </param>
        internal DevTestLabArtifactInstallInfo(string artifactId, string artifactTitle, IList<DevTestLabArtifactParameter> parameters, string status, string deploymentStatusMessage, string vmExtensionStatusMessage, DateTimeOffset? installOn)
        {
            ArtifactId = artifactId;
            ArtifactTitle = artifactTitle;
            Parameters = parameters;
            Status = status;
            DeploymentStatusMessage = deploymentStatusMessage;
            VmExtensionStatusMessage = vmExtensionStatusMessage;
            InstallOn = installOn;
        }

        /// <summary> The artifact's identifier. </summary>
        public string ArtifactId { get; set; }
        /// <summary> The artifact's title. </summary>
        public string ArtifactTitle { get; set; }
        /// <summary> The parameters of the artifact. </summary>
        public IList<DevTestLabArtifactParameter> Parameters { get; }
        /// <summary> The status of the artifact. </summary>
        public string Status { get; set; }
        /// <summary> The status message from the deployment. </summary>
        public string DeploymentStatusMessage { get; set; }
        /// <summary> The status message from the virtual machine extension. </summary>
        public string VmExtensionStatusMessage { get; set; }
        /// <summary> The time that the artifact starts to install on the virtual machine. </summary>
        public DateTimeOffset? InstallOn { get; set; }
    }
}
