﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#region Snippet:Manage_ManagedInstance_Namespaces
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Sql.Models;
using NUnit.Framework;
#endregion  Snippet:Manage_ManagedInstance_Namespaces

namespace Azure.ResourceManager.Sql.Tests.Samples
{
    public class Sample1_ManagingManagedInstance
    {
        private ResourceGroup resourceGroup;

        [SetUp]
        protected async Task initialize()
        {
            ArmClient armClient = new ArmClient(new DefaultAzureCredential());
            Subscription subscription = armClient.GetDefaultSubscription();

            ResourceGroupCollection rgCollection = subscription.GetResourceGroups();
            // With the Collection, we can create a new resource group with an specific name
            string rgName = "myRgName";
            AzureLocation location = AzureLocation.WestUS2;
            ResourceGroup resourceGroup = await rgCollection.CreateOrUpdate(WaitUntil.Completed, rgName, new ResourceGroupData(location)).WaitForCompletionAsync();

            this.resourceGroup = resourceGroup;
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate()
        {
            #region Snippet:Managing_Sql_CreateAManagedInstance
            //1. create NetworkSecurityGroup
            NetworkSecurityGroupData networkSecurityGroupData = new NetworkSecurityGroupData()
            {
                Location = AzureLocation.WestUS2,
            };
            string networkSecurityGroupName = "myNetworkSecurityGroup";
            var networkSecurityGroup = await resourceGroup.GetNetworkSecurityGroups().CreateOrUpdateAsync(WaitUntil.Completed, networkSecurityGroupName, networkSecurityGroupData);

            //2. create Route table
            RouteTableData routeTableData = new RouteTableData()
            {
                Location = AzureLocation.WestUS2,
            };
            string routeTableName = "myRouteTable";
            var routeTable = await resourceGroup.GetRouteTables().CreateOrUpdateAsync(WaitUntil.Completed, routeTableName, routeTableData);

            //3. create vnet(subnet binding NetworkSecurityGroup and RouteTable)
            var vnetData = new VirtualNetworkData()
            {
                Location = AzureLocation.WestUS2,
                Subnets =
                {
                    new SubnetData()
                    {
                        Name = "ManagedInstance",
                        AddressPrefix = "10.10.2.0/24",
                        Delegations =
                        {
                            new Delegation() { ServiceName  = "Microsoft.Sql/managedInstances",Name="Microsoft.Sql/managedInstances" ,Type="Microsoft.Sql"}
                        },
                        RouteTable = new RouteTableData(){ Id = routeTable.Value.Data.Id.ToString() },
                        NetworkSecurityGroup = new NetworkSecurityGroupData(){ Id = networkSecurityGroup.Value.Data.Id.ToString() },
                    }
                },
            };
            vnetData.AddressPrefixes.Add("10.10.0.0/16");
            string vnetName = "myVnet";
            var vnet = await resourceGroup.GetVirtualNetworks().CreateOrUpdateAsync(WaitUntil.Completed, vnetName, vnetData);
            string subnetId = $"{vnet.Value.Data.Id}/subnets/ManagedInstance";

            //4. create ManagedInstance
            ManagedInstanceData data = new ManagedInstanceData(AzureLocation.WestUS2)
            {
                AdministratorLogin = "myAdministratorLogin",
                AdministratorLoginPassword = "abcdef123456789*",
                SubnetId = subnetId,
                PublicDataEndpointEnabled = false,
                MaintenanceConfigurationId = "/subscriptions/0000-0000-0000-0000/providers/Microsoft.Maintenance/publicMaintenanceConfigurations/SQL_Default",
                ProxyOverride = new ManagedInstanceProxyOverride("Proxy") { },
                TimezoneId = "UTC",
                StorageAccountType = new StorageAccountType("GRS"),
                ZoneRedundant = false,
            };
            string managedInstanceName = "myManagedInstance";
            var managedInstanceLro = await resourceGroup.GetManagedInstances().CreateOrUpdateAsync(WaitUntil.Completed, managedInstanceName, data);
            ManagedInstance managedInstance = managedInstanceLro.Value;
            #endregion
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public async Task List()
        {
            #region Snippet:Managing_Sql_ListAllManagedInstances
            ManagedInstanceCollection managedInstanceCollection = resourceGroup.GetManagedInstances();

            AsyncPageable<ManagedInstance> response = managedInstanceCollection.GetAllAsync();
            await foreach (ManagedInstance managedInstance in response)
            {
                Console.WriteLine(managedInstance.Data.Name);
            }
            #endregion
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public async Task Get()
        {
            #region Snippet:Managing_Sql_GetAManagedInstance
            ManagedInstanceCollection managedInstanceCollection = resourceGroup.GetManagedInstances();

            ManagedInstance managedInstance = await managedInstanceCollection.GetAsync("myManagedInstance");
            Console.WriteLine(managedInstance.Data.Name);
            #endregion
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists()
        {
            #region Snippet:Managing_Sql_GetAManagedInstanceIfExists
            ManagedInstanceCollection managedInstanceCollection = resourceGroup.GetManagedInstances();

            ManagedInstance managedInstance = await managedInstanceCollection.GetIfExistsAsync("foo");
            if (managedInstance != null)
            {
                Console.WriteLine(managedInstance.Data.Name);
            }

            if (await managedInstanceCollection.ExistsAsync("bar"))
            {
                Console.WriteLine("Virtual network 'bar' exists.");
            }
            #endregion
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public async Task DeleteManagedInstance()
        {
            #region Snippet:Managing_Sql_DeleteAManagedInstance
            ManagedInstanceCollection managedInstanceCollection = resourceGroup.GetManagedInstances();

            ManagedInstance managedInstance = await managedInstanceCollection.GetAsync("myManagedInstance");
            await managedInstance.DeleteAsync(WaitUntil.Completed);
            #endregion
        }
    }
}
