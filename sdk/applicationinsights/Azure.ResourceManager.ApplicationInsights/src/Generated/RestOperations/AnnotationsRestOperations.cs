// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.ApplicationInsights.Models;

namespace Azure.ResourceManager.ApplicationInsights
{
    internal partial class AnnotationsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of AnnotationsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public AnnotationsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2015-05-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string resourceName, string start, string end)
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
            uri.AppendPath("/providers/Microsoft.Insights/components/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/Annotations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            uri.AppendQuery("start", start, true);
            uri.AppendQuery("end", end, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the list of annotations for a component for given time range. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="start"> The start time to query from for annotations, cannot be older than 90 days from current date. </param>
        /// <param name="end"> The end time to query for annotations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="start"/> or <paramref name="end"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AnnotationsListResult>> ListAsync(string subscriptionId, string resourceGroupName, string resourceName, string start, string end, CancellationToken cancellationToken = default)
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
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (start == null)
            {
                throw new ArgumentNullException(nameof(start));
            }
            if (end == null)
            {
                throw new ArgumentNullException(nameof(end));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, resourceName, start, end);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AnnotationsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AnnotationsListResult.DeserializeAnnotationsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the list of annotations for a component for given time range. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="start"> The start time to query from for annotations, cannot be older than 90 days from current date. </param>
        /// <param name="end"> The end time to query for annotations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="start"/> or <paramref name="end"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AnnotationsListResult> List(string subscriptionId, string resourceGroupName, string resourceName, string start, string end, CancellationToken cancellationToken = default)
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
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (start == null)
            {
                throw new ArgumentNullException(nameof(start));
            }
            if (end == null)
            {
                throw new ArgumentNullException(nameof(end));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, resourceName, start, end);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AnnotationsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AnnotationsListResult.DeserializeAnnotationsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string resourceGroupName, string resourceName, Annotation annotationProperties)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Insights/components/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/Annotations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(annotationProperties);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create an Annotation of an Application Insights component. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="annotationProperties"> Properties that need to be specified to create an annotation of a Application Insights component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="annotationProperties"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IReadOnlyList<Annotation>>> CreateAsync(string subscriptionId, string resourceGroupName, string resourceName, Annotation annotationProperties, CancellationToken cancellationToken = default)
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
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (annotationProperties == null)
            {
                throw new ArgumentNullException(nameof(annotationProperties));
            }

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, resourceName, annotationProperties);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<Annotation> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<Annotation> array = new List<Annotation>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(Annotation.DeserializeAnnotation(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create an Annotation of an Application Insights component. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="annotationProperties"> Properties that need to be specified to create an annotation of a Application Insights component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="annotationProperties"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IReadOnlyList<Annotation>> Create(string subscriptionId, string resourceGroupName, string resourceName, Annotation annotationProperties, CancellationToken cancellationToken = default)
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
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (annotationProperties == null)
            {
                throw new ArgumentNullException(nameof(annotationProperties));
            }

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, resourceName, annotationProperties);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<Annotation> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<Annotation> array = new List<Annotation>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(Annotation.DeserializeAnnotation(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string resourceName, string annotationId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Insights/components/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/Annotations/", false);
            uri.AppendPath(annotationId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete an Annotation of an Application Insights component. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="annotationId"> The unique annotation ID. This is unique within a Application Insights component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="annotationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="annotationId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string resourceName, string annotationId, CancellationToken cancellationToken = default)
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
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (annotationId == null)
            {
                throw new ArgumentNullException(nameof(annotationId));
            }
            if (annotationId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(annotationId));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, resourceName, annotationId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete an Annotation of an Application Insights component. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="annotationId"> The unique annotation ID. This is unique within a Application Insights component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="annotationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="annotationId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string resourceName, string annotationId, CancellationToken cancellationToken = default)
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
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (annotationId == null)
            {
                throw new ArgumentNullException(nameof(annotationId));
            }
            if (annotationId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(annotationId));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, resourceName, annotationId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string resourceName, string annotationId)
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
            uri.AppendPath("/providers/Microsoft.Insights/components/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/Annotations/", false);
            uri.AppendPath(annotationId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the annotation for given id. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="annotationId"> The unique annotation ID. This is unique within a Application Insights component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="annotationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="annotationId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IReadOnlyList<Annotation>>> GetAsync(string subscriptionId, string resourceGroupName, string resourceName, string annotationId, CancellationToken cancellationToken = default)
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
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (annotationId == null)
            {
                throw new ArgumentNullException(nameof(annotationId));
            }
            if (annotationId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(annotationId));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, resourceName, annotationId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<Annotation> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<Annotation> array = new List<Annotation>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(Annotation.DeserializeAnnotation(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the annotation for given id. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="annotationId"> The unique annotation ID. This is unique within a Application Insights component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="annotationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="annotationId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IReadOnlyList<Annotation>> Get(string subscriptionId, string resourceGroupName, string resourceName, string annotationId, CancellationToken cancellationToken = default)
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
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (annotationId == null)
            {
                throw new ArgumentNullException(nameof(annotationId));
            }
            if (annotationId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(annotationId));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, resourceName, annotationId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<Annotation> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<Annotation> array = new List<Annotation>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(Annotation.DeserializeAnnotation(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
