// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Hosting;

namespace Microsoft.AspNetCore.Routing.FunctionalTests
{
    public class RoutingTestFixture<TStartup> : IDisposable
    {
        private readonly TestServer _server;

        public RoutingTestFixture()
        {
            var host = new HostBuilder()
                .ConfigureWebHost(webHostBuilder =>
                {
                    webHostBuilder
                        .UseStartup(typeof(TStartup))
                        .UseTestServer();
                })
                .Build();

            _server = host.GetTestServer();

            host.Start();

            Client = _server.CreateClient();
            Client.BaseAddress = new Uri("http://localhost");
        }

        public HttpClient Client { get; }

        public HttpClient CreateClient(string baseAddress)
        {
            var client = _server.CreateClient();
            client.BaseAddress = new Uri(baseAddress);

            return client;
        }

        public void Dispose()
        {
            Client.Dispose();
            _server.Dispose();
        }
    }
}
