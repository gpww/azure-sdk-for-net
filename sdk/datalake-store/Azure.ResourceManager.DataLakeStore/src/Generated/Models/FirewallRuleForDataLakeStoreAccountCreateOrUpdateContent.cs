// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> The parameters used to create a new firewall rule while creating a new Data Lake Store account. </summary>
    public partial class FirewallRuleForDataLakeStoreAccountCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="FirewallRuleForDataLakeStoreAccountCreateOrUpdateContent"/>. </summary>
        /// <param name="name"> The unique name of the firewall rule to create. </param>
        /// <param name="startIPAddress"> The start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. </param>
        /// <param name="endIPAddress"> The end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="startIPAddress"/> or <paramref name="endIPAddress"/> is null. </exception>
        public FirewallRuleForDataLakeStoreAccountCreateOrUpdateContent(string name, IPAddress startIPAddress, IPAddress endIPAddress)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(startIPAddress, nameof(startIPAddress));
            Argument.AssertNotNull(endIPAddress, nameof(endIPAddress));

            Name = name;
            StartIPAddress = startIPAddress;
            EndIPAddress = endIPAddress;
        }

        /// <summary> The unique name of the firewall rule to create. </summary>
        public string Name { get; }
        /// <summary> The start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. </summary>
        public IPAddress StartIPAddress { get; }
        /// <summary> The end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol. </summary>
        public IPAddress EndIPAddress { get; }
    }
}
