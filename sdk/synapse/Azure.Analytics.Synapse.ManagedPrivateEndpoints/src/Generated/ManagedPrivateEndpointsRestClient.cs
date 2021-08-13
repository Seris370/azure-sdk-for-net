// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.ManagedPrivateEndpoints.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.ManagedPrivateEndpoints
{
    internal partial class ManagedPrivateEndpointsRestClient
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ManagedPrivateEndpointsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public ManagedPrivateEndpointsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion = "2021-06-01-preview")
        {
            this.endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetRequest(string managedPrivateEndpointName, string managedVirtualNetworkName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/managedVirtualNetworks/", false);
            uri.AppendPath(managedVirtualNetworkName, true);
            uri.AppendPath("/managedPrivateEndpoints/", false);
            uri.AppendPath(managedPrivateEndpointName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get Managed Private Endpoints. </summary>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> or <paramref name="managedVirtualNetworkName"/> is null. </exception>
        public async Task<Response<ManagedPrivateEndpoint>> GetAsync(string managedPrivateEndpointName, string managedVirtualNetworkName = "default", CancellationToken cancellationToken = default)
        {
            if (managedPrivateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpointName));
            }
            if (managedVirtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(managedVirtualNetworkName));
            }

            using var message = CreateGetRequest(managedPrivateEndpointName, managedVirtualNetworkName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagedPrivateEndpoint value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ManagedPrivateEndpoint.DeserializeManagedPrivateEndpoint(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get Managed Private Endpoints. </summary>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> or <paramref name="managedVirtualNetworkName"/> is null. </exception>
        public Response<ManagedPrivateEndpoint> Get(string managedPrivateEndpointName, string managedVirtualNetworkName = "default", CancellationToken cancellationToken = default)
        {
            if (managedPrivateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpointName));
            }
            if (managedVirtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(managedVirtualNetworkName));
            }

            using var message = CreateGetRequest(managedPrivateEndpointName, managedVirtualNetworkName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagedPrivateEndpoint value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ManagedPrivateEndpoint.DeserializeManagedPrivateEndpoint(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string managedPrivateEndpointName, ManagedPrivateEndpoint managedPrivateEndpoint, string managedVirtualNetworkName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/managedVirtualNetworks/", false);
            uri.AppendPath(managedVirtualNetworkName, true);
            uri.AppendPath("/managedPrivateEndpoints/", false);
            uri.AppendPath(managedPrivateEndpointName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(managedPrivateEndpoint);
            request.Content = content;
            return message;
        }

        /// <summary> Create Managed Private Endpoints. </summary>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="managedPrivateEndpoint"> Managed private endpoint properties. </param>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/>, <paramref name="managedPrivateEndpoint"/>, or <paramref name="managedVirtualNetworkName"/> is null. </exception>
        public async Task<Response<ManagedPrivateEndpoint>> CreateAsync(string managedPrivateEndpointName, ManagedPrivateEndpoint managedPrivateEndpoint, string managedVirtualNetworkName = "default", CancellationToken cancellationToken = default)
        {
            if (managedPrivateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpointName));
            }
            if (managedPrivateEndpoint == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpoint));
            }
            if (managedVirtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(managedVirtualNetworkName));
            }

            using var message = CreateCreateRequest(managedPrivateEndpointName, managedPrivateEndpoint, managedVirtualNetworkName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagedPrivateEndpoint value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ManagedPrivateEndpoint.DeserializeManagedPrivateEndpoint(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create Managed Private Endpoints. </summary>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="managedPrivateEndpoint"> Managed private endpoint properties. </param>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/>, <paramref name="managedPrivateEndpoint"/>, or <paramref name="managedVirtualNetworkName"/> is null. </exception>
        public Response<ManagedPrivateEndpoint> Create(string managedPrivateEndpointName, ManagedPrivateEndpoint managedPrivateEndpoint, string managedVirtualNetworkName = "default", CancellationToken cancellationToken = default)
        {
            if (managedPrivateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpointName));
            }
            if (managedPrivateEndpoint == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpoint));
            }
            if (managedVirtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(managedVirtualNetworkName));
            }

            using var message = CreateCreateRequest(managedPrivateEndpointName, managedPrivateEndpoint, managedVirtualNetworkName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagedPrivateEndpoint value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ManagedPrivateEndpoint.DeserializeManagedPrivateEndpoint(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string managedPrivateEndpointName, string managedVirtualNetworkName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/managedVirtualNetworks/", false);
            uri.AppendPath(managedVirtualNetworkName, true);
            uri.AppendPath("/managedPrivateEndpoints/", false);
            uri.AppendPath(managedPrivateEndpointName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Delete Managed Private Endpoints. </summary>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> or <paramref name="managedVirtualNetworkName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string managedPrivateEndpointName, string managedVirtualNetworkName = "default", CancellationToken cancellationToken = default)
        {
            if (managedPrivateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpointName));
            }
            if (managedVirtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(managedVirtualNetworkName));
            }

            using var message = CreateDeleteRequest(managedPrivateEndpointName, managedVirtualNetworkName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Delete Managed Private Endpoints. </summary>
        /// <param name="managedPrivateEndpointName"> Managed private endpoint name. </param>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedPrivateEndpointName"/> or <paramref name="managedVirtualNetworkName"/> is null. </exception>
        public Response Delete(string managedPrivateEndpointName, string managedVirtualNetworkName = "default", CancellationToken cancellationToken = default)
        {
            if (managedPrivateEndpointName == null)
            {
                throw new ArgumentNullException(nameof(managedPrivateEndpointName));
            }
            if (managedVirtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(managedVirtualNetworkName));
            }

            using var message = CreateDeleteRequest(managedPrivateEndpointName, managedVirtualNetworkName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string managedVirtualNetworkName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/managedVirtualNetworks/", false);
            uri.AppendPath(managedVirtualNetworkName, true);
            uri.AppendPath("/managedPrivateEndpoints", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> List Managed Private Endpoints. </summary>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedVirtualNetworkName"/> is null. </exception>
        public async Task<Response<ManagedPrivateEndpointListResponse>> ListAsync(string managedVirtualNetworkName = "default", CancellationToken cancellationToken = default)
        {
            if (managedVirtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(managedVirtualNetworkName));
            }

            using var message = CreateListRequest(managedVirtualNetworkName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagedPrivateEndpointListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ManagedPrivateEndpointListResponse.DeserializeManagedPrivateEndpointListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List Managed Private Endpoints. </summary>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedVirtualNetworkName"/> is null. </exception>
        public Response<ManagedPrivateEndpointListResponse> List(string managedVirtualNetworkName = "default", CancellationToken cancellationToken = default)
        {
            if (managedVirtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(managedVirtualNetworkName));
            }

            using var message = CreateListRequest(managedVirtualNetworkName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagedPrivateEndpointListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ManagedPrivateEndpointListResponse.DeserializeManagedPrivateEndpointListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string managedVirtualNetworkName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> List Managed Private Endpoints. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="managedVirtualNetworkName"/> is null. </exception>
        public async Task<Response<ManagedPrivateEndpointListResponse>> ListNextPageAsync(string nextLink, string managedVirtualNetworkName = "default", CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (managedVirtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(managedVirtualNetworkName));
            }

            using var message = CreateListNextPageRequest(nextLink, managedVirtualNetworkName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagedPrivateEndpointListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ManagedPrivateEndpointListResponse.DeserializeManagedPrivateEndpointListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List Managed Private Endpoints. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="managedVirtualNetworkName"/> is null. </exception>
        public Response<ManagedPrivateEndpointListResponse> ListNextPage(string nextLink, string managedVirtualNetworkName = "default", CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (managedVirtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(managedVirtualNetworkName));
            }

            using var message = CreateListNextPageRequest(nextLink, managedVirtualNetworkName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagedPrivateEndpointListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ManagedPrivateEndpointListResponse.DeserializeManagedPrivateEndpointListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
