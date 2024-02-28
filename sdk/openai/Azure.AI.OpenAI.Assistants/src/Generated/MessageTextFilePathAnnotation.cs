// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> A citation within the message that points to a file located at a specific path. </summary>
    public partial class MessageTextFilePathAnnotation : MessageTextAnnotation
    {
        /// <summary> Initializes a new instance of <see cref="MessageTextFilePathAnnotation"/>. </summary>
        /// <param name="text"> The textual content associated with this text annotation item. </param>
        /// <param name="startIndex"> The first text index associated with this text annotation. </param>
        /// <param name="endIndex"> The last text index associated with this text annotation. </param>
        /// <param name="internalDetails"> A URL for the file that's generated when the assistant used the code_interpreter tool to generate a file. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> or <paramref name="internalDetails"/> is null. </exception>
        internal MessageTextFilePathAnnotation(string text, int startIndex, int endIndex, InternalMessageTextFilePathDetails internalDetails) : base(text, startIndex, endIndex)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }
            if (internalDetails == null)
            {
                throw new ArgumentNullException(nameof(internalDetails));
            }

            Type = "file_path";
            InternalDetails = internalDetails;
        }

        /// <summary> Initializes a new instance of <see cref="MessageTextFilePathAnnotation"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="text"> The textual content associated with this text annotation item. </param>
        /// <param name="startIndex"> The first text index associated with this text annotation. </param>
        /// <param name="endIndex"> The last text index associated with this text annotation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="internalDetails"> A URL for the file that's generated when the assistant used the code_interpreter tool to generate a file. </param>
        internal MessageTextFilePathAnnotation(string type, string text, int startIndex, int endIndex, IDictionary<string, BinaryData> serializedAdditionalRawData, InternalMessageTextFilePathDetails internalDetails) : base(type, text, startIndex, endIndex, serializedAdditionalRawData)
        {
            InternalDetails = internalDetails;
        }

        /// <summary> Initializes a new instance of <see cref="MessageTextFilePathAnnotation"/> for deserialization. </summary>
        internal MessageTextFilePathAnnotation()
        {
        }
    }
}
