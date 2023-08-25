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
using Azure.ResourceManager.Sphere;

namespace Azure.ResourceManager.Sphere.Samples
{
    public partial class Sample_SphereImageCollection
    {
        // Images_ListByCatalog
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ImagesListByCatalog()
        {
            // Generated from example definition: specification/sphere/resource-manager/Microsoft.AzureSphere/preview/2022-09-01-preview/examples/GetImages.json
            // this example is just showing the usage of "Images_ListByCatalog" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SphereCatalogResource created on azure
            // for more information of creating SphereCatalogResource, please refer to the document of SphereCatalogResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "MyResourceGroup1";
            string catalogName = "MyCatalog1";
            ResourceIdentifier sphereCatalogResourceId = SphereCatalogResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, catalogName);
            SphereCatalogResource sphereCatalog = client.GetSphereCatalogResource(sphereCatalogResourceId);

            // get the collection of this SphereImageResource
            SphereImageCollection collection = sphereCatalog.GetSphereImages();

            // invoke the operation and iterate over the result
            await foreach (SphereImageResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SphereImageData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Images_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ImagesGet()
        {
            // Generated from example definition: specification/sphere/resource-manager/Microsoft.AzureSphere/preview/2022-09-01-preview/examples/GetImage.json
            // this example is just showing the usage of "Images_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SphereCatalogResource created on azure
            // for more information of creating SphereCatalogResource, please refer to the document of SphereCatalogResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "MyResourceGroup1";
            string catalogName = "MyCatalog1";
            ResourceIdentifier sphereCatalogResourceId = SphereCatalogResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, catalogName);
            SphereCatalogResource sphereCatalog = client.GetSphereCatalogResource(sphereCatalogResourceId);

            // get the collection of this SphereImageResource
            SphereImageCollection collection = sphereCatalog.GetSphereImages();

            // invoke the operation
            string imageName = "myImageId";
            SphereImageResource result = await collection.GetAsync(imageName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SphereImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Images_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ImagesGet()
        {
            // Generated from example definition: specification/sphere/resource-manager/Microsoft.AzureSphere/preview/2022-09-01-preview/examples/GetImage.json
            // this example is just showing the usage of "Images_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SphereCatalogResource created on azure
            // for more information of creating SphereCatalogResource, please refer to the document of SphereCatalogResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "MyResourceGroup1";
            string catalogName = "MyCatalog1";
            ResourceIdentifier sphereCatalogResourceId = SphereCatalogResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, catalogName);
            SphereCatalogResource sphereCatalog = client.GetSphereCatalogResource(sphereCatalogResourceId);

            // get the collection of this SphereImageResource
            SphereImageCollection collection = sphereCatalog.GetSphereImages();

            // invoke the operation
            string imageName = "myImageId";
            bool result = await collection.ExistsAsync(imageName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Image_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ImageCreateOrUpdate()
        {
            // Generated from example definition: specification/sphere/resource-manager/Microsoft.AzureSphere/preview/2022-09-01-preview/examples/PutImage.json
            // this example is just showing the usage of "Images_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SphereCatalogResource created on azure
            // for more information of creating SphereCatalogResource, please refer to the document of SphereCatalogResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "MyResourceGroup1";
            string catalogName = "MyCatalog1";
            ResourceIdentifier sphereCatalogResourceId = SphereCatalogResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, catalogName);
            SphereCatalogResource sphereCatalog = client.GetSphereCatalogResource(sphereCatalogResourceId);

            // get the collection of this SphereImageResource
            SphereImageCollection collection = sphereCatalog.GetSphereImages();

            // invoke the operation
            string imageName = "default";
            SphereImageData data = new SphereImageData()
            {
                Image = "bXliYXNlNjRzdHJpbmc=",
            };
            ArmOperation<SphereImageResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, imageName, data);
            SphereImageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SphereImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
