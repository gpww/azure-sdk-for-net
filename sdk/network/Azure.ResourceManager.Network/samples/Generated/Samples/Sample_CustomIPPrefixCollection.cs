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
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_CustomIPPrefixCollection
    {
        // Get custom IP prefix
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetCustomIPPrefix()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/CustomIpPrefixGet.json
            // this example is just showing the usage of "CustomIPPrefixes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CustomIPPrefixResource
            CustomIPPrefixCollection collection = resourceGroupResource.GetCustomIPPrefixes();

            // invoke the operation
            string customIPPrefixName = "test-customipprefix";
            CustomIPPrefixResource result = await collection.GetAsync(customIPPrefixName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CustomIPPrefixData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get custom IP prefix
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetCustomIPPrefix()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/CustomIpPrefixGet.json
            // this example is just showing the usage of "CustomIPPrefixes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CustomIPPrefixResource
            CustomIPPrefixCollection collection = resourceGroupResource.GetCustomIPPrefixes();

            // invoke the operation
            string customIPPrefixName = "test-customipprefix";
            bool result = await collection.ExistsAsync(customIPPrefixName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get custom IP prefix
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetCustomIPPrefix()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/CustomIpPrefixGet.json
            // this example is just showing the usage of "CustomIPPrefixes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CustomIPPrefixResource
            CustomIPPrefixCollection collection = resourceGroupResource.GetCustomIPPrefixes();

            // invoke the operation
            string customIPPrefixName = "test-customipprefix";
            NullableResponse<CustomIPPrefixResource> response = await collection.GetIfExistsAsync(customIPPrefixName);
            CustomIPPrefixResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CustomIPPrefixData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create custom IP prefix allocation method
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateCustomIPPrefixAllocationMethod()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/CustomIpPrefixCreateCustomizedValues.json
            // this example is just showing the usage of "CustomIPPrefixes_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CustomIPPrefixResource
            CustomIPPrefixCollection collection = resourceGroupResource.GetCustomIPPrefixes();

            // invoke the operation
            string customIPPrefixName = "test-customipprefix";
            CustomIPPrefixData data = new CustomIPPrefixData()
            {
                Cidr = "0.0.0.0/24",
                Location = new AzureLocation("westus"),
            };
            ArmOperation<CustomIPPrefixResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, customIPPrefixName, data);
            CustomIPPrefixResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CustomIPPrefixData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List resource group Custom IP prefixes
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListResourceGroupCustomIPPrefixes()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-06-01/examples/CustomIpPrefixList.json
            // this example is just showing the usage of "CustomIPPrefixes_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CustomIPPrefixResource
            CustomIPPrefixCollection collection = resourceGroupResource.GetCustomIPPrefixes();

            // invoke the operation and iterate over the result
            await foreach (CustomIPPrefixResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CustomIPPrefixData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
