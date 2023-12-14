// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> A set of properties that can be defined in the context of a specific item type. Each type may have its own properties. </summary>
    internal partial class ApplicationInsightsComponentAnalyticsItemProperties
    {
        /// <summary> Initializes a new instance of <see cref="ApplicationInsightsComponentAnalyticsItemProperties"/>. </summary>
        public ApplicationInsightsComponentAnalyticsItemProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationInsightsComponentAnalyticsItemProperties"/>. </summary>
        /// <param name="functionAlias"> A function alias, used when the type of the item is Function. </param>
        internal ApplicationInsightsComponentAnalyticsItemProperties(string functionAlias)
        {
            FunctionAlias = functionAlias;
        }

        /// <summary> A function alias, used when the type of the item is Function. </summary>
        public string FunctionAlias { get; set; }
    }
}
