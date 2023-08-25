// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.ResourceHealth;
using Azure.ResourceManager.ResourceHealth.Models;

namespace Azure.ResourceManager.ResourceHealth.Samples
{
    public partial class Sample_ServiceEmergingIssueCollection
    {
        // GetEmergingIssues
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetEmergingIssues()
        {
            // Generated from example definition: specification/resourcehealth/resource-manager/Microsoft.ResourceHealth/stable/2022-10-01/examples/EmergingIssues_List.json
            // this example is just showing the usage of "EmergingIssues_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this ServiceEmergingIssueResource
            ServiceEmergingIssueCollection collection = tenantResource.GetServiceEmergingIssues();

            // invoke the operation and iterate over the result
            await foreach (ServiceEmergingIssueResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceEmergingIssueData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // GetEmergingIssues
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetEmergingIssues()
        {
            // Generated from example definition: specification/resourcehealth/resource-manager/Microsoft.ResourceHealth/stable/2022-10-01/examples/EmergingIssues_Get.json
            // this example is just showing the usage of "EmergingIssues_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this ServiceEmergingIssueResource
            ServiceEmergingIssueCollection collection = tenantResource.GetServiceEmergingIssues();

            // invoke the operation
            EmergingIssueNameContent issueName = EmergingIssueNameContent.Default;
            ServiceEmergingIssueResource result = await collection.GetAsync(issueName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceEmergingIssueData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetEmergingIssues
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetEmergingIssues()
        {
            // Generated from example definition: specification/resourcehealth/resource-manager/Microsoft.ResourceHealth/stable/2022-10-01/examples/EmergingIssues_Get.json
            // this example is just showing the usage of "EmergingIssues_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this ServiceEmergingIssueResource
            ServiceEmergingIssueCollection collection = tenantResource.GetServiceEmergingIssues();

            // invoke the operation
            EmergingIssueNameContent issueName = EmergingIssueNameContent.Default;
            bool result = await collection.ExistsAsync(issueName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
