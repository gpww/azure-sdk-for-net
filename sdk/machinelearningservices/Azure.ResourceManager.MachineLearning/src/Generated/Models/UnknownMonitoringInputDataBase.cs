// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Unknown version of MonitoringInputDataBase. </summary>
    internal partial class UnknownMonitoringInputDataBase : MonitoringInputDataBase
    {
        /// <summary> Initializes a new instance of <see cref="UnknownMonitoringInputDataBase"/>. </summary>
        /// <param name="columns"> Mapping of column names to special uses. </param>
        /// <param name="dataContext"> The context metadata of the data source. </param>
        /// <param name="inputDataType"> [Required] Specifies the type of signal to monitor. </param>
        /// <param name="jobInputType"> [Required] Specifies the type of job. </param>
        /// <param name="uri"> [Required] Input Asset URI. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownMonitoringInputDataBase(IDictionary<string, string> columns, string dataContext, MonitoringInputDataType inputDataType, JobInputType jobInputType, Uri uri, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(columns, dataContext, inputDataType, jobInputType, uri, serializedAdditionalRawData)
        {
            InputDataType = inputDataType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownMonitoringInputDataBase"/> for deserialization. </summary>
        internal UnknownMonitoringInputDataBase()
        {
        }
    }
}
