# Example: Managing the cdn origin groups

>Note: Before getting started with the samples, go through the [prerequisites](https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/resourcemanager/Azure.ResourceManager#prerequisites).

Namespaces for this example:
```C# Snippet:Manage_OriginGroups_Namespaces
using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Cdn.Models;
```

When you first create your ARM client, choose the subscription you're going to work in. There's a convenient `DefaultSubscription` property that returns the default subscription configured for your user:

```C# Snippet:Readme_DefaultSubscription
ArmClient armClient = new ArmClient(new DefaultAzureCredential());
Subscription subscription = await armClient.GetDefaultSubscriptionAsync();
```

This is a scoped operations object, and any operations you perform will be done under that subscription. From this object, you have access to all children via container objects. Or you can access individual children by ID.

```C# Snippet:Readme_GetResourceGroupCollection
ResourceGroupCollection rgCollection = subscription.GetResourceGroups();
// With the collection, we can create a new resource group with a specific name
string rgName = "myRgName";
AzureLocation location = AzureLocation.WestUS2;
ArmOperation<ResourceGroup> lro = await rgCollection.CreateOrUpdateAsync(WaitUntil.Completed, rgName, new ResourceGroupData(location));
ResourceGroup resourceGroup = lro.Value;
```

Now that we have the resource group created, we can manage the cdn origin group inside this resource group.

***Create a cdn origin group***

```C# Snippet:Managing_OriginGroups_CreateAnOriginGroup
// Create a new cdn profile
string profileName = "myProfile";
var input1 = new ProfileData(AzureLocation.WestUS, new CdnSku { Name = CdnSkuName.StandardMicrosoft });
ArmOperation<Profile> lro1 = await resourceGroup.GetProfiles().CreateOrUpdateAsync(WaitUntil.Completed, profileName, input1);
Profile profile = lro1.Value;
// Get the cdn endpoint collection from the specific profile and create an endpoint
string endpointName = "myEndpoint";
var input2 = new CdnEndpointData(AzureLocation.WestUS)
{
    IsHttpAllowed = true,
    IsHttpsAllowed = true,
    OptimizationType = OptimizationType.GeneralWebDelivery
};
DeepCreatedOrigin deepCreatedOrigin = new DeepCreatedOrigin("myOrigin")
{
    HostName = "testsa4dotnetsdk.blob.core.windows.net",
    Priority = 3,
    Weight = 100
};
input2.Origins.Add(deepCreatedOrigin);
ArmOperation<CdnEndpoint> lro2 = await profile.GetCdnEndpoints().CreateOrUpdateAsync(WaitUntil.Completed, endpointName, input2);
CdnEndpoint endpoint = lro2.Value;
// Get the cdn origin group collection from the specific endpoint and create an origin group
string originGroupName = "myOriginGroup";
var input3 = new CdnOriginGroupData();
input3.Origins.Add(new WritableSubResource
{
    Id = new ResourceIdentifier($"{endpoint.Id}/origins/myOrigin")
});
ArmOperation<CdnOriginGroup> lro3 = await endpoint.GetCdnOriginGroups().CreateOrUpdateAsync(WaitUntil.Completed, originGroupName, input3);
CdnOriginGroup originGroup = lro3.Value;
```

***List all cdn origin groups***

```C# Snippet:Managing_OriginGroups_ListAllOriginGroups
// First we need to get the cdn origin group collection from the specific endpoint
Profile profile = await resourceGroup.GetProfiles().GetAsync("myProfile");
CdnEndpoint endpoint = await profile.GetCdnEndpoints().GetAsync("myEndpoint");
CdnOriginGroupCollection originGroupCollection = endpoint.GetCdnOriginGroups();
// With GetAllAsync(), we can get a list of the origin group in the collection
AsyncPageable<CdnOriginGroup> response = originGroupCollection.GetAllAsync();
await foreach (CdnOriginGroup originGroup in response)
{
    Console.WriteLine(originGroup.Data.Name);
}
```

***Update a cdn origin group***

```C# Snippet:Managing_OriginGroups_UpdateAnOriginGroup
// First we need to get the cdn origin group collection from the specific endpoint
Profile profile = await resourceGroup.GetProfiles().GetAsync("myProfile");
CdnEndpoint endpoint = await profile.GetCdnEndpoints().GetAsync("myEndpoint");
CdnOriginGroupCollection originGroupCollection = endpoint.GetCdnOriginGroups();
// Now we can get the origin group with GetAsync()
CdnOriginGroup originGroup = await originGroupCollection.GetAsync("myOriginGroup");
// With UpdateAsync(), we can update the origin group
PatchableCdnOriginGroupData input = new PatchableCdnOriginGroupData()
{
    HealthProbeSettings = new HealthProbeParameters
    {
        ProbePath = "/healthz",
        ProbeRequestType = HealthProbeRequestType.Head,
        ProbeProtocol = ProbeProtocol.Https,
        ProbeIntervalInSeconds = 60
    }
};
ArmOperation<CdnOriginGroup> lro = await originGroup.UpdateAsync(WaitUntil.Completed, input);
originGroup = lro.Value;
```

***Delete a cdn origin group***

```C# Snippet:Managing_OriginGroups_DeleteAnOriginGroup
// First we need to get the cdn origin group collection from the specific endpoint
Profile profile = await resourceGroup.GetProfiles().GetAsync("myProfile");
CdnEndpoint endpoint = await profile.GetCdnEndpoints().GetAsync("myEndpoint");
CdnOriginGroupCollection originGroupCollection = endpoint.GetCdnOriginGroups();
// Now we can get the origin group with GetAsync()
CdnOriginGroup originGroup = await originGroupCollection.GetAsync("myOriginGroup");
// With DeleteAsync(), we can delete the origin group
await originGroup.DeleteAsync(WaitUntil.Completed);
```


## Next steps
Take a look at the [Managing Azure Front Door Rules](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/cdn/Azure.ResourceManager.Cdn/samples/Sample2_ManagingAfdRules.md) samples.
