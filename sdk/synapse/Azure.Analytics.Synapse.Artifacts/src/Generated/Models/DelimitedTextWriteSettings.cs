// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Delimited text write settings. </summary>
    public partial class DelimitedTextWriteSettings : FormatWriteSettings
    {
        /// <summary> Initializes a new instance of <see cref="DelimitedTextWriteSettings"/>. </summary>
        /// <param name="fileExtension"> The file extension used to create the files. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileExtension"/> is null. </exception>
        public DelimitedTextWriteSettings(object fileExtension)
        {
            Argument.AssertNotNull(fileExtension, nameof(fileExtension));

            FileExtension = fileExtension;
            Type = "DelimitedTextWriteSettings";
        }

        /// <summary> Initializes a new instance of <see cref="DelimitedTextWriteSettings"/>. </summary>
        /// <param name="type"> The write setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="quoteAllText"> Indicates whether string values should always be enclosed with quotes. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="fileExtension"> The file extension used to create the files. Type: string (or Expression with resultType string). </param>
        /// <param name="maxRowsPerFile"> Limit the written file's row count to be smaller than or equal to the specified count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="fileNamePrefix"> Specifies the file name pattern &lt;fileNamePrefix&gt;_&lt;fileIndex&gt;.&lt;fileExtension&gt; when copy from non-file based store without partitionOptions. Type: string (or Expression with resultType string). </param>
        internal DelimitedTextWriteSettings(string type, IDictionary<string, object> additionalProperties, object quoteAllText, object fileExtension, object maxRowsPerFile, object fileNamePrefix) : base(type, additionalProperties)
        {
            QuoteAllText = quoteAllText;
            FileExtension = fileExtension;
            MaxRowsPerFile = maxRowsPerFile;
            FileNamePrefix = fileNamePrefix;
            Type = type ?? "DelimitedTextWriteSettings";
        }

        /// <summary> Indicates whether string values should always be enclosed with quotes. Type: boolean (or Expression with resultType boolean). </summary>
        public object QuoteAllText { get; set; }
        /// <summary> The file extension used to create the files. Type: string (or Expression with resultType string). </summary>
        public object FileExtension { get; set; }
        /// <summary> Limit the written file's row count to be smaller than or equal to the specified count. Type: integer (or Expression with resultType integer). </summary>
        public object MaxRowsPerFile { get; set; }
        /// <summary> Specifies the file name pattern &lt;fileNamePrefix&gt;_&lt;fileIndex&gt;.&lt;fileExtension&gt; when copy from non-file based store without partitionOptions. Type: string (or Expression with resultType string). </summary>
        public object FileNamePrefix { get; set; }
    }
}
