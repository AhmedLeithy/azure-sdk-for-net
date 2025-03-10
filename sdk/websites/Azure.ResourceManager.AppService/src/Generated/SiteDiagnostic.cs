// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a SiteDiagnostic along with the instance operations that can be performed on it. </summary>
    public partial class SiteDiagnostic : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteDiagnostic"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string siteName, string diagnosticCategory)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteDiagnosticDiagnosticsClientDiagnostics;
        private readonly DiagnosticsRestOperations _siteDiagnosticDiagnosticsRestClient;
        private readonly DiagnosticCategoryData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteDiagnostic"/> class for mocking. </summary>
        protected SiteDiagnostic()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteDiagnostic"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteDiagnostic(ArmClient client, DiagnosticCategoryData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteDiagnostic"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteDiagnostic(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteDiagnosticDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string siteDiagnosticDiagnosticsApiVersion);
            _siteDiagnosticDiagnosticsRestClient = new DiagnosticsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteDiagnosticDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/diagnostics";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DiagnosticCategoryData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SiteDiagnosticAnalyses in the SiteDiagnosticAnalysis. </summary>
        /// <returns> An object representing collection of SiteDiagnosticAnalyses and their operations over a SiteDiagnosticAnalysis. </returns>
        public virtual SiteDiagnosticAnalysisCollection GetSiteDiagnosticAnalyses()
        {
            return new SiteDiagnosticAnalysisCollection(Client, Id);
        }

        /// <summary>
        /// Description for Get Site Analysis
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/analyses/{analysisName}
        /// Operation Id: Diagnostics_GetSiteAnalysis
        /// </summary>
        /// <param name="analysisName"> Analysis Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="analysisName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisName"/> is null. </exception>
        public virtual async Task<Response<SiteDiagnosticAnalysis>> GetSiteDiagnosticAnalysisAsync(string analysisName, CancellationToken cancellationToken = default)
        {
            return await GetSiteDiagnosticAnalyses().GetAsync(analysisName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Get Site Analysis
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/analyses/{analysisName}
        /// Operation Id: Diagnostics_GetSiteAnalysis
        /// </summary>
        /// <param name="analysisName"> Analysis Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="analysisName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="analysisName"/> is null. </exception>
        public virtual Response<SiteDiagnosticAnalysis> GetSiteDiagnosticAnalysis(string analysisName, CancellationToken cancellationToken = default)
        {
            return GetSiteDiagnosticAnalyses().Get(analysisName, cancellationToken);
        }

        /// <summary> Gets a collection of SiteDiagnosticDetectors in the SiteDiagnosticDetector. </summary>
        /// <returns> An object representing collection of SiteDiagnosticDetectors and their operations over a SiteDiagnosticDetector. </returns>
        public virtual SiteDiagnosticDetectorCollection GetSiteDiagnosticDetectors()
        {
            return new SiteDiagnosticDetectorCollection(Client, Id);
        }

        /// <summary>
        /// Description for Get Detector
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/detectors/{detectorName}
        /// Operation Id: Diagnostics_GetSiteDetector
        /// </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual async Task<Response<SiteDiagnosticDetector>> GetSiteDiagnosticDetectorAsync(string detectorName, CancellationToken cancellationToken = default)
        {
            return await GetSiteDiagnosticDetectors().GetAsync(detectorName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Get Detector
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/detectors/{detectorName}
        /// Operation Id: Diagnostics_GetSiteDetector
        /// </summary>
        /// <param name="detectorName"> Detector Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="detectorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="detectorName"/> is null. </exception>
        public virtual Response<SiteDiagnosticDetector> GetSiteDiagnosticDetector(string detectorName, CancellationToken cancellationToken = default)
        {
            return GetSiteDiagnosticDetectors().Get(detectorName, cancellationToken);
        }

        /// <summary>
        /// Description for Get Diagnostics Category
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}
        /// Operation Id: Diagnostics_GetSiteDiagnosticCategory
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteDiagnostic>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteDiagnostic.Get");
            scope.Start();
            try
            {
                var response = await _siteDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategoryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteDiagnostic(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get Diagnostics Category
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}
        /// Operation Id: Diagnostics_GetSiteDiagnosticCategory
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteDiagnostic> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteDiagnosticDiagnosticsClientDiagnostics.CreateScope("SiteDiagnostic.Get");
            scope.Start();
            try
            {
                var response = _siteDiagnosticDiagnosticsRestClient.GetSiteDiagnosticCategory(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteDiagnostic(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
