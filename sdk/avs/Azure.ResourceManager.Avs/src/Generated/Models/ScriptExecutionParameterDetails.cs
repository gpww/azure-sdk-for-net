// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary>
    /// The arguments passed in to the execution
    /// Please note <see cref="ScriptExecutionParameterDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="PSCredentialExecutionParameterDetails"/>, <see cref="ScriptSecureStringExecutionParameterDetails"/> and <see cref="ScriptStringExecutionParameterDetails"/>.
    /// </summary>
    public abstract partial class ScriptExecutionParameterDetails
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ScriptExecutionParameterDetails"/>. </summary>
        /// <param name="name"> The parameter name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        protected ScriptExecutionParameterDetails(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="ScriptExecutionParameterDetails"/>. </summary>
        /// <param name="name"> The parameter name. </param>
        /// <param name="parameterType"> The type of execution parameter. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScriptExecutionParameterDetails(string name, ScriptExecutionParameterType parameterType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ParameterType = parameterType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ScriptExecutionParameterDetails"/> for deserialization. </summary>
        internal ScriptExecutionParameterDetails()
        {
        }

        /// <summary> The parameter name. </summary>
        public string Name { get; set; }
        /// <summary> The type of execution parameter. </summary>
        internal ScriptExecutionParameterType ParameterType { get; set; }
    }
}
