﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Azure.Monitor.OpenTelemetry.Exporter.Models;
using OpenTelemetry;

namespace Azure.Monitor.OpenTelemetry.Exporter
{
    internal interface ITransmitter
    {
        /// <summary>
        /// Sent telemetry and return the number of items Accepted.
        /// </summary>
        ValueTask<ExportResult> TrackAsync(IEnumerable<TelemetryItem> telemetryItems, bool async, CancellationToken cancellationToken);
        ValueTask TransmitFromStorage(long maxFileToTransmit, bool aysnc, CancellationToken cancellationToken);
        string InstrumentationKey { get; }
    }
}
