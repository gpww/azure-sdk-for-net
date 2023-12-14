// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Scheduling properties of a job. </summary>
    public partial class SqlServerJobSchedule
    {
        /// <summary> Initializes a new instance of <see cref="SqlServerJobSchedule"/>. </summary>
        public SqlServerJobSchedule()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlServerJobSchedule"/>. </summary>
        /// <param name="startOn"> Schedule start time. </param>
        /// <param name="endOn"> Schedule end time. </param>
        /// <param name="scheduleType"> Schedule interval type. </param>
        /// <param name="isEnabled"> Whether or not the schedule is enabled. </param>
        /// <param name="interval"> Value of the schedule's recurring interval, if the ScheduleType is recurring. ISO8601 duration format. </param>
        internal SqlServerJobSchedule(DateTimeOffset? startOn, DateTimeOffset? endOn, SqlServerJobScheduleType? scheduleType, bool? isEnabled, TimeSpan? interval)
        {
            StartOn = startOn;
            EndOn = endOn;
            ScheduleType = scheduleType;
            IsEnabled = isEnabled;
            Interval = interval;
        }

        /// <summary> Schedule start time. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> Schedule end time. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> Schedule interval type. </summary>
        public SqlServerJobScheduleType? ScheduleType { get; set; }
        /// <summary> Whether or not the schedule is enabled. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Value of the schedule's recurring interval, if the ScheduleType is recurring. ISO8601 duration format. </summary>
        public TimeSpan? Interval { get; set; }
    }
}
