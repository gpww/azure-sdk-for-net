// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Instance view status. </summary>
    public partial class ResourceInstanceViewStatus
    {
        /// <summary> Initializes a new instance of <see cref="ResourceInstanceViewStatus"/>. </summary>
        internal ResourceInstanceViewStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceInstanceViewStatus"/>. </summary>
        /// <param name="code"> The status code. </param>
        /// <param name="displayStatus"> The short localizable label for the status. </param>
        /// <param name="message"> The detailed status message, including for alerts and error messages. </param>
        /// <param name="time"> The time of the status. </param>
        /// <param name="level"> The level code. </param>
        internal ResourceInstanceViewStatus(string code, string displayStatus, string message, DateTimeOffset? time, ComputeStatusLevelType? level)
        {
            Code = code;
            DisplayStatus = displayStatus;
            Message = message;
            Time = time;
            Level = level;
        }

        /// <summary> The status code. </summary>
        public string Code { get; }
        /// <summary> The short localizable label for the status. </summary>
        public string DisplayStatus { get; }
        /// <summary> The detailed status message, including for alerts and error messages. </summary>
        public string Message { get; }
        /// <summary> The time of the status. </summary>
        public DateTimeOffset? Time { get; }
        /// <summary> The level code. </summary>
        public ComputeStatusLevelType? Level { get; }
    }
}
