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
using Azure.ResourceManager.RecoveryServicesSiteRecovery;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Samples
{
    public partial class Sample_ProtectionContainerMappingResource
    {
        // Gets a protection container mapping.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsAProtectionContainerMapping()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-08-01/examples/ReplicationProtectionContainerMappings_Get.json
            // this example is just showing the usage of "ReplicationProtectionContainerMappings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProtectionContainerMappingResource created on azure
            // for more information of creating ProtectionContainerMappingResource, please refer to the document of ProtectionContainerMappingResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            string protectionContainerName = "cloud_6d224fc6-f326-5d35-96de-fbf51efb3179";
            string mappingName = "cloud1protectionprofile1";
            ResourceIdentifier protectionContainerMappingResourceId = ProtectionContainerMappingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName, mappingName);
            ProtectionContainerMappingResource protectionContainerMapping = client.GetProtectionContainerMappingResource(protectionContainerMappingResourceId);

            // invoke the operation
            ProtectionContainerMappingResource result = await protectionContainerMapping.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProtectionContainerMappingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Purge protection container mapping.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_PurgeProtectionContainerMapping()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-08-01/examples/ReplicationProtectionContainerMappings_Purge.json
            // this example is just showing the usage of "ReplicationProtectionContainerMappings_Purge" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProtectionContainerMappingResource created on azure
            // for more information of creating ProtectionContainerMappingResource, please refer to the document of ProtectionContainerMappingResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            string protectionContainerName = "cloud_6d224fc6-f326-5d35-96de-fbf51efb3179";
            string mappingName = "cloud1protectionprofile1";
            ResourceIdentifier protectionContainerMappingResourceId = ProtectionContainerMappingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName, mappingName);
            ProtectionContainerMappingResource protectionContainerMapping = client.GetProtectionContainerMappingResource(protectionContainerMappingResourceId);

            // invoke the operation
            await protectionContainerMapping.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Update protection container mapping.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateProtectionContainerMapping()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-08-01/examples/ReplicationProtectionContainerMappings_Update.json
            // this example is just showing the usage of "ReplicationProtectionContainerMappings_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProtectionContainerMappingResource created on azure
            // for more information of creating ProtectionContainerMappingResource, please refer to the document of ProtectionContainerMappingResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            string protectionContainerName = "cloud_6d224fc6-f326-5d35-96de-fbf51efb3179";
            string mappingName = "cloud1protectionprofile1";
            ResourceIdentifier protectionContainerMappingResourceId = ProtectionContainerMappingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName, mappingName);
            ProtectionContainerMappingResource protectionContainerMapping = client.GetProtectionContainerMappingResource(protectionContainerMappingResourceId);

            // invoke the operation
            ProtectionContainerMappingPatch patch = new ProtectionContainerMappingPatch()
            {
                ProviderSpecificContent = new A2AUpdateContainerMappingContent()
                {
                    AgentAutoUpdateStatus = SiteRecoveryAgentAutoUpdateStatus.Enabled,
                    AutomationAccountArmId = new ResourceIdentifier("/subscriptions/c183865e-6077-46f2-a3b1-deb0f4f4650a/resourceGroups/automationrg1/providers/Microsoft.Automation/automationAccounts/automationaccount1"),
                },
            };
            ArmOperation<ProtectionContainerMappingResource> lro = await protectionContainerMapping.UpdateAsync(WaitUntil.Completed, patch);
            ProtectionContainerMappingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProtectionContainerMappingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Remove protection container mapping.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_RemoveProtectionContainerMapping()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-08-01/examples/ReplicationProtectionContainerMappings_Delete.json
            // this example is just showing the usage of "ReplicationProtectionContainerMappings_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProtectionContainerMappingResource created on azure
            // for more information of creating ProtectionContainerMappingResource, please refer to the document of ProtectionContainerMappingResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            string protectionContainerName = "cloud_6d224fc6-f326-5d35-96de-fbf51efb3179";
            string mappingName = "cloud1protectionprofile1";
            ResourceIdentifier protectionContainerMappingResourceId = ProtectionContainerMappingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName, mappingName);
            ProtectionContainerMappingResource protectionContainerMapping = client.GetProtectionContainerMappingResource(protectionContainerMappingResourceId);

            // invoke the operation
            RemoveProtectionContainerMappingContent content = new RemoveProtectionContainerMappingContent();
            await protectionContainerMapping.DeleteAsync(WaitUntil.Completed, content);

            Console.WriteLine($"Succeeded");
        }

        // Gets the list of all protection container mappings in a vault.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetProtectionContainerMappings_GetsTheListOfAllProtectionContainerMappingsInAVault()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-08-01/examples/ReplicationProtectionContainerMappings_List.json
            // this example is just showing the usage of "ReplicationProtectionContainerMappings_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            string resourceName = "vault1";
            await foreach (ProtectionContainerMappingResource item in resourceGroupResource.GetProtectionContainerMappingsAsync(resourceName))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ProtectionContainerMappingData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
