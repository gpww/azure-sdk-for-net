// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Core.TestFramework.Models
{
    /// <summary> The HeaderTransform. </summary>
    public partial class HeaderTransform
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HeaderTransform"/>. </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public HeaderTransform(string key, string value)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            Key = key;
            Value = value;
        }

        /// <summary> Initializes a new instance of <see cref="HeaderTransform"/>. </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="condition"> Condition to apply for the sanitization or transform. If the condition is not met, sanitization/transform is not performed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HeaderTransform(string key, string value, Condition condition, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Key = key;
            Value = value;
            Condition = condition;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="HeaderTransform"/> for deserialization. </summary>
        internal HeaderTransform()
        {
        }

        /// <summary> Gets the key. </summary>
        public string Key { get; }
        /// <summary> Gets the value. </summary>
        public string Value { get; }
        /// <summary> Condition to apply for the sanitization or transform. If the condition is not met, sanitization/transform is not performed. </summary>
        public Condition Condition { get; set; }
    }
}
