// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppContainers.Models;

namespace Azure.ResourceManager.AppContainers
{
    internal partial class ManagedEnvironmentDiagnosticsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ManagedEnvironmentDiagnosticsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ManagedEnvironmentDiagnosticsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-05-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListDetectorsRequest(string subscriptionId, string resourceGroupName, string environmentName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.App/managedEnvironments/", false);
            uri.AppendPath(environmentName, true);
            uri.AppendPath("/detectors", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the list of diagnostics for a Managed Environment used to host container apps. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="environmentName"> Name of the Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="environmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="environmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DiagnosticsCollection>> ListDetectorsAsync(string subscriptionId, string resourceGroupName, string environmentName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (environmentName == null)
            {
                throw new ArgumentNullException(nameof(environmentName));
            }
            if (environmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(environmentName));
            }

            using var message = CreateListDetectorsRequest(subscriptionId, resourceGroupName, environmentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DiagnosticsCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DiagnosticsCollection.DeserializeDiagnosticsCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the list of diagnostics for a Managed Environment used to host container apps. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="environmentName"> Name of the Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="environmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="environmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DiagnosticsCollection> ListDetectors(string subscriptionId, string resourceGroupName, string environmentName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (environmentName == null)
            {
                throw new ArgumentNullException(nameof(environmentName));
            }
            if (environmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(environmentName));
            }

            using var message = CreateListDetectorsRequest(subscriptionId, resourceGroupName, environmentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DiagnosticsCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DiagnosticsCollection.DeserializeDiagnosticsCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetDetectorRequest(string subscriptionId, string resourceGroupName, string environmentName, string detectorName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.App/managedEnvironments/", false);
            uri.AppendPath(environmentName, true);
            uri.AppendPath("/detectors/", false);
            uri.AppendPath(detectorName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the diagnostics data for a Managed Environment used to host container apps. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="environmentName"> Name of the Environment. </param>
        /// <param name="detectorName"> Name of the Managed Environment detector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="environmentName"/> or <paramref name="detectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="environmentName"/> or <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ContainerAppDiagnosticData>> GetDetectorAsync(string subscriptionId, string resourceGroupName, string environmentName, string detectorName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (environmentName == null)
            {
                throw new ArgumentNullException(nameof(environmentName));
            }
            if (environmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(environmentName));
            }
            if (detectorName == null)
            {
                throw new ArgumentNullException(nameof(detectorName));
            }
            if (detectorName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(detectorName));
            }

            using var message = CreateGetDetectorRequest(subscriptionId, resourceGroupName, environmentName, detectorName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ContainerAppDiagnosticData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ContainerAppDiagnosticData.DeserializeContainerAppDiagnosticData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ContainerAppDiagnosticData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the diagnostics data for a Managed Environment used to host container apps. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="environmentName"> Name of the Environment. </param>
        /// <param name="detectorName"> Name of the Managed Environment detector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="environmentName"/> or <paramref name="detectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="environmentName"/> or <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ContainerAppDiagnosticData> GetDetector(string subscriptionId, string resourceGroupName, string environmentName, string detectorName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (environmentName == null)
            {
                throw new ArgumentNullException(nameof(environmentName));
            }
            if (environmentName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(environmentName));
            }
            if (detectorName == null)
            {
                throw new ArgumentNullException(nameof(detectorName));
            }
            if (detectorName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(detectorName));
            }

            using var message = CreateGetDetectorRequest(subscriptionId, resourceGroupName, environmentName, detectorName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ContainerAppDiagnosticData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ContainerAppDiagnosticData.DeserializeContainerAppDiagnosticData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ContainerAppDiagnosticData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
