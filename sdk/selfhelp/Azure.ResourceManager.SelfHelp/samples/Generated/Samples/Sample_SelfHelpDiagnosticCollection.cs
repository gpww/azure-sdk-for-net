// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.SelfHelp;

namespace Azure.ResourceManager.SelfHelp.Samples
{
    public partial class Sample_SelfHelpDiagnosticCollection
    {
        // Creates a Diagnostic for a KeyVault resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreatesADiagnosticForAKeyVaultResource()
        {
            // Generated from example definition: specification/help/resource-manager/Microsoft.Help/stable/2023-06-01/examples/CreateDiagnosticForKeyVaultResource.json
            // this example is just showing the usage of "Diagnostics_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this SelfHelpDiagnosticResource
            string scope = "subscriptions/0d0fcd2e-c4fd-4349-8497-200edb3923c6/resourcegroups/myresourceGroup/providers/Microsoft.KeyVault/vaults/test-keyvault-non-read";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            SelfHelpDiagnosticCollection collection = client.GetSelfHelpDiagnostics(scopeId);

            // invoke the operation
            string diagnosticsResourceName = "VMNotWorkingInsight";
            SelfHelpDiagnosticData data = new SelfHelpDiagnosticData();
            ArmOperation<SelfHelpDiagnosticResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, diagnosticsResourceName, data);
            SelfHelpDiagnosticResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SelfHelpDiagnosticData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets a Diagnostic for a KeyVault resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsADiagnosticForAKeyVaultResource()
        {
            // Generated from example definition: specification/help/resource-manager/Microsoft.Help/stable/2023-06-01/examples/GetDiagnosticForKeyVaultResource.json
            // this example is just showing the usage of "Diagnostics_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this SelfHelpDiagnosticResource
            string scope = "subscriptions/0d0fcd2e-c4fd-4349-8497-200edb3923c6/resourcegroups/myresourceGroup/providers/Microsoft.KeyVault/vaults/test-keyvault-non-read";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            SelfHelpDiagnosticCollection collection = client.GetSelfHelpDiagnostics(scopeId);

            // invoke the operation
            string diagnosticsResourceName = "VMNotWorkingInsight";
            SelfHelpDiagnosticResource result = await collection.GetAsync(diagnosticsResourceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SelfHelpDiagnosticData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets a Diagnostic for a KeyVault resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetsADiagnosticForAKeyVaultResource()
        {
            // Generated from example definition: specification/help/resource-manager/Microsoft.Help/stable/2023-06-01/examples/GetDiagnosticForKeyVaultResource.json
            // this example is just showing the usage of "Diagnostics_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this SelfHelpDiagnosticResource
            string scope = "subscriptions/0d0fcd2e-c4fd-4349-8497-200edb3923c6/resourcegroups/myresourceGroup/providers/Microsoft.KeyVault/vaults/test-keyvault-non-read";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            SelfHelpDiagnosticCollection collection = client.GetSelfHelpDiagnostics(scopeId);

            // invoke the operation
            string diagnosticsResourceName = "VMNotWorkingInsight";
            bool result = await collection.ExistsAsync(diagnosticsResourceName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
