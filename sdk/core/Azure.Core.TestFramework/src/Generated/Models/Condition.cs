// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Core.TestFramework.Models
{
    /// <summary> Condition to apply for the sanitization or transform. If the condition is not met, sanitization/transform is not performed. </summary>
    public partial class Condition
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="Condition"/>. </summary>
        public Condition()
        {
        }

        /// <summary> Initializes a new instance of <see cref="Condition"/>. </summary>
        /// <param name="uriRegex"></param>
        /// <param name="responseHeader"> Header condition to apply. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Condition(string uriRegex, HeaderCondition responseHeader, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UriRegex = uriRegex;
            ResponseHeader = responseHeader;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the uri regex. </summary>
        public string UriRegex { get; set; }
        /// <summary> Header condition to apply. </summary>
        public HeaderCondition ResponseHeader { get; set; }
    }
}
