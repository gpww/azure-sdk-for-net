// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Ftp read settings. </summary>
    public partial class FtpReadSettings : StoreReadSettings
    {
        /// <summary> Initializes a new instance of FtpReadSettings. </summary>
        public FtpReadSettings()
        {
            StoreReadSettingsType = "FtpReadSettings";
        }

        /// <summary> Initializes a new instance of FtpReadSettings. </summary>
        /// <param name="storeReadSettingsType"> The read setting type. </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="recursive"> If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="wildcardFolderPath"> Ftp wildcardFolderPath. Type: string (or Expression with resultType string). </param>
        /// <param name="wildcardFileName"> Ftp wildcardFileName. Type: string (or Expression with resultType string). </param>
        /// <param name="enablePartitionDiscovery"> Indicates whether to enable partition discovery. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="partitionRootPath"> Specify the root path where partition discovery starts from. Type: string (or Expression with resultType string). </param>
        /// <param name="deleteFilesAfterCompletion"> Indicates whether the source files need to be deleted after copy completion. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="fileListPath"> Point to a text file that lists each file (relative path to the path configured in the dataset) that you want to copy. Type: string (or Expression with resultType string). </param>
        /// <param name="useBinaryTransfer"> Specify whether to use binary transfer mode for FTP stores. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="disableChunking"> If true, disable parallel reading within each file. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        internal FtpReadSettings(string storeReadSettingsType, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<bool> recursive, DataFactoryElement<string> wildcardFolderPath, DataFactoryElement<string> wildcardFileName, DataFactoryElement<bool> enablePartitionDiscovery, DataFactoryElement<string> partitionRootPath, DataFactoryElement<bool> deleteFilesAfterCompletion, DataFactoryElement<string> fileListPath, DataFactoryElement<bool> useBinaryTransfer, DataFactoryElement<bool> disableChunking) : base(storeReadSettingsType, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            Recursive = recursive;
            WildcardFolderPath = wildcardFolderPath;
            WildcardFileName = wildcardFileName;
            EnablePartitionDiscovery = enablePartitionDiscovery;
            PartitionRootPath = partitionRootPath;
            DeleteFilesAfterCompletion = deleteFilesAfterCompletion;
            FileListPath = fileListPath;
            UseBinaryTransfer = useBinaryTransfer;
            DisableChunking = disableChunking;
            StoreReadSettingsType = storeReadSettingsType ?? "FtpReadSettings";
        }

        /// <summary> If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> Recursive { get; set; }
        /// <summary> Ftp wildcardFolderPath. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> WildcardFolderPath { get; set; }
        /// <summary> Ftp wildcardFileName. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> WildcardFileName { get; set; }
        /// <summary> Indicates whether to enable partition discovery. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> EnablePartitionDiscovery { get; set; }
        /// <summary> Specify the root path where partition discovery starts from. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> PartitionRootPath { get; set; }
        /// <summary> Indicates whether the source files need to be deleted after copy completion. Default is false. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> DeleteFilesAfterCompletion { get; set; }
        /// <summary> Point to a text file that lists each file (relative path to the path configured in the dataset) that you want to copy. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> FileListPath { get; set; }
        /// <summary> Specify whether to use binary transfer mode for FTP stores. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> UseBinaryTransfer { get; set; }
        /// <summary> If true, disable parallel reading within each file. Default is false. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> DisableChunking { get; set; }
    }
}
