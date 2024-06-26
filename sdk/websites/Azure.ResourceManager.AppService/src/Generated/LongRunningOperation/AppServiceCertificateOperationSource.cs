// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.AppService
{
    internal class AppServiceCertificateOperationSource : IOperationSource<AppServiceCertificateResource>
    {
        private readonly ArmClient _client;

        internal AppServiceCertificateOperationSource(ArmClient client)
        {
            _client = client;
        }

        AppServiceCertificateResource IOperationSource<AppServiceCertificateResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AppServiceCertificateData.DeserializeAppServiceCertificateData(document.RootElement);
            return new AppServiceCertificateResource(_client, data);
        }

        async ValueTask<AppServiceCertificateResource> IOperationSource<AppServiceCertificateResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AppServiceCertificateData.DeserializeAppServiceCertificateData(document.RootElement);
            return new AppServiceCertificateResource(_client, data);
        }
    }
}
