// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    internal partial class ResourceGroupExtensionClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ResourcePools in the ResourcePool. </summary>
        /// <returns> An object representing collection of ResourcePools and their operations over a ResourcePool. </returns>
        public virtual ResourcePoolCollection GetResourcePools()
        {
            return new ResourcePoolCollection(Client, Id);
        }

        /// <summary> Gets a collection of VMwareClusters in the VMwareCluster. </summary>
        /// <returns> An object representing collection of VMwareClusters and their operations over a VMwareCluster. </returns>
        public virtual VMwareClusterCollection GetVMwareClusters()
        {
            return new VMwareClusterCollection(Client, Id);
        }

        /// <summary> Gets a collection of VMwareHosts in the VMwareHost. </summary>
        /// <returns> An object representing collection of VMwareHosts and their operations over a VMwareHost. </returns>
        public virtual VMwareHostCollection GetVMwareHosts()
        {
            return new VMwareHostCollection(Client, Id);
        }

        /// <summary> Gets a collection of VMwareDatastores in the VMwareDatastore. </summary>
        /// <returns> An object representing collection of VMwareDatastores and their operations over a VMwareDatastore. </returns>
        public virtual VMwareDatastoreCollection GetVMwareDatastores()
        {
            return new VMwareDatastoreCollection(Client, Id);
        }

        /// <summary> Gets a collection of VCenters in the VCenter. </summary>
        /// <returns> An object representing collection of VCenters and their operations over a VCenter. </returns>
        public virtual VCenterCollection GetVCenters()
        {
            return new VCenterCollection(Client, Id);
        }

        /// <summary> Gets a collection of VirtualMachines in the VirtualMachine. </summary>
        /// <returns> An object representing collection of VirtualMachines and their operations over a VirtualMachine. </returns>
        public virtual VirtualMachineCollection GetVirtualMachines()
        {
            return new VirtualMachineCollection(Client, Id);
        }

        /// <summary> Gets a collection of VirtualMachineTemplates in the VirtualMachineTemplate. </summary>
        /// <returns> An object representing collection of VirtualMachineTemplates and their operations over a VirtualMachineTemplate. </returns>
        public virtual VirtualMachineTemplateCollection GetVirtualMachineTemplates()
        {
            return new VirtualMachineTemplateCollection(Client, Id);
        }

        /// <summary> Gets a collection of VirtualNetworks in the VirtualNetwork. </summary>
        /// <returns> An object representing collection of VirtualNetworks and their operations over a VirtualNetwork. </returns>
        public virtual VirtualNetworkCollection GetVirtualNetworks()
        {
            return new VirtualNetworkCollection(Client, Id);
        }
    }
}
