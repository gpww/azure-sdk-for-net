// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The EntityLinkingTaskResult. </summary>
    internal partial class EntityLinkingTaskResult
    {
        /// <summary> Initializes a new instance of <see cref="EntityLinkingTaskResult"/>. </summary>
        internal EntityLinkingTaskResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EntityLinkingTaskResult"/>. </summary>
        /// <param name="results"></param>
        internal EntityLinkingTaskResult(EntityLinkingResult results)
        {
            Results = results;
        }

        /// <summary> Gets the results. </summary>
        public EntityLinkingResult Results { get; }
    }
}
