// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Communication.RouterJobDeleted event. </summary>
    public partial class AcsRouterJobDeletedEventData : AcsRouterJobEventData
    {
        /// <summary> Initializes a new instance of <see cref="AcsRouterJobDeletedEventData"/>. </summary>
        internal AcsRouterJobDeletedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AcsRouterJobDeletedEventData"/>. </summary>
        /// <param name="jobId"> Router Event Job ID. </param>
        /// <param name="channelReference"> Router Event Channel Reference. </param>
        /// <param name="channelId"> Router Event Channel ID. </param>
        /// <param name="queueId"> Router Job events Queue Id. </param>
        /// <param name="labels"> Router Job events Labels. </param>
        /// <param name="tags"> Router Jobs events Tags. </param>
        internal AcsRouterJobDeletedEventData(string jobId, string channelReference, string channelId, string queueId, IReadOnlyDictionary<string, string> labels, IReadOnlyDictionary<string, string> tags) : base(jobId, channelReference, channelId, queueId, labels, tags)
        {
        }
    }
}
