// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for task that migrates Schema for SQL Server databases to Azure SQL databases. </summary>
    public partial class MigrateSchemaSqlServerSqlDBTaskInput : SqlMigrationTaskInput
    {
        /// <summary> Initializes a new instance of <see cref="MigrateSchemaSqlServerSqlDBTaskInput"/>. </summary>
        /// <param name="sourceConnectionInfo"> Information for connecting to source. </param>
        /// <param name="targetConnectionInfo"> Information for connecting to target. </param>
        /// <param name="selectedDatabases"> Databases to migrate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceConnectionInfo"/>, <paramref name="targetConnectionInfo"/> or <paramref name="selectedDatabases"/> is null. </exception>
        public MigrateSchemaSqlServerSqlDBTaskInput(SqlConnectionInfo sourceConnectionInfo, SqlConnectionInfo targetConnectionInfo, IEnumerable<MigrateSchemaSqlServerSqlDBDatabaseInput> selectedDatabases) : base(sourceConnectionInfo, targetConnectionInfo)
        {
            if (sourceConnectionInfo == null)
            {
                throw new ArgumentNullException(nameof(sourceConnectionInfo));
            }
            if (targetConnectionInfo == null)
            {
                throw new ArgumentNullException(nameof(targetConnectionInfo));
            }
            if (selectedDatabases == null)
            {
                throw new ArgumentNullException(nameof(selectedDatabases));
            }

            SelectedDatabases = selectedDatabases.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="MigrateSchemaSqlServerSqlDBTaskInput"/>. </summary>
        /// <param name="sourceConnectionInfo"> Information for connecting to source. </param>
        /// <param name="targetConnectionInfo"> Information for connecting to target. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="selectedDatabases"> Databases to migrate. </param>
        /// <param name="encryptedKeyForSecureFields"> encrypted key for secure fields. </param>
        /// <param name="startedOn"> Migration start time. </param>
        internal MigrateSchemaSqlServerSqlDBTaskInput(SqlConnectionInfo sourceConnectionInfo, SqlConnectionInfo targetConnectionInfo, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<MigrateSchemaSqlServerSqlDBDatabaseInput> selectedDatabases, string encryptedKeyForSecureFields, string startedOn) : base(sourceConnectionInfo, targetConnectionInfo, serializedAdditionalRawData)
        {
            SelectedDatabases = selectedDatabases;
            EncryptedKeyForSecureFields = encryptedKeyForSecureFields;
            StartedOn = startedOn;
        }

        /// <summary> Initializes a new instance of <see cref="MigrateSchemaSqlServerSqlDBTaskInput"/> for deserialization. </summary>
        internal MigrateSchemaSqlServerSqlDBTaskInput()
        {
        }

        /// <summary> Databases to migrate. </summary>
        public IList<MigrateSchemaSqlServerSqlDBDatabaseInput> SelectedDatabases { get; }
        /// <summary> encrypted key for secure fields. </summary>
        public string EncryptedKeyForSecureFields { get; set; }
        /// <summary> Migration start time. </summary>
        public string StartedOn { get; set; }
    }
}
