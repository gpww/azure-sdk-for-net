// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of common properties of cluster support events. </summary>
    public partial class ContainerServiceClusterSupportEventData
    {
        /// <summary> Initializes a new instance of ContainerServiceClusterSupportEventData. </summary>
        internal ContainerServiceClusterSupportEventData()
        {
        }

        /// <summary> Initializes a new instance of ContainerServiceClusterSupportEventData. </summary>
        /// <param name="kubernetesVersion"> The Kubernetes version of the ManagedCluster resource. </param>
        internal ContainerServiceClusterSupportEventData(string kubernetesVersion)
        {
            KubernetesVersion = kubernetesVersion;
        }

        /// <summary> The Kubernetes version of the ManagedCluster resource. </summary>
        public string KubernetesVersion { get; }
    }
}
