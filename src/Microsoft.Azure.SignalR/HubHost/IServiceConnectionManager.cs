﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Azure.SignalR.Protocol;

namespace Microsoft.Azure.SignalR
{
    internal interface IServiceConnectionManager
    {
        Task StartAsync();

        Task WriteAsync(ServiceMessage seviceMessage);

        Task WriteAsync(string partitionKey, ServiceMessage serviceMessage);

        Task StopAsync();
    }

    internal interface IServiceConnectionManager<THub> : IServiceConnectionManager where THub : Hub
    {
        
    }
}
