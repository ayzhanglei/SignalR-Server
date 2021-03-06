// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.


using Microsoft.AspNetCore.SignalR.Hubs;

namespace Microsoft.AspNetCore.SignalR
{
    /// <summary>
    /// Provides access to information about a <see cref="IHub"/>.
    /// </summary>
    public interface IHubContext<THub> : IHubContext
        where THub : IHub
    {
    }
}
