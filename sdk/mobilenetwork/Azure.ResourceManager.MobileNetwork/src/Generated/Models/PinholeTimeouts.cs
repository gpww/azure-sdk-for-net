// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Expiry times of inactive NAPT pinholes, in seconds. All timers must be at least 1 second. </summary>
    public partial class PinholeTimeouts
    {
        /// <summary> Initializes a new instance of <see cref="PinholeTimeouts"/>. </summary>
        public PinholeTimeouts()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PinholeTimeouts"/>. </summary>
        /// <param name="tcp"> Pinhole timeout for TCP pinholes in seconds. Default for TCP is 3 minutes. </param>
        /// <param name="udp"> Pinhole timeout for UDP pinholes in seconds. Default for UDP is 30 seconds. </param>
        /// <param name="icmp"> Pinhole timeout for ICMP pinholes in seconds. Default for ICMP Echo is 30 seconds. </param>
        internal PinholeTimeouts(int? tcp, int? udp, int? icmp)
        {
            Tcp = tcp;
            Udp = udp;
            Icmp = icmp;
        }

        /// <summary> Pinhole timeout for TCP pinholes in seconds. Default for TCP is 3 minutes. </summary>
        public int? Tcp { get; set; }
        /// <summary> Pinhole timeout for UDP pinholes in seconds. Default for UDP is 30 seconds. </summary>
        public int? Udp { get; set; }
        /// <summary> Pinhole timeout for ICMP pinholes in seconds. Default for ICMP Echo is 30 seconds. </summary>
        public int? Icmp { get; set; }
    }
}
