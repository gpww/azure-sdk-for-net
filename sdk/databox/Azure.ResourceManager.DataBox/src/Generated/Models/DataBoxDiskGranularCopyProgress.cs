// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> DataBox Disk Granular Copy Progress. </summary>
    public partial class DataBoxDiskGranularCopyProgress : GranularCopyProgress
    {
        /// <summary> Initializes a new instance of <see cref="DataBoxDiskGranularCopyProgress"/>. </summary>
        internal DataBoxDiskGranularCopyProgress()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxDiskGranularCopyProgress"/>. </summary>
        /// <param name="storageAccountName"> Name of the storage account. This will be empty for data account types other than storage account. </param>
        /// <param name="transferType"> Transfer type of data. </param>
        /// <param name="dataAccountType"> Data Account Type. </param>
        /// <param name="accountId"> Id of the account where the data needs to be uploaded. </param>
        /// <param name="bytesProcessed"> To indicate bytes transferred. </param>
        /// <param name="totalBytesToProcess"> Total amount of data to be processed by the job. </param>
        /// <param name="filesProcessed"> Number of files processed. </param>
        /// <param name="totalFilesToProcess"> Total files to process. </param>
        /// <param name="invalidFilesProcessed"> Number of files not adhering to azure naming conventions which were processed by automatic renaming. </param>
        /// <param name="invalidFileBytesUploaded"> Total amount of data not adhering to azure naming conventions which were processed by automatic renaming. </param>
        /// <param name="renamedContainerCount"> Number of folders not adhering to azure naming conventions which were processed by automatic renaming. </param>
        /// <param name="filesErroredOut"> Number of files which could not be copied. </param>
        /// <param name="directoriesErroredOut"> To indicate directories errored out in the job. </param>
        /// <param name="invalidDirectoriesProcessed"> To indicate directories renamed. </param>
        /// <param name="isEnumerationInProgress">
        /// To indicate if enumeration of data is in progress.
        /// Until this is true, the TotalBytesToProcess may not be valid.
        /// </param>
        /// <param name="error"> Error, if any, in the stage. </param>
        /// <param name="actions"> Available actions on the job. </param>
        /// <param name="serialNumber"> Disk Serial Number. </param>
        /// <param name="copyStatus"> The Status of the copy. </param>
        internal DataBoxDiskGranularCopyProgress(string storageAccountName, DataBoxJobTransferType? transferType, DataAccountType? dataAccountType, ResourceIdentifier accountId, long? bytesProcessed, long? totalBytesToProcess, long? filesProcessed, long? totalFilesToProcess, long? invalidFilesProcessed, long? invalidFileBytesUploaded, long? renamedContainerCount, long? filesErroredOut, long? directoriesErroredOut, long? invalidDirectoriesProcessed, bool? isEnumerationInProgress, ResponseError error, IReadOnlyList<CustomerResolutionCode> actions, string serialNumber, DataBoxCopyStatus? copyStatus) : base(storageAccountName, transferType, dataAccountType, accountId, bytesProcessed, totalBytesToProcess, filesProcessed, totalFilesToProcess, invalidFilesProcessed, invalidFileBytesUploaded, renamedContainerCount, filesErroredOut, directoriesErroredOut, invalidDirectoriesProcessed, isEnumerationInProgress, error, actions)
        {
            SerialNumber = serialNumber;
            CopyStatus = copyStatus;
        }

        /// <summary> Disk Serial Number. </summary>
        public string SerialNumber { get; }
        /// <summary> The Status of the copy. </summary>
        public DataBoxCopyStatus? CopyStatus { get; }
    }
}
