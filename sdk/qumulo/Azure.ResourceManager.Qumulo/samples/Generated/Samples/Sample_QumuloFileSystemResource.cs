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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Qumulo;
using Azure.ResourceManager.Qumulo.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Qumulo.Samples
{
    public partial class Sample_QumuloFileSystemResource
    {
        // FileSystems_ListBySubscription_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetQumuloFileSystemResources_FileSystemsListBySubscriptionMaximumSetGen()
        {
            // Generated from example definition: specification/liftrqumulo/resource-manager/Qumulo.Storage/stable/2022-10-12/examples/FileSystems_ListBySubscription_MaximumSet_Gen.json
            // this example is just showing the usage of "FileSystems_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "ulseeqylxb";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (QumuloFileSystemResource item in subscriptionResource.GetQumuloFileSystemResourcesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                QumuloFileSystemResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // FileSystems_ListBySubscription_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetQumuloFileSystemResources_FileSystemsListBySubscriptionMinimumSetGen()
        {
            // Generated from example definition: specification/liftrqumulo/resource-manager/Qumulo.Storage/stable/2022-10-12/examples/FileSystems_ListBySubscription_MinimumSet_Gen.json
            // this example is just showing the usage of "FileSystems_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "aaaaaaa";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (QumuloFileSystemResource item in subscriptionResource.GetQumuloFileSystemResourcesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                QumuloFileSystemResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // FileSystems_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_FileSystemsGetMaximumSetGen()
        {
            // Generated from example definition: specification/liftrqumulo/resource-manager/Qumulo.Storage/stable/2022-10-12/examples/FileSystems_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "FileSystems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this QumuloFileSystemResource created on azure
            // for more information of creating QumuloFileSystemResource, please refer to the document of QumuloFileSystemResource
            string subscriptionId = "ulseeqylxb";
            string resourceGroupName = "rgQumulo";
            string fileSystemName = "nauwwbfoqehgbhdsmkewoboyxeqg";
            ResourceIdentifier qumuloFileSystemResourceId = QumuloFileSystemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fileSystemName);
            QumuloFileSystemResource qumuloFileSystemResource = client.GetQumuloFileSystemResource(qumuloFileSystemResourceId);

            // invoke the operation
            QumuloFileSystemResource result = await qumuloFileSystemResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            QumuloFileSystemResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // FileSystems_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_FileSystemsGetMinimumSetGen()
        {
            // Generated from example definition: specification/liftrqumulo/resource-manager/Qumulo.Storage/stable/2022-10-12/examples/FileSystems_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "FileSystems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this QumuloFileSystemResource created on azure
            // for more information of creating QumuloFileSystemResource, please refer to the document of QumuloFileSystemResource
            string subscriptionId = "aaaaaaa";
            string resourceGroupName = "rgQumulo";
            string fileSystemName = "aaaaaaaaaaaaaaaaa";
            ResourceIdentifier qumuloFileSystemResourceId = QumuloFileSystemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fileSystemName);
            QumuloFileSystemResource qumuloFileSystemResource = client.GetQumuloFileSystemResource(qumuloFileSystemResourceId);

            // invoke the operation
            QumuloFileSystemResource result = await qumuloFileSystemResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            QumuloFileSystemResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // FileSystems_Update_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_FileSystemsUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/liftrqumulo/resource-manager/Qumulo.Storage/stable/2022-10-12/examples/FileSystems_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "FileSystems_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this QumuloFileSystemResource created on azure
            // for more information of creating QumuloFileSystemResource, please refer to the document of QumuloFileSystemResource
            string subscriptionId = "ulseeqylxb";
            string resourceGroupName = "rgQumulo";
            string fileSystemName = "nauwwbfoqehgbhdsmkewoboyxeqg";
            ResourceIdentifier qumuloFileSystemResourceId = QumuloFileSystemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fileSystemName);
            QumuloFileSystemResource qumuloFileSystemResource = client.GetQumuloFileSystemResource(qumuloFileSystemResourceId);

            // invoke the operation
            QumuloFileSystemResourcePatch patch = new QumuloFileSystemResourcePatch()
            {
                Identity = new ManagedServiceIdentity("None")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("key4522")] = new UserAssignedIdentity(),
},
                },
                Tags =
{
["key7534"] = "jsgqvqbagquvxowbrkanyhzvo",
},
                Properties = new FileSystemResourceUpdateProperties()
                {
                    MarketplaceDetails = new MarketplaceDetails("x", "eiyhbmpwgezcmzrrfoiskuxlcvwojf", "wfmokfdjbwpjhz")
                    {
                        MarketplaceSubscriptionId = "ujrcqvxfnhxxheoth",
                    },
                    UserDetailsEmail = "aa",
                    DelegatedSubnetId = new ResourceIdentifier("vjfirtaljehawmflyfianw"),
                    ClusterLoginUri = new Uri("adabmuthwrbjshzfbo"),
                    PrivateIPs =
{
"eugjqbaoucgjsopzfrq"
},
                },
            };
            QumuloFileSystemResource result = await qumuloFileSystemResource.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            QumuloFileSystemResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // FileSystems_Update_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_FileSystemsUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/liftrqumulo/resource-manager/Qumulo.Storage/stable/2022-10-12/examples/FileSystems_Update_MinimumSet_Gen.json
            // this example is just showing the usage of "FileSystems_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this QumuloFileSystemResource created on azure
            // for more information of creating QumuloFileSystemResource, please refer to the document of QumuloFileSystemResource
            string subscriptionId = "aaaaaaa";
            string resourceGroupName = "rgQumulo";
            string fileSystemName = "aaaaaaaaaaaaaaaaa";
            ResourceIdentifier qumuloFileSystemResourceId = QumuloFileSystemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fileSystemName);
            QumuloFileSystemResource qumuloFileSystemResource = client.GetQumuloFileSystemResource(qumuloFileSystemResourceId);

            // invoke the operation
            QumuloFileSystemResourcePatch patch = new QumuloFileSystemResourcePatch();
            QumuloFileSystemResource result = await qumuloFileSystemResource.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            QumuloFileSystemResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // FileSystems_Delete_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_FileSystemsDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/liftrqumulo/resource-manager/Qumulo.Storage/stable/2022-10-12/examples/FileSystems_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "FileSystems_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this QumuloFileSystemResource created on azure
            // for more information of creating QumuloFileSystemResource, please refer to the document of QumuloFileSystemResource
            string subscriptionId = "ulseeqylxb";
            string resourceGroupName = "rgQumulo";
            string fileSystemName = "nauwwbfoqehgbhdsmkewoboyxeqg";
            ResourceIdentifier qumuloFileSystemResourceId = QumuloFileSystemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fileSystemName);
            QumuloFileSystemResource qumuloFileSystemResource = client.GetQumuloFileSystemResource(qumuloFileSystemResourceId);

            // invoke the operation
            await qumuloFileSystemResource.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // FileSystems_Delete_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_FileSystemsDeleteMinimumSetGen()
        {
            // Generated from example definition: specification/liftrqumulo/resource-manager/Qumulo.Storage/stable/2022-10-12/examples/FileSystems_Delete_MinimumSet_Gen.json
            // this example is just showing the usage of "FileSystems_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this QumuloFileSystemResource created on azure
            // for more information of creating QumuloFileSystemResource, please refer to the document of QumuloFileSystemResource
            string subscriptionId = "ulseeqylxb";
            string resourceGroupName = "rgQumulo";
            string fileSystemName = "nauwwbfoqehgbhdsmkewoboyxeqg";
            ResourceIdentifier qumuloFileSystemResourceId = QumuloFileSystemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fileSystemName);
            QumuloFileSystemResource qumuloFileSystemResource = client.GetQumuloFileSystemResource(qumuloFileSystemResourceId);

            // invoke the operation
            await qumuloFileSystemResource.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
