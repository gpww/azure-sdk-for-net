// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The DocumentWarning. </summary>
    internal partial class DocumentWarning
    {
        /// <summary> Initializes a new instance of <see cref="DocumentWarning"/>. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Warning message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        public DocumentWarning(WarningCodeValue code, string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            Code = code;
            Message = message;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentWarning"/>. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Warning message. </param>
        /// <param name="targetRef"> A JSON pointer reference indicating the target object. </param>
        internal DocumentWarning(WarningCodeValue code, string message, string targetRef)
        {
            Code = code;
            Message = message;
            TargetRef = targetRef;
        }

        /// <summary> Error code. </summary>
        public WarningCodeValue Code { get; set; }
        /// <summary> Warning message. </summary>
        public string Message { get; set; }
        /// <summary> A JSON pointer reference indicating the target object. </summary>
        public string TargetRef { get; set; }
    }
}
