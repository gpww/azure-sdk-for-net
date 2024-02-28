// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Samples
{
    public partial class Sample_StorageClassificationResource
    {
        // Gets the details of a storage classification.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsTheDetailsOfAStorageClassification()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-08-01/examples/ReplicationStorageClassifications_Get.json
            // this example is just showing the usage of "ReplicationStorageClassifications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageClassificationResource created on azure
            // for more information of creating StorageClassificationResource, please refer to the document of StorageClassificationResource
            string subscriptionId = "9112a37f-0f3e-46ec-9c00-060c6edca071";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "2a48e3770ac08aa2be8bfbd94fcfb1cbf2dcc487b78fb9d3bd778304441b06a0";
            string storageClassificationName = "8891569e-aaef-4a46-a4a0-78c14f2d7b09";
            ResourceIdentifier storageClassificationResourceId = StorageClassificationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, storageClassificationName);
            StorageClassificationResource storageClassification = client.GetStorageClassificationResource(storageClassificationResourceId);

            // invoke the operation
            StorageClassificationResource result = await storageClassification.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageClassificationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets the list of storage classification objects under a vault.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetStorageClassifications_GetsTheListOfStorageClassificationObjectsUnderAVault()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-08-01/examples/ReplicationStorageClassifications_List.json
            // this example is just showing the usage of "ReplicationStorageClassifications_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "9112a37f-0f3e-46ec-9c00-060c6edca071";
            string resourceGroupName = "resourceGroupPS1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            string resourceName = "vault1";
            await foreach (StorageClassificationResource item in resourceGroupResource.GetStorageClassificationsAsync(resourceName))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StorageClassificationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
