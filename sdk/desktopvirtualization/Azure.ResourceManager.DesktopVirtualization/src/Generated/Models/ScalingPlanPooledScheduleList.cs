// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> List of ScalingPlanPooledSchedule definitions. </summary>
    internal partial class ScalingPlanPooledScheduleList
    {
        /// <summary> Initializes a new instance of ScalingPlanPooledScheduleList. </summary>
        internal ScalingPlanPooledScheduleList()
        {
            Value = new ChangeTrackingList<ScalingPlanPooledScheduleData>();
        }

        /// <summary> Initializes a new instance of ScalingPlanPooledScheduleList. </summary>
        /// <param name="value"> List of ScalingPlanPooledSchedule definitions. </param>
        /// <param name="nextLink"> Link to the next page of results. </param>
        internal ScalingPlanPooledScheduleList(IReadOnlyList<ScalingPlanPooledScheduleData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of ScalingPlanPooledSchedule definitions. </summary>
        public IReadOnlyList<ScalingPlanPooledScheduleData> Value { get; }
        /// <summary> Link to the next page of results. </summary>
        public string NextLink { get; }
    }
}
