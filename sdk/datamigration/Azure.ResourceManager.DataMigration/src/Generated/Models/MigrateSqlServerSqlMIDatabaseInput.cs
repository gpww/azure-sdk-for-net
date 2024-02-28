// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Database specific information for SQL to Azure SQL DB Managed Instance migration task inputs. </summary>
    public partial class MigrateSqlServerSqlMIDatabaseInput
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlMIDatabaseInput"/>. </summary>
        /// <param name="name"> Name of the database. </param>
        /// <param name="restoreDatabaseName"> Name of the database at destination. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="restoreDatabaseName"/> is null. </exception>
        public MigrateSqlServerSqlMIDatabaseInput(string name, string restoreDatabaseName)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (restoreDatabaseName == null)
            {
                throw new ArgumentNullException(nameof(restoreDatabaseName));
            }

            Name = name;
            RestoreDatabaseName = restoreDatabaseName;
            BackupFilePaths = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlMIDatabaseInput"/>. </summary>
        /// <param name="name"> Name of the database. </param>
        /// <param name="restoreDatabaseName"> Name of the database at destination. </param>
        /// <param name="backupFileShare"> Backup file share information for backing up this database. </param>
        /// <param name="backupFilePaths"> The list of backup files to be used in case of existing backups. </param>
        /// <param name="id"> id of the database. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MigrateSqlServerSqlMIDatabaseInput(string name, string restoreDatabaseName, FileShare backupFileShare, IList<string> backupFilePaths, string id, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            RestoreDatabaseName = restoreDatabaseName;
            BackupFileShare = backupFileShare;
            BackupFilePaths = backupFilePaths;
            Id = id;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlMIDatabaseInput"/> for deserialization. </summary>
        internal MigrateSqlServerSqlMIDatabaseInput()
        {
        }

        /// <summary> Name of the database. </summary>
        public string Name { get; set; }
        /// <summary> Name of the database at destination. </summary>
        public string RestoreDatabaseName { get; set; }
        /// <summary> Backup file share information for backing up this database. </summary>
        public FileShare BackupFileShare { get; set; }
        /// <summary> The list of backup files to be used in case of existing backups. </summary>
        public IList<string> BackupFilePaths { get; }
        /// <summary> id of the database. </summary>
        public string Id { get; set; }
    }
}
