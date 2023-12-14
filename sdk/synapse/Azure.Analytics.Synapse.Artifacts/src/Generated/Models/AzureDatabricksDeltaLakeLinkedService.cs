// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Azure Databricks Delta Lake linked service. </summary>
    public partial class AzureDatabricksDeltaLakeLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="AzureDatabricksDeltaLakeLinkedService"/>. </summary>
        /// <param name="domain"> &lt;REGION&gt;.azuredatabricks.net, domain name of your Databricks deployment. Type: string (or Expression with resultType string). </param>
        /// <param name="accessToken">
        /// Access token for databricks REST API. Refer to https://docs.azuredatabricks.net/api/latest/authentication.html. Type: string, SecureString or AzureKeyVaultSecretReference.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domain"/> or <paramref name="accessToken"/> is null. </exception>
        public AzureDatabricksDeltaLakeLinkedService(object domain, SecretBase accessToken)
        {
            Argument.AssertNotNull(domain, nameof(domain));
            Argument.AssertNotNull(accessToken, nameof(accessToken));

            Domain = domain;
            AccessToken = accessToken;
            Type = "AzureDatabricksDeltaLake";
        }

        /// <summary> Initializes a new instance of <see cref="AzureDatabricksDeltaLakeLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="domain"> &lt;REGION&gt;.azuredatabricks.net, domain name of your Databricks deployment. Type: string (or Expression with resultType string). </param>
        /// <param name="accessToken">
        /// Access token for databricks REST API. Refer to https://docs.azuredatabricks.net/api/latest/authentication.html. Type: string, SecureString or AzureKeyVaultSecretReference.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="clusterId"> The id of an existing interactive cluster that will be used for all runs of this job. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        internal AzureDatabricksDeltaLakeLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object domain, SecretBase accessToken, object clusterId, object encryptedCredential, CredentialReference credential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            Domain = domain;
            AccessToken = accessToken;
            ClusterId = clusterId;
            EncryptedCredential = encryptedCredential;
            Credential = credential;
            Type = type ?? "AzureDatabricksDeltaLake";
        }

        /// <summary> &lt;REGION&gt;.azuredatabricks.net, domain name of your Databricks deployment. Type: string (or Expression with resultType string). </summary>
        public object Domain { get; set; }
        /// <summary>
        /// Access token for databricks REST API. Refer to https://docs.azuredatabricks.net/api/latest/authentication.html. Type: string, SecureString or AzureKeyVaultSecretReference.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase AccessToken { get; set; }
        /// <summary> The id of an existing interactive cluster that will be used for all runs of this job. Type: string (or Expression with resultType string). </summary>
        public object ClusterId { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public CredentialReference Credential { get; set; }
    }
}
