namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    public static partial class ArmClientExtensions
    {
        public static Azure.ResourceManager.ConnectedVMwarevSphere.GuestAgent GetGuestAgent(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.HybridIdentityMetadata GetHybridIdentityMetadata(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.InventoryItem GetInventoryItem(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension GetMachineExtension(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool GetResourcePool(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.VCenter GetVCenter(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine GetVirtualMachine(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate GetVirtualMachineTemplate(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork GetVirtualNetwork(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster GetVMwareCluster(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore GetVMwareDatastore(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost GetVMwareHost(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class GuestAgent : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected GuestAgent() { }
        public virtual Azure.ResourceManager.ConnectedVMwarevSphere.GuestAgentData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string virtualMachineName, string name) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.GuestAgent> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.GuestAgent>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class GuestAgentCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.GuestAgent>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.GuestAgent>, System.Collections.IEnumerable
    {
        protected GuestAgentCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.GuestAgent> CreateOrUpdate(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.ConnectedVMwarevSphere.GuestAgentData body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.GuestAgent>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string name, Azure.ResourceManager.ConnectedVMwarevSphere.GuestAgentData body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.GuestAgent> Get(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ConnectedVMwarevSphere.GuestAgent> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ConnectedVMwarevSphere.GuestAgent> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.GuestAgent>> GetAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.GuestAgent> GetIfExists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.GuestAgent>> GetIfExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.GuestAgent> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.GuestAgent>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.GuestAgent> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.GuestAgent>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class GuestAgentData : Azure.ResourceManager.Models.ResourceData
    {
        public GuestAgentData() { }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.GuestCredential Credentials { get { throw null; } set { } }
        public string CustomResourceName { get { throw null; } }
        public string HttpsProxy { get { throw null; } set { } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningAction? ProvisioningAction { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public string Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ConnectedVMwarevSphere.Models.ResourceStatus> Statuses { get { throw null; } }
        public string Uuid { get { throw null; } }
    }
    public partial class HybridIdentityMetadata : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected HybridIdentityMetadata() { }
        public virtual Azure.ResourceManager.ConnectedVMwarevSphere.HybridIdentityMetadataData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string virtualMachineName, string metadataName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.HybridIdentityMetadata> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.HybridIdentityMetadata>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class HybridIdentityMetadataCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.HybridIdentityMetadata>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.HybridIdentityMetadata>, System.Collections.IEnumerable
    {
        protected HybridIdentityMetadataCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.HybridIdentityMetadata> CreateOrUpdate(Azure.WaitUntil waitUntil, string metadataName, Azure.ResourceManager.ConnectedVMwarevSphere.HybridIdentityMetadataData body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.HybridIdentityMetadata>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string metadataName, Azure.ResourceManager.ConnectedVMwarevSphere.HybridIdentityMetadataData body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string metadataName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string metadataName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.HybridIdentityMetadata> Get(string metadataName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ConnectedVMwarevSphere.HybridIdentityMetadata> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ConnectedVMwarevSphere.HybridIdentityMetadata> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.HybridIdentityMetadata>> GetAsync(string metadataName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.HybridIdentityMetadata> GetIfExists(string metadataName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.HybridIdentityMetadata>> GetIfExistsAsync(string metadataName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.HybridIdentityMetadata> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.HybridIdentityMetadata>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.HybridIdentityMetadata> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.HybridIdentityMetadata>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class HybridIdentityMetadataData : Azure.ResourceManager.Models.ResourceData
    {
        public HybridIdentityMetadataData() { }
        public Azure.ResourceManager.Models.SystemAssignedServiceIdentity Identity { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
        public string PublicKey { get { throw null; } set { } }
        public string VmId { get { throw null; } set { } }
    }
    public partial class InventoryItem : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected InventoryItem() { }
        public virtual Azure.ResourceManager.ConnectedVMwarevSphere.InventoryItemData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vcenterName, string inventoryItemName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.InventoryItem> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.InventoryItem>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class InventoryItemCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.InventoryItem>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.InventoryItem>, System.Collections.IEnumerable
    {
        protected InventoryItemCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.InventoryItem> CreateOrUpdate(Azure.WaitUntil waitUntil, string inventoryItemName, Azure.ResourceManager.ConnectedVMwarevSphere.InventoryItemData body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.InventoryItem>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string inventoryItemName, Azure.ResourceManager.ConnectedVMwarevSphere.InventoryItemData body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string inventoryItemName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string inventoryItemName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.InventoryItem> Get(string inventoryItemName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ConnectedVMwarevSphere.InventoryItem> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ConnectedVMwarevSphere.InventoryItem> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.InventoryItem>> GetAsync(string inventoryItemName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.InventoryItem> GetIfExists(string inventoryItemName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.InventoryItem>> GetIfExistsAsync(string inventoryItemName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.InventoryItem> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.InventoryItem>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.InventoryItem> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.InventoryItem>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class InventoryItemData : Azure.ResourceManager.Models.ResourceData
    {
        public InventoryItemData(Azure.ResourceManager.ConnectedVMwarevSphere.Models.InventoryType inventoryType) { }
        public string Kind { get { throw null; } set { } }
        public string ManagedResourceId { get { throw null; } set { } }
        public string MoName { get { throw null; } set { } }
        public string MoRefId { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
    }
    public partial class MachineExtension : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected MachineExtension() { }
        public virtual Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtensionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string extensionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ConnectedVMwarevSphere.Models.PatchableMachineExtensionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ConnectedVMwarevSphere.Models.PatchableMachineExtensionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class MachineExtensionCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension>, System.Collections.IEnumerable
    {
        protected MachineExtensionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension> CreateOrUpdate(Azure.WaitUntil waitUntil, string extensionName, Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtensionData extensionParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string extensionName, Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtensionData extensionParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string extensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string extensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension> Get(string extensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension> GetAll(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension> GetAllAsync(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension>> GetAsync(string extensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension> GetIfExists(string extensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension>> GetIfExistsAsync(string extensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class MachineExtensionData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public MachineExtensionData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public bool? AutoUpgradeMinorVersion { get { throw null; } set { } }
        public string ForceUpdateTag { get { throw null; } set { } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.MachineExtensionPropertiesInstanceView InstanceView { get { throw null; } set { } }
        public object ProtectedSettings { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public string Publisher { get { throw null; } set { } }
        public object Settings { get { throw null; } set { } }
        public string TypeHandlerVersion { get { throw null; } set { } }
        public string TypePropertiesType { get { throw null; } set { } }
    }
    public static partial class ResourceGroupExtensions
    {
        public static Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool> GetResourcePool(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string resourcePoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool>> GetResourcePoolAsync(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string resourcePoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePoolCollection GetResourcePools(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter> GetVCenter(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string vcenterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter>> GetVCenterAsync(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string vcenterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.VCenterCollection GetVCenters(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine> GetVirtualMachine(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string virtualMachineName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine>> GetVirtualMachineAsync(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string virtualMachineName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineCollection GetVirtualMachines(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate> GetVirtualMachineTemplate(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string virtualMachineTemplateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate>> GetVirtualMachineTemplateAsync(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string virtualMachineTemplateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplateCollection GetVirtualMachineTemplates(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork> GetVirtualNetwork(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string virtualNetworkName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork>> GetVirtualNetworkAsync(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string virtualNetworkName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetworkCollection GetVirtualNetworks(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster> GetVMwareCluster(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster>> GetVMwareClusterAsync(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.VMwareClusterCollection GetVMwareClusters(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore> GetVMwareDatastore(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string datastoreName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore>> GetVMwareDatastoreAsync(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string datastoreName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastoreCollection GetVMwareDatastores(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost> GetVMwareHost(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost>> GetVMwareHostAsync(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup, string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHostCollection GetVMwareHosts(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup) { throw null; }
    }
    public partial class ResourcePool : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ResourcePool() { }
        public virtual Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePoolData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourcePoolName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, bool? force = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, bool? force = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ResourcePoolCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool>, System.Collections.IEnumerable
    {
        protected ResourcePoolCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool> CreateOrUpdate(Azure.WaitUntil waitUntil, string resourcePoolName, Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePoolData body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string resourcePoolName, Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePoolData body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string resourcePoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string resourcePoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool> Get(string resourcePoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool>> GetAsync(string resourcePoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool> GetIfExists(string resourcePoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool>> GetIfExistsAsync(string resourcePoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ResourcePoolData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public ResourcePoolData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public long? CpuLimitMHz { get { throw null; } }
        public long? CpuReservationMHz { get { throw null; } }
        public string CpuSharesLevel { get { throw null; } }
        public string CustomResourceName { get { throw null; } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.ExtendedLocation ExtendedLocation { get { throw null; } set { } }
        public string InventoryItemId { get { throw null; } set { } }
        public string Kind { get { throw null; } set { } }
        public long? MemLimitMB { get { throw null; } }
        public long? MemReservationMB { get { throw null; } }
        public string MemSharesLevel { get { throw null; } }
        public string MoName { get { throw null; } }
        public string MoRefId { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ConnectedVMwarevSphere.Models.ResourceStatus> Statuses { get { throw null; } }
        public string Uuid { get { throw null; } }
        public string VCenterId { get { throw null; } set { } }
    }
    public static partial class SubscriptionExtensions
    {
        public static Azure.Pageable<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool> GetResourcePools(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ConnectedVMwarevSphere.ResourcePool> GetResourcePoolsAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter> GetVCenters(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter> GetVCentersAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine> GetVirtualMachines(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine> GetVirtualMachinesAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate> GetVirtualMachineTemplates(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate> GetVirtualMachineTemplatesAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork> GetVirtualNetworks(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork> GetVirtualNetworksAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster> GetVMwareClusters(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster> GetVMwareClustersAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore> GetVMwareDatastores(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore> GetVMwareDatastoresAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost> GetVMwareHosts(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost> GetVMwareHostsAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class VCenter : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected VCenter() { }
        public virtual Azure.ResourceManager.ConnectedVMwarevSphere.VCenterData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vcenterName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, bool? force = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, bool? force = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.InventoryItem> GetInventoryItem(string inventoryItemName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.InventoryItem>> GetInventoryItemAsync(string inventoryItemName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ConnectedVMwarevSphere.InventoryItemCollection GetInventoryItems() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class VCenterCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter>, System.Collections.IEnumerable
    {
        protected VCenterCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter> CreateOrUpdate(Azure.WaitUntil waitUntil, string vcenterName, Azure.ResourceManager.ConnectedVMwarevSphere.VCenterData body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string vcenterName, Azure.ResourceManager.ConnectedVMwarevSphere.VCenterData body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string vcenterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string vcenterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter> Get(string vcenterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter>> GetAsync(string vcenterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter> GetIfExists(string vcenterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter>> GetIfExistsAsync(string vcenterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VCenter>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class VCenterData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public VCenterData(Azure.Core.AzureLocation location, string fqdn) : base (default(Azure.Core.AzureLocation)) { }
        public string ConnectionStatus { get { throw null; } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.VICredential Credentials { get { throw null; } set { } }
        public string CustomResourceName { get { throw null; } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.ExtendedLocation ExtendedLocation { get { throw null; } set { } }
        public string Fqdn { get { throw null; } set { } }
        public string InstanceUuid { get { throw null; } }
        public string Kind { get { throw null; } set { } }
        public int? Port { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ConnectedVMwarevSphere.Models.ResourceStatus> Statuses { get { throw null; } }
        public string Uuid { get { throw null; } }
        public string Version { get { throw null; } }
    }
    public partial class VirtualMachine : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected VirtualMachine() { }
        public virtual Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string virtualMachineName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, bool? force = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, bool? force = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ConnectedVMwarevSphere.HybridIdentityMetadataCollection GetAllHybridIdentityMetadata() { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.GuestAgent> GetGuestAgent(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.GuestAgent>> GetGuestAgentAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ConnectedVMwarevSphere.GuestAgentCollection GetGuestAgents() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.HybridIdentityMetadata> GetHybridIdentityMetadata(string metadataName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.HybridIdentityMetadata>> GetHybridIdentityMetadataAsync(string metadataName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension> GetMachineExtension(string extensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtension>> GetMachineExtensionAsync(string extensionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ConnectedVMwarevSphere.MachineExtensionCollection GetMachineExtensions() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Restart(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> RestartAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Start(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> StartAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Stop(Azure.WaitUntil waitUntil, Azure.ResourceManager.ConnectedVMwarevSphere.Models.StopVirtualMachineOptions body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> StopAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ConnectedVMwarevSphere.Models.StopVirtualMachineOptions body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ConnectedVMwarevSphere.Models.PatchableVirtualMachineData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ConnectedVMwarevSphere.Models.PatchableVirtualMachineData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class VirtualMachineCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine>, System.Collections.IEnumerable
    {
        protected VirtualMachineCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine> CreateOrUpdate(Azure.WaitUntil waitUntil, string virtualMachineName, Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineData body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string virtualMachineName, Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineData body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string virtualMachineName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string virtualMachineName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine> Get(string virtualMachineName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine>> GetAsync(string virtualMachineName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine> GetIfExists(string virtualMachineName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine>> GetIfExistsAsync(string virtualMachineName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachine>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class VirtualMachineData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public VirtualMachineData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string CustomResourceName { get { throw null; } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.ExtendedLocation ExtendedLocation { get { throw null; } set { } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.FirmwareType? FirmwareType { get { throw null; } set { } }
        public string FolderPath { get { throw null; } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.GuestAgentProfile GuestAgentProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.HardwareProfile HardwareProfile { get { throw null; } set { } }
        public Azure.ResourceManager.Models.SystemAssignedServiceIdentity Identity { get { throw null; } set { } }
        public string InstanceUuid { get { throw null; } }
        public string InventoryItemId { get { throw null; } set { } }
        public string Kind { get { throw null; } set { } }
        public string MoName { get { throw null; } }
        public string MoRefId { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ConnectedVMwarevSphere.Models.NetworkInterface> NetworkInterfaces { get { throw null; } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.OSProfile OSProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.PlacementProfile PlacementProfile { get { throw null; } set { } }
        public string PowerState { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
        public string ResourcePoolId { get { throw null; } set { } }
        public string SmbiosUuid { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ConnectedVMwarevSphere.Models.ResourceStatus> Statuses { get { throw null; } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.StorageProfile StorageProfile { get { throw null; } set { } }
        public string TemplateId { get { throw null; } set { } }
        public string Uuid { get { throw null; } }
        public string VCenterId { get { throw null; } set { } }
        public string VmId { get { throw null; } }
    }
    public partial class VirtualMachineTemplate : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected VirtualMachineTemplate() { }
        public virtual Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplateData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string virtualMachineTemplateName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, bool? force = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, bool? force = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class VirtualMachineTemplateCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate>, System.Collections.IEnumerable
    {
        protected VirtualMachineTemplateCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate> CreateOrUpdate(Azure.WaitUntil waitUntil, string virtualMachineTemplateName, Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplateData body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string virtualMachineTemplateName, Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplateData body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string virtualMachineTemplateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string virtualMachineTemplateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate> Get(string virtualMachineTemplateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate>> GetAsync(string virtualMachineTemplateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate> GetIfExists(string virtualMachineTemplateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate>> GetIfExistsAsync(string virtualMachineTemplateName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualMachineTemplate>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class VirtualMachineTemplateData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public VirtualMachineTemplateData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string CustomResourceName { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ConnectedVMwarevSphere.Models.VirtualDisk> Disks { get { throw null; } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.ExtendedLocation ExtendedLocation { get { throw null; } set { } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.FirmwareType? FirmwareType { get { throw null; } }
        public string FolderPath { get { throw null; } }
        public string InventoryItemId { get { throw null; } set { } }
        public string Kind { get { throw null; } set { } }
        public int? MemorySizeMB { get { throw null; } }
        public string MoName { get { throw null; } }
        public string MoRefId { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ConnectedVMwarevSphere.Models.NetworkInterface> NetworkInterfaces { get { throw null; } }
        public int? NumCoresPerSocket { get { throw null; } }
        public int? NumCpus { get { throw null; } }
        public string OSName { get { throw null; } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.OSType? OSType { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ConnectedVMwarevSphere.Models.ResourceStatus> Statuses { get { throw null; } }
        public string ToolsVersion { get { throw null; } }
        public string ToolsVersionStatus { get { throw null; } }
        public string Uuid { get { throw null; } }
        public string VCenterId { get { throw null; } set { } }
    }
    public partial class VirtualNetwork : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected VirtualNetwork() { }
        public virtual Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetworkData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string virtualNetworkName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, bool? force = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, bool? force = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class VirtualNetworkCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork>, System.Collections.IEnumerable
    {
        protected VirtualNetworkCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork> CreateOrUpdate(Azure.WaitUntil waitUntil, string virtualNetworkName, Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetworkData body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string virtualNetworkName, Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetworkData body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string virtualNetworkName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string virtualNetworkName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork> Get(string virtualNetworkName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork>> GetAsync(string virtualNetworkName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork> GetIfExists(string virtualNetworkName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork>> GetIfExistsAsync(string virtualNetworkName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VirtualNetwork>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class VirtualNetworkData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public VirtualNetworkData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string CustomResourceName { get { throw null; } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.ExtendedLocation ExtendedLocation { get { throw null; } set { } }
        public string InventoryItemId { get { throw null; } set { } }
        public string Kind { get { throw null; } set { } }
        public string MoName { get { throw null; } }
        public string MoRefId { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ConnectedVMwarevSphere.Models.ResourceStatus> Statuses { get { throw null; } }
        public string Uuid { get { throw null; } }
        public string VCenterId { get { throw null; } set { } }
    }
    public partial class VMwareCluster : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected VMwareCluster() { }
        public virtual Azure.ResourceManager.ConnectedVMwarevSphere.VMwareClusterData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string clusterName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, bool? force = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, bool? force = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class VMwareClusterCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster>, System.Collections.IEnumerable
    {
        protected VMwareClusterCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster> CreateOrUpdate(Azure.WaitUntil waitUntil, string clusterName, Azure.ResourceManager.ConnectedVMwarevSphere.VMwareClusterData body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string clusterName, Azure.ResourceManager.ConnectedVMwarevSphere.VMwareClusterData body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster> Get(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster>> GetAsync(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster> GetIfExists(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster>> GetIfExistsAsync(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareCluster>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class VMwareClusterData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public VMwareClusterData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string CustomResourceName { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> DatastoreIds { get { throw null; } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.ExtendedLocation ExtendedLocation { get { throw null; } set { } }
        public string InventoryItemId { get { throw null; } set { } }
        public string Kind { get { throw null; } set { } }
        public string MoName { get { throw null; } }
        public string MoRefId { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> NetworkIds { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ConnectedVMwarevSphere.Models.ResourceStatus> Statuses { get { throw null; } }
        public string Uuid { get { throw null; } }
        public string VCenterId { get { throw null; } set { } }
    }
    public partial class VMwareDatastore : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected VMwareDatastore() { }
        public virtual Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastoreData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string datastoreName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, bool? force = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, bool? force = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class VMwareDatastoreCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore>, System.Collections.IEnumerable
    {
        protected VMwareDatastoreCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore> CreateOrUpdate(Azure.WaitUntil waitUntil, string datastoreName, Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastoreData body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string datastoreName, Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastoreData body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string datastoreName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string datastoreName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore> Get(string datastoreName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore>> GetAsync(string datastoreName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore> GetIfExists(string datastoreName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore>> GetIfExistsAsync(string datastoreName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareDatastore>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class VMwareDatastoreData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public VMwareDatastoreData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string CustomResourceName { get { throw null; } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.ExtendedLocation ExtendedLocation { get { throw null; } set { } }
        public string InventoryItemId { get { throw null; } set { } }
        public string Kind { get { throw null; } set { } }
        public string MoName { get { throw null; } }
        public string MoRefId { get { throw null; } set { } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ConnectedVMwarevSphere.Models.ResourceStatus> Statuses { get { throw null; } }
        public string Uuid { get { throw null; } }
        public string VCenterId { get { throw null; } set { } }
    }
    public partial class VMwareHost : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected VMwareHost() { }
        public virtual Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHostData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string hostName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, bool? force = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, bool? force = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class VMwareHostCollection : Azure.ResourceManager.Core.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost>, System.Collections.IEnumerable
    {
        protected VMwareHostCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost> CreateOrUpdate(Azure.WaitUntil waitUntil, string hostName, Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHostData body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string hostName, Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHostData body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost> Get(string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost>> GetAsync(string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost> GetIfExists(string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost>> GetIfExistsAsync(string hostName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ConnectedVMwarevSphere.VMwareHost>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class VMwareHostData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public VMwareHostData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string CustomResourceName { get { throw null; } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.ExtendedLocation ExtendedLocation { get { throw null; } set { } }
        public string InventoryItemId { get { throw null; } set { } }
        public string Kind { get { throw null; } set { } }
        public string MoName { get { throw null; } }
        public string MoRefId { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ConnectedVMwarevSphere.Models.ResourceStatus> Statuses { get { throw null; } }
        public string Uuid { get { throw null; } }
        public string VCenterId { get { throw null; } set { } }
    }
}
namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DiskMode : System.IEquatable<Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DiskMode(string value) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskMode IndependentNonpersistent { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskMode IndependentPersistent { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskMode Persistent { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskMode left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskMode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskMode left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DiskType : System.IEquatable<Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DiskType(string value) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskType Flat { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskType Pmem { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskType Rawphysical { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskType Rawvirtual { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskType Sesparse { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskType Sparse { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskType Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskType left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskType left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ErrorDetail
    {
        internal ErrorDetail() { }
        public string Code { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ConnectedVMwarevSphere.Models.ErrorDetail> Details { get { throw null; } }
        public string Message { get { throw null; } }
        public string Target { get { throw null; } }
    }
    public partial class ExtendedLocation
    {
        public ExtendedLocation() { }
        public string Name { get { throw null; } set { } }
        public string Type { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct FirmwareType : System.IEquatable<Azure.ResourceManager.ConnectedVMwarevSphere.Models.FirmwareType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public FirmwareType(string value) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.FirmwareType Bios { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.FirmwareType Efi { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ConnectedVMwarevSphere.Models.FirmwareType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ConnectedVMwarevSphere.Models.FirmwareType left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.FirmwareType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ConnectedVMwarevSphere.Models.FirmwareType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ConnectedVMwarevSphere.Models.FirmwareType left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.FirmwareType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class GuestAgentProfile
    {
        public GuestAgentProfile() { }
        public string AgentVersion { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ConnectedVMwarevSphere.Models.ErrorDetail> ErrorDetails { get { throw null; } }
        public System.DateTimeOffset? LastStatusChange { get { throw null; } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.StatusTypes? Status { get { throw null; } }
        public string VmUuid { get { throw null; } }
    }
    public partial class GuestCredential
    {
        public GuestCredential() { }
        public string Password { get { throw null; } set { } }
        public string Username { get { throw null; } set { } }
    }
    public partial class HardwareProfile
    {
        public HardwareProfile() { }
        public bool? CpuHotAddEnabled { get { throw null; } }
        public bool? CpuHotRemoveEnabled { get { throw null; } }
        public bool? MemoryHotAddEnabled { get { throw null; } }
        public int? MemorySizeMB { get { throw null; } set { } }
        public int? NumCoresPerSocket { get { throw null; } set { } }
        public int? NumCpus { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct InventoryType : System.IEquatable<Azure.ResourceManager.ConnectedVMwarevSphere.Models.InventoryType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public InventoryType(string value) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.InventoryType Cluster { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.InventoryType Datastore { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.InventoryType Host { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.InventoryType ResourcePool { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.InventoryType VirtualMachine { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.InventoryType VirtualMachineTemplate { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.InventoryType VirtualNetwork { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ConnectedVMwarevSphere.Models.InventoryType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ConnectedVMwarevSphere.Models.InventoryType left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.InventoryType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ConnectedVMwarevSphere.Models.InventoryType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ConnectedVMwarevSphere.Models.InventoryType left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.InventoryType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct IPAddressAllocationMethod : System.IEquatable<Azure.ResourceManager.ConnectedVMwarevSphere.Models.IPAddressAllocationMethod>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public IPAddressAllocationMethod(string value) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.IPAddressAllocationMethod Dynamic { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.IPAddressAllocationMethod Linklayer { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.IPAddressAllocationMethod Other { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.IPAddressAllocationMethod Random { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.IPAddressAllocationMethod Static { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.IPAddressAllocationMethod Unset { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ConnectedVMwarevSphere.Models.IPAddressAllocationMethod other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ConnectedVMwarevSphere.Models.IPAddressAllocationMethod left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.IPAddressAllocationMethod right) { throw null; }
        public static implicit operator Azure.ResourceManager.ConnectedVMwarevSphere.Models.IPAddressAllocationMethod (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ConnectedVMwarevSphere.Models.IPAddressAllocationMethod left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.IPAddressAllocationMethod right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MachineExtensionInstanceView
    {
        public MachineExtensionInstanceView() { }
        public string Name { get { throw null; } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.MachineExtensionInstanceViewStatus Status { get { throw null; } set { } }
        public string Type { get { throw null; } }
        public string TypeHandlerVersion { get { throw null; } }
    }
    public partial class MachineExtensionInstanceViewStatus
    {
        public MachineExtensionInstanceViewStatus() { }
        public string Code { get { throw null; } }
        public string DisplayStatus { get { throw null; } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.StatusLevelTypes? Level { get { throw null; } }
        public string Message { get { throw null; } }
        public System.DateTimeOffset? Time { get { throw null; } }
    }
    public partial class MachineExtensionPropertiesInstanceView : Azure.ResourceManager.ConnectedVMwarevSphere.Models.MachineExtensionInstanceView
    {
        public MachineExtensionPropertiesInstanceView() { }
    }
    public partial class NetworkInterface
    {
        public NetworkInterface() { }
        public int? DeviceKey { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> IPAddresses { get { throw null; } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.NicIPSettings IPSettings { get { throw null; } set { } }
        public string Label { get { throw null; } }
        public string MacAddress { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public string NetworkId { get { throw null; } set { } }
        public string NetworkMoName { get { throw null; } }
        public string NetworkMoRefId { get { throw null; } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.NICType? NicType { get { throw null; } set { } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.PowerOnBootOption? PowerOnBoot { get { throw null; } set { } }
    }
    public partial class NetworkInterfaceUpdate
    {
        public NetworkInterfaceUpdate() { }
        public int? DeviceKey { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string NetworkId { get { throw null; } set { } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.NICType? NicType { get { throw null; } set { } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.PowerOnBootOption? PowerOnBoot { get { throw null; } set { } }
    }
    public partial class NicIPAddressSettings
    {
        internal NicIPAddressSettings() { }
        public string AllocationMethod { get { throw null; } }
        public string IPAddress { get { throw null; } }
        public string SubnetMask { get { throw null; } }
    }
    public partial class NicIPSettings
    {
        public NicIPSettings() { }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.IPAddressAllocationMethod? AllocationMethod { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> DnsServers { get { throw null; } }
        public System.Collections.Generic.IList<string> Gateway { get { throw null; } }
        public string IPAddress { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ConnectedVMwarevSphere.Models.NicIPAddressSettings> IPAddressInfo { get { throw null; } }
        public string PrimaryWinsServer { get { throw null; } }
        public string SecondaryWinsServer { get { throw null; } }
        public string SubnetMask { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct NICType : System.IEquatable<Azure.ResourceManager.ConnectedVMwarevSphere.Models.NICType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public NICType(string value) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.NICType E1000 { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.NICType E1000E { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.NICType Pcnet32 { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.NICType Vmxnet { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.NICType Vmxnet2 { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.NICType Vmxnet3 { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ConnectedVMwarevSphere.Models.NICType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ConnectedVMwarevSphere.Models.NICType left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.NICType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ConnectedVMwarevSphere.Models.NICType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ConnectedVMwarevSphere.Models.NICType left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.NICType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class OSProfile
    {
        public OSProfile() { }
        public string AdminPassword { get { throw null; } set { } }
        public string AdminUsername { get { throw null; } set { } }
        public string ComputerName { get { throw null; } set { } }
        public string OSName { get { throw null; } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.OSType? OSType { get { throw null; } set { } }
        public string ToolsRunningStatus { get { throw null; } }
        public string ToolsVersion { get { throw null; } }
        public string ToolsVersionStatus { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct OSType : System.IEquatable<Azure.ResourceManager.ConnectedVMwarevSphere.Models.OSType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public OSType(string value) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.OSType Linux { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.OSType Other { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.OSType Windows { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ConnectedVMwarevSphere.Models.OSType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ConnectedVMwarevSphere.Models.OSType left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.OSType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ConnectedVMwarevSphere.Models.OSType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ConnectedVMwarevSphere.Models.OSType left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.OSType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PatchableMachineExtensionData : Azure.ResourceManager.ConnectedVMwarevSphere.Models.ResourcePatch
    {
        public PatchableMachineExtensionData() { }
        public bool? AutoUpgradeMinorVersion { get { throw null; } set { } }
        public string ForceUpdateTag { get { throw null; } set { } }
        public object ProtectedSettings { get { throw null; } set { } }
        public string Publisher { get { throw null; } set { } }
        public object Settings { get { throw null; } set { } }
        public string Type { get { throw null; } set { } }
        public string TypeHandlerVersion { get { throw null; } set { } }
    }
    public partial class PatchableVirtualMachineData
    {
        public PatchableVirtualMachineData() { }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.HardwareProfile HardwareProfile { get { throw null; } set { } }
        public Azure.ResourceManager.Models.SystemAssignedServiceIdentity Identity { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ConnectedVMwarevSphere.Models.NetworkInterfaceUpdate> NetworkInterfaces { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ConnectedVMwarevSphere.Models.VirtualDiskUpdate> StorageDisks { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
    }
    public partial class PlacementProfile
    {
        public PlacementProfile() { }
        public string ClusterId { get { throw null; } set { } }
        public string DatastoreId { get { throw null; } set { } }
        public string HostId { get { throw null; } set { } }
        public string ResourcePoolId { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PowerOnBootOption : System.IEquatable<Azure.ResourceManager.ConnectedVMwarevSphere.Models.PowerOnBootOption>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PowerOnBootOption(string value) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.PowerOnBootOption Disabled { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.PowerOnBootOption Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ConnectedVMwarevSphere.Models.PowerOnBootOption other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ConnectedVMwarevSphere.Models.PowerOnBootOption left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.PowerOnBootOption right) { throw null; }
        public static implicit operator Azure.ResourceManager.ConnectedVMwarevSphere.Models.PowerOnBootOption (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ConnectedVMwarevSphere.Models.PowerOnBootOption left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.PowerOnBootOption right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningAction : System.IEquatable<Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningAction>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningAction(string value) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningAction Install { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningAction Repair { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningAction Uninstall { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningAction other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningAction left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningAction right) { throw null; }
        public static implicit operator Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningAction (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningAction left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningAction right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningState Accepted { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningState Created { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningState Provisioning { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningState left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningState left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ResourcePatch
    {
        public ResourcePatch() { }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
    }
    public partial class ResourceStatus
    {
        internal ResourceStatus() { }
        public System.DateTimeOffset? LastUpdatedAt { get { throw null; } }
        public string Message { get { throw null; } }
        public string Reason { get { throw null; } }
        public string Severity { get { throw null; } }
        public string Status { get { throw null; } }
        public string Type { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ScsiControllerType : System.IEquatable<Azure.ResourceManager.ConnectedVMwarevSphere.Models.ScsiControllerType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ScsiControllerType(string value) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.ScsiControllerType Buslogic { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.ScsiControllerType Lsilogic { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.ScsiControllerType Lsilogicsas { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.ScsiControllerType Pvscsi { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ConnectedVMwarevSphere.Models.ScsiControllerType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ConnectedVMwarevSphere.Models.ScsiControllerType left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.ScsiControllerType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ConnectedVMwarevSphere.Models.ScsiControllerType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ConnectedVMwarevSphere.Models.ScsiControllerType left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.ScsiControllerType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct StatusLevelTypes : System.IEquatable<Azure.ResourceManager.ConnectedVMwarevSphere.Models.StatusLevelTypes>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public StatusLevelTypes(string value) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.StatusLevelTypes Error { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.StatusLevelTypes Info { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.StatusLevelTypes Warning { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ConnectedVMwarevSphere.Models.StatusLevelTypes other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ConnectedVMwarevSphere.Models.StatusLevelTypes left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.StatusLevelTypes right) { throw null; }
        public static implicit operator Azure.ResourceManager.ConnectedVMwarevSphere.Models.StatusLevelTypes (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ConnectedVMwarevSphere.Models.StatusLevelTypes left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.StatusLevelTypes right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct StatusTypes : System.IEquatable<Azure.ResourceManager.ConnectedVMwarevSphere.Models.StatusTypes>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public StatusTypes(string value) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.StatusTypes Connected { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.StatusTypes Disconnected { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.StatusTypes Error { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ConnectedVMwarevSphere.Models.StatusTypes other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ConnectedVMwarevSphere.Models.StatusTypes left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.StatusTypes right) { throw null; }
        public static implicit operator Azure.ResourceManager.ConnectedVMwarevSphere.Models.StatusTypes (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ConnectedVMwarevSphere.Models.StatusTypes left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.StatusTypes right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class StopVirtualMachineOptions
    {
        public StopVirtualMachineOptions() { }
        public bool? SkipShutdown { get { throw null; } set { } }
    }
    public partial class StorageProfile
    {
        public StorageProfile() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.ConnectedVMwarevSphere.Models.VirtualDisk> Disks { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ConnectedVMwarevSphere.Models.VirtualScsiController> ScsiControllers { get { throw null; } }
    }
    public partial class VICredential
    {
        public VICredential() { }
        public string Password { get { throw null; } set { } }
        public string Username { get { throw null; } set { } }
    }
    public partial class VirtualDisk
    {
        public VirtualDisk() { }
        public int? ControllerKey { get { throw null; } set { } }
        public int? DeviceKey { get { throw null; } set { } }
        public string DeviceName { get { throw null; } set { } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskMode? DiskMode { get { throw null; } set { } }
        public string DiskObjectId { get { throw null; } }
        public int? DiskSizeGB { get { throw null; } set { } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskType? DiskType { get { throw null; } set { } }
        public string Label { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public int? UnitNumber { get { throw null; } set { } }
    }
    public partial class VirtualDiskUpdate
    {
        public VirtualDiskUpdate() { }
        public int? ControllerKey { get { throw null; } set { } }
        public int? DeviceKey { get { throw null; } set { } }
        public string DeviceName { get { throw null; } set { } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskMode? DiskMode { get { throw null; } set { } }
        public int? DiskSizeGB { get { throw null; } set { } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.DiskType? DiskType { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public int? UnitNumber { get { throw null; } set { } }
    }
    public partial class VirtualScsiController
    {
        internal VirtualScsiController() { }
        public int? BusNumber { get { throw null; } }
        public int? ControllerKey { get { throw null; } }
        public int? ScsiCtlrUnitNumber { get { throw null; } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.VirtualScsiSharing? Sharing { get { throw null; } }
        public Azure.ResourceManager.ConnectedVMwarevSphere.Models.ScsiControllerType? Type { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct VirtualScsiSharing : System.IEquatable<Azure.ResourceManager.ConnectedVMwarevSphere.Models.VirtualScsiSharing>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public VirtualScsiSharing(string value) { throw null; }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.VirtualScsiSharing NoSharing { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.VirtualScsiSharing PhysicalSharing { get { throw null; } }
        public static Azure.ResourceManager.ConnectedVMwarevSphere.Models.VirtualScsiSharing VirtualSharing { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ConnectedVMwarevSphere.Models.VirtualScsiSharing other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ConnectedVMwarevSphere.Models.VirtualScsiSharing left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.VirtualScsiSharing right) { throw null; }
        public static implicit operator Azure.ResourceManager.ConnectedVMwarevSphere.Models.VirtualScsiSharing (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ConnectedVMwarevSphere.Models.VirtualScsiSharing left, Azure.ResourceManager.ConnectedVMwarevSphere.Models.VirtualScsiSharing right) { throw null; }
        public override string ToString() { throw null; }
    }
}
