// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> SAP Table Linked Service. </summary>
    public partial class SapTableLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="SapTableLinkedService"/>. </summary>
        public SapTableLinkedService()
        {
            LinkedServiceType = "SapTable";
        }

        /// <summary> Initializes a new instance of <see cref="SapTableLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="server"> Host name of the SAP instance where the table is located. Type: string (or Expression with resultType string). </param>
        /// <param name="systemNumber"> System number of the SAP system where the table is located. (Usually a two-digit decimal number represented as a string.) Type: string (or Expression with resultType string). </param>
        /// <param name="clientId"> Client ID of the client on the SAP system where the table is located. (Usually a three-digit decimal number represented as a string) Type: string (or Expression with resultType string). </param>
        /// <param name="language"> Language of the SAP system where the table is located. The default value is EN. Type: string (or Expression with resultType string). </param>
        /// <param name="systemId"> SystemID of the SAP system where the table is located. Type: string (or Expression with resultType string). </param>
        /// <param name="userName"> Username to access the SAP server where the table is located. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> Password to access the SAP server where the table is located. </param>
        /// <param name="messageServer"> The hostname of the SAP Message Server. Type: string (or Expression with resultType string). </param>
        /// <param name="messageServerService"> The service name or port number of the Message Server. Type: string (or Expression with resultType string). </param>
        /// <param name="sncMode"> SNC activation indicator to access the SAP server where the table is located. Must be either 0 (off) or 1 (on). Type: string (or Expression with resultType string). </param>
        /// <param name="sncMyName"> Initiator's SNC name to access the SAP server where the table is located. Type: string (or Expression with resultType string). </param>
        /// <param name="sncPartnerName"> Communication partner's SNC name to access the SAP server where the table is located. Type: string (or Expression with resultType string). </param>
        /// <param name="sncLibraryPath"> External security product's library to access the SAP server where the table is located. Type: string (or Expression with resultType string). </param>
        /// <param name="sncQop"> SNC Quality of Protection. Allowed value include: 1, 2, 3, 8, 9. Type: string (or Expression with resultType string). </param>
        /// <param name="logonGroup"> The Logon Group for the SAP System. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal SapTableLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> server, DataFactoryElement<string> systemNumber, DataFactoryElement<string> clientId, DataFactoryElement<string> language, DataFactoryElement<string> systemId, DataFactoryElement<string> userName, DataFactorySecretBaseDefinition password, DataFactoryElement<string> messageServer, DataFactoryElement<string> messageServerService, DataFactoryElement<string> sncMode, DataFactoryElement<string> sncMyName, DataFactoryElement<string> sncPartnerName, DataFactoryElement<string> sncLibraryPath, DataFactoryElement<string> sncQop, DataFactoryElement<string> logonGroup, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Server = server;
            SystemNumber = systemNumber;
            ClientId = clientId;
            Language = language;
            SystemId = systemId;
            UserName = userName;
            Password = password;
            MessageServer = messageServer;
            MessageServerService = messageServerService;
            SncMode = sncMode;
            SncMyName = sncMyName;
            SncPartnerName = sncPartnerName;
            SncLibraryPath = sncLibraryPath;
            SncQop = sncQop;
            LogonGroup = logonGroup;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "SapTable";
        }

        /// <summary> Host name of the SAP instance where the table is located. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Server { get; set; }
        /// <summary> System number of the SAP system where the table is located. (Usually a two-digit decimal number represented as a string.) Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> SystemNumber { get; set; }
        /// <summary> Client ID of the client on the SAP system where the table is located. (Usually a three-digit decimal number represented as a string) Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ClientId { get; set; }
        /// <summary> Language of the SAP system where the table is located. The default value is EN. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Language { get; set; }
        /// <summary> SystemID of the SAP system where the table is located. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> SystemId { get; set; }
        /// <summary> Username to access the SAP server where the table is located. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> UserName { get; set; }
        /// <summary> Password to access the SAP server where the table is located. </summary>
        public DataFactorySecretBaseDefinition Password { get; set; }
        /// <summary> The hostname of the SAP Message Server. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> MessageServer { get; set; }
        /// <summary> The service name or port number of the Message Server. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> MessageServerService { get; set; }
        /// <summary> SNC activation indicator to access the SAP server where the table is located. Must be either 0 (off) or 1 (on). Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> SncMode { get; set; }
        /// <summary> Initiator's SNC name to access the SAP server where the table is located. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> SncMyName { get; set; }
        /// <summary> Communication partner's SNC name to access the SAP server where the table is located. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> SncPartnerName { get; set; }
        /// <summary> External security product's library to access the SAP server where the table is located. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> SncLibraryPath { get; set; }
        /// <summary> SNC Quality of Protection. Allowed value include: 1, 2, 3, 8, 9. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> SncQop { get; set; }
        /// <summary> The Logon Group for the SAP System. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> LogonGroup { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
