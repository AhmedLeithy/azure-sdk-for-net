// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Message envelope that contains the common Azure resource manager properties and the resource provider specific content. </summary>
    public partial class ResponseMessageEnvelopeRemotePrivateEndpointConnection : ResourceData
    {
        /// <summary> Initializes a new instance of ResponseMessageEnvelopeRemotePrivateEndpointConnection. </summary>
        internal ResponseMessageEnvelopeRemotePrivateEndpointConnection()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ResponseMessageEnvelopeRemotePrivateEndpointConnection. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Geographical region resource belongs to e.g. SouthCentralUS, SouthEastAsia. </param>
        /// <param name="tags"> Tags associated with resource. </param>
        /// <param name="plan"> Azure resource manager plan. </param>
        /// <param name="properties"> Resource specific properties. </param>
        /// <param name="sku"> SKU description of the resource. </param>
        /// <param name="status"> Azure-AsyncOperation Status info. </param>
        /// <param name="error"> Azure-AsyncOperation Error info. </param>
        /// <param name="identity"> MSI resource. </param>
        /// <param name="zones"> Logical Availability Zones the service is hosted in. </param>
        internal ResponseMessageEnvelopeRemotePrivateEndpointConnection(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string location, IReadOnlyDictionary<string, string> tags, ArmPlan plan, RemotePrivateEndpointConnection properties, SkuDescription sku, string status, ErrorEntity error, ManagedServiceIdentity identity, IReadOnlyList<string> zones) : base(id, name, type, systemData)
        {
            Location = location;
            Tags = tags;
            Plan = plan;
            Properties = properties;
            Sku = sku;
            Status = status;
            Error = error;
            Identity = identity;
            Zones = zones;
        }

        /// <summary> Geographical region resource belongs to e.g. SouthCentralUS, SouthEastAsia. </summary>
        public string Location { get; }
        /// <summary> Tags associated with resource. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
        /// <summary> Azure resource manager plan. </summary>
        public ArmPlan Plan { get; }
        /// <summary> Resource specific properties. </summary>
        public RemotePrivateEndpointConnection Properties { get; }
        /// <summary> SKU description of the resource. </summary>
        public SkuDescription Sku { get; }
        /// <summary> Azure-AsyncOperation Status info. </summary>
        public string Status { get; }
        /// <summary> Azure-AsyncOperation Error info. </summary>
        public ErrorEntity Error { get; }
        /// <summary> MSI resource. </summary>
        public ManagedServiceIdentity Identity { get; }
        /// <summary> Logical Availability Zones the service is hosted in. </summary>
        public IReadOnlyList<string> Zones { get; }
    }
}
