// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> HDInsight compute properties. </summary>
    public partial class MachineLearningHDInsightProperties
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningHDInsightProperties"/>. </summary>
        public MachineLearningHDInsightProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningHDInsightProperties"/>. </summary>
        /// <param name="sshPort"> Port open for ssh connections on the master node of the cluster. </param>
        /// <param name="address"> Public IP address of the master node of the cluster. </param>
        /// <param name="administratorAccount"> Admin credentials for master node of the cluster. </param>
        internal MachineLearningHDInsightProperties(int? sshPort, IPAddress address, MachineLearningVmSshCredentials administratorAccount)
        {
            SshPort = sshPort;
            Address = address;
            AdministratorAccount = administratorAccount;
        }

        /// <summary> Port open for ssh connections on the master node of the cluster. </summary>
        public int? SshPort { get; set; }
        /// <summary> Public IP address of the master node of the cluster. </summary>
        public IPAddress Address { get; set; }
        /// <summary> Admin credentials for master node of the cluster. </summary>
        public MachineLearningVmSshCredentials AdministratorAccount { get; set; }
    }
}
