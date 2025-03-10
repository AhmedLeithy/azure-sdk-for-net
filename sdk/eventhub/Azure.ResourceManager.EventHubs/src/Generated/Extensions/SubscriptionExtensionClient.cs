// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.EventHubs.Models;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    internal partial class SubscriptionExtensionClient : ArmResource
    {
        private ClientDiagnostics _eventHubClusterClustersClientDiagnostics;
        private ClustersRestOperations _eventHubClusterClustersRestClient;
        private ClientDiagnostics _eventHubNamespaceNamespacesClientDiagnostics;
        private NamespacesRestOperations _eventHubNamespaceNamespacesRestClient;
        private ClientDiagnostics _namespacesClientDiagnostics;
        private NamespacesRestOperations _namespacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionExtensionClient"/> class for mocking. </summary>
        protected SubscriptionExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics EventHubClusterClustersClientDiagnostics => _eventHubClusterClustersClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.EventHubs", EventHubCluster.ResourceType.Namespace, DiagnosticOptions);
        private ClustersRestOperations EventHubClusterClustersRestClient => _eventHubClusterClustersRestClient ??= new ClustersRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(EventHubCluster.ResourceType));
        private ClientDiagnostics EventHubNamespaceNamespacesClientDiagnostics => _eventHubNamespaceNamespacesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.EventHubs", EventHubNamespace.ResourceType.Namespace, DiagnosticOptions);
        private NamespacesRestOperations EventHubNamespaceNamespacesRestClient => _eventHubNamespaceNamespacesRestClient ??= new NamespacesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(EventHubNamespace.ResourceType));
        private ClientDiagnostics NamespacesClientDiagnostics => _namespacesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.EventHubs", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private NamespacesRestOperations NamespacesRestClient => _namespacesRestClient ??= new NamespacesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List the quantity of available pre-provisioned Event Hubs Clusters, indexed by Azure region.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EventHub/availableClusterRegions
        /// Operation Id: Clusters_ListAvailableClusterRegion
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvailableCluster" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AvailableCluster> GetAvailableClusterRegionClustersAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AvailableCluster>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = EventHubClusterClustersClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetAvailableClusterRegionClusters");
                scope.Start();
                try
                {
                    var response = await EventHubClusterClustersRestClient.ListAvailableClusterRegionAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// List the quantity of available pre-provisioned Event Hubs Clusters, indexed by Azure region.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EventHub/availableClusterRegions
        /// Operation Id: Clusters_ListAvailableClusterRegion
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvailableCluster" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AvailableCluster> GetAvailableClusterRegionClusters(CancellationToken cancellationToken = default)
        {
            Page<AvailableCluster> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = EventHubClusterClustersClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetAvailableClusterRegionClusters");
                scope.Start();
                try
                {
                    var response = EventHubClusterClustersRestClient.ListAvailableClusterRegion(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Lists the available Event Hubs Clusters within an ARM resource group
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EventHub/clusters
        /// Operation Id: Clusters_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHubCluster" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventHubCluster> GetEventHubClustersAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<EventHubCluster>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = EventHubClusterClustersClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetEventHubClusters");
                scope.Start();
                try
                {
                    var response = await EventHubClusterClustersRestClient.ListBySubscriptionAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHubCluster(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<EventHubCluster>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = EventHubClusterClustersClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetEventHubClusters");
                scope.Start();
                try
                {
                    var response = await EventHubClusterClustersRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHubCluster(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists the available Event Hubs Clusters within an ARM resource group
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EventHub/clusters
        /// Operation Id: Clusters_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHubCluster" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventHubCluster> GetEventHubClusters(CancellationToken cancellationToken = default)
        {
            Page<EventHubCluster> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = EventHubClusterClustersClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetEventHubClusters");
                scope.Start();
                try
                {
                    var response = EventHubClusterClustersRestClient.ListBySubscription(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHubCluster(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<EventHubCluster> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = EventHubClusterClustersClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetEventHubClusters");
                scope.Start();
                try
                {
                    var response = EventHubClusterClustersRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHubCluster(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all the available Namespaces within a subscription, irrespective of the resource groups.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EventHub/namespaces
        /// Operation Id: Namespaces_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHubNamespace" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventHubNamespace> GetEventHubNamespacesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<EventHubNamespace>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = EventHubNamespaceNamespacesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetEventHubNamespaces");
                scope.Start();
                try
                {
                    var response = await EventHubNamespaceNamespacesRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHubNamespace(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<EventHubNamespace>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = EventHubNamespaceNamespacesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetEventHubNamespaces");
                scope.Start();
                try
                {
                    var response = await EventHubNamespaceNamespacesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHubNamespace(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all the available Namespaces within a subscription, irrespective of the resource groups.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EventHub/namespaces
        /// Operation Id: Namespaces_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHubNamespace" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventHubNamespace> GetEventHubNamespaces(CancellationToken cancellationToken = default)
        {
            Page<EventHubNamespace> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = EventHubNamespaceNamespacesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetEventHubNamespaces");
                scope.Start();
                try
                {
                    var response = EventHubNamespaceNamespacesRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHubNamespace(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<EventHubNamespace> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = EventHubNamespaceNamespacesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetEventHubNamespaces");
                scope.Start();
                try
                {
                    var response = EventHubNamespaceNamespacesRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHubNamespace(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Check the give Namespace name availability.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EventHub/checkNameAvailability
        /// Operation Id: Namespaces_CheckNameAvailability
        /// </summary>
        /// <param name="parameters"> Parameters to check availability of the given Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CheckNameAvailabilityResult>> CheckNameAvailabilityNamespaceAsync(CheckNameAvailabilityOptions parameters, CancellationToken cancellationToken = default)
        {
            using var scope = NamespacesClientDiagnostics.CreateScope("SubscriptionExtensionClient.CheckNameAvailabilityNamespace");
            scope.Start();
            try
            {
                var response = await NamespacesRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, parameters, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the give Namespace name availability.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EventHub/checkNameAvailability
        /// Operation Id: Namespaces_CheckNameAvailability
        /// </summary>
        /// <param name="parameters"> Parameters to check availability of the given Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CheckNameAvailabilityResult> CheckNameAvailabilityNamespace(CheckNameAvailabilityOptions parameters, CancellationToken cancellationToken = default)
        {
            using var scope = NamespacesClientDiagnostics.CreateScope("SubscriptionExtensionClient.CheckNameAvailabilityNamespace");
            scope.Start();
            try
            {
                var response = NamespacesRestClient.CheckNameAvailability(Id.SubscriptionId, parameters, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
