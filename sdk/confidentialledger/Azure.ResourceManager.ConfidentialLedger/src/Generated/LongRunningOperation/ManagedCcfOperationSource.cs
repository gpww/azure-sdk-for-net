// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ConfidentialLedger
{
    internal class ManagedCcfOperationSource : IOperationSource<ManagedCcfResource>
    {
        private readonly ArmClient _client;

        internal ManagedCcfOperationSource(ArmClient client)
        {
            _client = client;
        }

        ManagedCcfResource IOperationSource<ManagedCcfResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ManagedCcfData.DeserializeManagedCcfData(document.RootElement);
            return new ManagedCcfResource(_client, data);
        }

        async ValueTask<ManagedCcfResource> IOperationSource<ManagedCcfResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ManagedCcfData.DeserializeManagedCcfData(document.RootElement);
            return new ManagedCcfResource(_client, data);
        }
    }
}
