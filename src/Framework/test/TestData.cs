// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Microsoft.AspNetCore
{
    public class TestData
    {
        public static List<string> ListedSharedFxAssemblies;
        public static SortedDictionary<string, string> ListedTargetingPackAssemblies;

        static TestData()
        {
            ListedSharedFxAssemblies = new List<string>()
            {
                "aspnetcorev2_inprocess",
                "Microsoft.AspNetCore",
                "Microsoft.AspNetCore.Antiforgery",
                "Microsoft.AspNetCore.Authentication",
                "Microsoft.AspNetCore.Authentication.Abstractions",
                "Microsoft.AspNetCore.Authentication.Cookies",
                "Microsoft.AspNetCore.Authentication.Core",
                "Microsoft.AspNetCore.Authentication.OAuth",
                "Microsoft.AspNetCore.Authorization",
                "Microsoft.AspNetCore.Authorization.Policy",
                "Microsoft.AspNetCore.Components",
                "Microsoft.AspNetCore.Components.Authorization",
                "Microsoft.AspNetCore.Components.Forms",
                "Microsoft.AspNetCore.Components.Server",
                "Microsoft.AspNetCore.Components.Web",
                "Microsoft.AspNetCore.Connections.Abstractions",
                "Microsoft.AspNetCore.CookiePolicy",
                "Microsoft.AspNetCore.Cors",
                "Microsoft.AspNetCore.Cryptography.Internal",
                "Microsoft.AspNetCore.Cryptography.KeyDerivation",
                "Microsoft.AspNetCore.DataProtection",
                "Microsoft.AspNetCore.DataProtection.Abstractions",
                "Microsoft.AspNetCore.DataProtection.Extensions",
                "Microsoft.AspNetCore.Diagnostics",
                "Microsoft.AspNetCore.Diagnostics.Abstractions",
                "Microsoft.AspNetCore.Diagnostics.HealthChecks",
                "Microsoft.AspNetCore.HostFiltering",
                "Microsoft.AspNetCore.Hosting",
                "Microsoft.AspNetCore.Hosting.Abstractions",
                "Microsoft.AspNetCore.Hosting.Server.Abstractions",
                "Microsoft.AspNetCore.Html.Abstractions",
                "Microsoft.AspNetCore.Http",
                "Microsoft.AspNetCore.Http.Abstractions",
                "Microsoft.AspNetCore.Http.Connections",
                "Microsoft.AspNetCore.Http.Connections.Common",
                "Microsoft.AspNetCore.Http.Extensions",
                "Microsoft.AspNetCore.Http.Features",
                "Microsoft.AspNetCore.HttpOverrides",
                "Microsoft.AspNetCore.HttpsPolicy",
                "Microsoft.AspNetCore.Identity",
                "Microsoft.AspNetCore.Localization",
                "Microsoft.AspNetCore.Localization.Routing",
                "Microsoft.AspNetCore.Metadata",
                "Microsoft.AspNetCore.Mvc",
                "Microsoft.AspNetCore.Mvc.Abstractions",
                "Microsoft.AspNetCore.Mvc.ApiExplorer",
                "Microsoft.AspNetCore.Mvc.Core",
                "Microsoft.AspNetCore.Mvc.Cors",
                "Microsoft.AspNetCore.Mvc.DataAnnotations",
                "Microsoft.AspNetCore.Mvc.Formatters.Json",
                "Microsoft.AspNetCore.Mvc.Formatters.Xml",
                "Microsoft.AspNetCore.Mvc.Localization",
                "Microsoft.AspNetCore.Mvc.Razor",
                "Microsoft.AspNetCore.Mvc.RazorPages",
                "Microsoft.AspNetCore.Mvc.TagHelpers",
                "Microsoft.AspNetCore.Mvc.ViewFeatures",
                "Microsoft.AspNetCore.Razor",
                "Microsoft.AspNetCore.Razor.Runtime",
                "Microsoft.AspNetCore.ResponseCaching",
                "Microsoft.AspNetCore.ResponseCaching.Abstractions",
                "Microsoft.AspNetCore.ResponseCompression",
                "Microsoft.AspNetCore.Rewrite",
                "Microsoft.AspNetCore.Routing",
                "Microsoft.AspNetCore.Routing.Abstractions",
                "Microsoft.AspNetCore.Server.HttpSys",
                "Microsoft.AspNetCore.Server.IIS",
                "Microsoft.AspNetCore.Server.IISIntegration",
                "Microsoft.AspNetCore.Server.Kestrel",
                "Microsoft.AspNetCore.Server.Kestrel.Core",
                "Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets",
                "Microsoft.AspNetCore.Session",
                "Microsoft.AspNetCore.SignalR",
                "Microsoft.AspNetCore.SignalR.Common",
                "Microsoft.AspNetCore.SignalR.Core",
                "Microsoft.AspNetCore.SignalR.Protocols.Json",
                "Microsoft.AspNetCore.StaticFiles",
                "Microsoft.AspNetCore.WebSockets",
                "Microsoft.AspNetCore.WebUtilities",
                "Microsoft.Extensions.Caching.Abstractions",
                "Microsoft.Extensions.Caching.Memory",
                "Microsoft.Extensions.Configuration",
                "Microsoft.Extensions.Configuration.Abstractions",
                "Microsoft.Extensions.Configuration.Binder",
                "Microsoft.Extensions.Configuration.CommandLine",
                "Microsoft.Extensions.Configuration.EnvironmentVariables",
                "Microsoft.Extensions.Configuration.FileExtensions",
                "Microsoft.Extensions.Configuration.Ini",
                "Microsoft.Extensions.Configuration.Json",
                "Microsoft.Extensions.Configuration.KeyPerFile",
                "Microsoft.Extensions.Configuration.UserSecrets",
                "Microsoft.Extensions.Configuration.Xml",
                "Microsoft.Extensions.DependencyInjection",
                "Microsoft.Extensions.DependencyInjection.Abstractions",
                "Microsoft.Extensions.Diagnostics.HealthChecks",
                "Microsoft.Extensions.Diagnostics.HealthChecks.Abstractions",
                "Microsoft.Extensions.FileProviders.Abstractions",
                "Microsoft.Extensions.FileProviders.Composite",
                "Microsoft.Extensions.FileProviders.Embedded",
                "Microsoft.Extensions.FileProviders.Physical",
                "Microsoft.Extensions.FileSystemGlobbing",
                "Microsoft.Extensions.Hosting",
                "Microsoft.Extensions.Hosting.Abstractions",
                "Microsoft.Extensions.Http",
                "Microsoft.Extensions.Identity.Core",
                "Microsoft.Extensions.Identity.Stores",
                "Microsoft.Extensions.Localization",
                "Microsoft.Extensions.Localization.Abstractions",
                "Microsoft.Extensions.Logging",
                "Microsoft.Extensions.Logging.Abstractions",
                "Microsoft.Extensions.Logging.Configuration",
                "Microsoft.Extensions.Logging.Console",
                "Microsoft.Extensions.Logging.Debug",
                "Microsoft.Extensions.Logging.EventLog",
                "Microsoft.Extensions.Logging.EventSource",
                "Microsoft.Extensions.Logging.TraceSource",
                "Microsoft.Extensions.ObjectPool",
                "Microsoft.Extensions.Options",
                "Microsoft.Extensions.Options.ConfigurationExtensions",
                "Microsoft.Extensions.Options.DataAnnotations",
                "Microsoft.Extensions.Primitives",
                "Microsoft.Extensions.WebEncoders",
                "Microsoft.JSInterop",
                "Microsoft.Net.Http.Headers",
                "Microsoft.Win32.SystemEvents",
                "System.Diagnostics.EventLog",
                "System.Drawing.Common",
                "System.Security.Cryptography.Pkcs",
                "System.Security.Cryptography.Xml",
                "System.Security.Permissions",
                "System.Windows.Extensions"
            };
            ListedTargetingPackAssemblies = new SortedDictionary<string, string>
            {
                { "Microsoft.AspNetCore", "5.0.0.0" },
                { "Microsoft.AspNetCore.Antiforgery", "5.0.0.0" },
                { "Microsoft.AspNetCore.Authentication", "5.0.0.0" },
                { "Microsoft.AspNetCore.Authentication.Abstractions", "5.0.0.0" },
                { "Microsoft.AspNetCore.Authentication.Cookies", "5.0.0.0" },
                { "Microsoft.AspNetCore.Authentication.Core", "5.0.0.0" },
                { "Microsoft.AspNetCore.Authentication.OAuth", "5.0.0.0" },
                { "Microsoft.AspNetCore.Authorization", "5.0.0.0" },
                { "Microsoft.AspNetCore.Authorization.Policy", "5.0.0.0" },
                { "Microsoft.AspNetCore.Components", "5.0.0.0" },
                { "Microsoft.AspNetCore.Components.Authorization", "5.0.0.0" },
                { "Microsoft.AspNetCore.Components.Forms", "5.0.0.0" },
                { "Microsoft.AspNetCore.Components.Server", "5.0.0.0" },
                { "Microsoft.AspNetCore.Components.Web", "5.0.0.0" },
                { "Microsoft.AspNetCore.Connections.Abstractions", "5.0.0.0" },
                { "Microsoft.AspNetCore.CookiePolicy", "5.0.0.0" },
                { "Microsoft.AspNetCore.Cors", "5.0.0.0" },
                { "Microsoft.AspNetCore.Cryptography.Internal", "5.0.0.0" },
                { "Microsoft.AspNetCore.Cryptography.KeyDerivation", "5.0.0.0" },
                { "Microsoft.AspNetCore.DataProtection", "5.0.0.0" },
                { "Microsoft.AspNetCore.DataProtection.Abstractions", "5.0.0.0" },
                { "Microsoft.AspNetCore.DataProtection.Extensions", "5.0.0.0" },
                { "Microsoft.AspNetCore.Diagnostics", "5.0.0.0" },
                { "Microsoft.AspNetCore.Diagnostics.Abstractions", "5.0.0.0" },
                { "Microsoft.AspNetCore.Diagnostics.HealthChecks", "5.0.0.0" },
                { "Microsoft.AspNetCore.HostFiltering", "5.0.0.0" },
                { "Microsoft.AspNetCore.Hosting", "5.0.0.0" },
                { "Microsoft.AspNetCore.Hosting.Abstractions", "5.0.0.0" },
                { "Microsoft.AspNetCore.Hosting.Server.Abstractions", "5.0.0.0" },
                { "Microsoft.AspNetCore.Html.Abstractions", "5.0.0.0" },
                { "Microsoft.AspNetCore.Http", "5.0.0.0" },
                { "Microsoft.AspNetCore.Http.Abstractions", "5.0.0.0" },
                { "Microsoft.AspNetCore.Http.Connections", "5.0.0.0" },
                { "Microsoft.AspNetCore.Http.Connections.Common", "5.0.0.0" },
                { "Microsoft.AspNetCore.Http.Extensions", "5.0.0.0" },
                { "Microsoft.AspNetCore.Http.Features", "5.0.0.0" },
                { "Microsoft.AspNetCore.HttpOverrides", "5.0.0.0" },
                { "Microsoft.AspNetCore.HttpsPolicy", "5.0.0.0" },
                { "Microsoft.AspNetCore.Identity", "5.0.0.0" },
                { "Microsoft.AspNetCore.Localization", "5.0.0.0" },
                { "Microsoft.AspNetCore.Localization.Routing", "5.0.0.0" },
                { "Microsoft.AspNetCore.Metadata", "5.0.0.0" },
                { "Microsoft.AspNetCore.Mvc", "5.0.0.0" },
                { "Microsoft.AspNetCore.Mvc.Abstractions", "5.0.0.0" },
                { "Microsoft.AspNetCore.Mvc.ApiExplorer", "5.0.0.0" },
                { "Microsoft.AspNetCore.Mvc.Core", "5.0.0.0" },
                { "Microsoft.AspNetCore.Mvc.Cors", "5.0.0.0" },
                { "Microsoft.AspNetCore.Mvc.DataAnnotations", "5.0.0.0" },
                { "Microsoft.AspNetCore.Mvc.Formatters.Json", "5.0.0.0" },
                { "Microsoft.AspNetCore.Mvc.Formatters.Xml", "5.0.0.0" },
                { "Microsoft.AspNetCore.Mvc.Localization", "5.0.0.0" },
                { "Microsoft.AspNetCore.Mvc.Razor", "5.0.0.0" },
                { "Microsoft.AspNetCore.Mvc.RazorPages", "5.0.0.0" },
                { "Microsoft.AspNetCore.Mvc.TagHelpers", "5.0.0.0" },
                { "Microsoft.AspNetCore.Mvc.ViewFeatures", "5.0.0.0" },
                { "Microsoft.AspNetCore.Razor", "5.0.0.0" },
                { "Microsoft.AspNetCore.Razor.Runtime", "5.0.0.0" },
                { "Microsoft.AspNetCore.ResponseCaching", "5.0.0.0" },
                { "Microsoft.AspNetCore.ResponseCaching.Abstractions", "5.0.0.0" },
                { "Microsoft.AspNetCore.ResponseCompression", "5.0.0.0" },
                { "Microsoft.AspNetCore.Rewrite", "5.0.0.0" },
                { "Microsoft.AspNetCore.Routing", "5.0.0.0" },
                { "Microsoft.AspNetCore.Routing.Abstractions", "5.0.0.0" },
                { "Microsoft.AspNetCore.Server.HttpSys", "5.0.0.0" },
                { "Microsoft.AspNetCore.Server.IIS", "5.0.0.0" },
                { "Microsoft.AspNetCore.Server.IISIntegration", "5.0.0.0" },
                { "Microsoft.AspNetCore.Server.Kestrel", "5.0.0.0" },
                { "Microsoft.AspNetCore.Server.Kestrel.Core", "5.0.0.0" },
                { "Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets", "5.0.0.0" },
                { "Microsoft.AspNetCore.Session", "5.0.0.0" },
                { "Microsoft.AspNetCore.SignalR", "5.0.0.0" },
                { "Microsoft.AspNetCore.SignalR.Common", "5.0.0.0" },
                { "Microsoft.AspNetCore.SignalR.Core", "5.0.0.0" },
                { "Microsoft.AspNetCore.SignalR.Protocols.Json", "5.0.0.0" },
                { "Microsoft.AspNetCore.StaticFiles", "5.0.0.0" },
                { "Microsoft.AspNetCore.WebSockets", "5.0.0.0" },
                { "Microsoft.AspNetCore.WebUtilities", "5.0.0.0" },
                { "Microsoft.Extensions.Caching.Abstractions", "5.0.0.0" },
                { "Microsoft.Extensions.Caching.Memory", "5.0.0.0" },
                { "Microsoft.Extensions.Configuration", "5.0.0.0" },
                { "Microsoft.Extensions.Configuration.Abstractions", "5.0.0.0" },
                { "Microsoft.Extensions.Configuration.Binder", "5.0.0.0" },
                { "Microsoft.Extensions.Configuration.CommandLine", "5.0.0.0" },
                { "Microsoft.Extensions.Configuration.EnvironmentVariables", "5.0.0.0" },
                { "Microsoft.Extensions.Configuration.FileExtensions", "5.0.0.0" },
                { "Microsoft.Extensions.Configuration.Ini", "5.0.0.0" },
                { "Microsoft.Extensions.Configuration.Json", "5.0.0.0" },
                { "Microsoft.Extensions.Configuration.KeyPerFile", "5.0.0.0" },
                { "Microsoft.Extensions.Configuration.UserSecrets", "5.0.0.0" },
                { "Microsoft.Extensions.Configuration.Xml", "5.0.0.0" },
                { "Microsoft.Extensions.DependencyInjection", "5.0.0.0" },
                { "Microsoft.Extensions.DependencyInjection.Abstractions", "5.0.0.0" },
                { "Microsoft.Extensions.Diagnostics.HealthChecks", "5.0.0.0" },
                { "Microsoft.Extensions.Diagnostics.HealthChecks.Abstractions", "5.0.0.0" },
                { "Microsoft.Extensions.FileProviders.Abstractions", "5.0.0.0" },
                { "Microsoft.Extensions.FileProviders.Composite", "5.0.0.0" },
                { "Microsoft.Extensions.FileProviders.Embedded", "5.0.0.0" },
                { "Microsoft.Extensions.FileProviders.Physical", "5.0.0.0" },
                { "Microsoft.Extensions.FileSystemGlobbing", "5.0.0.0" },
                { "Microsoft.Extensions.Hosting", "5.0.0.0" },
                { "Microsoft.Extensions.Hosting.Abstractions", "5.0.0.0" },
                { "Microsoft.Extensions.Http", "5.0.0.0" },
                { "Microsoft.Extensions.Identity.Core", "5.0.0.0" },
                { "Microsoft.Extensions.Identity.Stores", "5.0.0.0" },
                { "Microsoft.Extensions.Localization", "5.0.0.0" },
                { "Microsoft.Extensions.Localization.Abstractions", "5.0.0.0" },
                { "Microsoft.Extensions.Logging", "5.0.0.0" },
                { "Microsoft.Extensions.Logging.Abstractions", "5.0.0.0" },
                { "Microsoft.Extensions.Logging.Configuration", "5.0.0.0" },
                { "Microsoft.Extensions.Logging.Console", "5.0.0.0" },
                { "Microsoft.Extensions.Logging.Debug", "5.0.0.0" },
                { "Microsoft.Extensions.Logging.EventLog", "5.0.0.0" },
                { "Microsoft.Extensions.Logging.EventSource", "5.0.0.0" },
                { "Microsoft.Extensions.Logging.TraceSource", "5.0.0.0" },
                { "Microsoft.Extensions.ObjectPool", "5.0.0.0" },
                { "Microsoft.Extensions.Options", "5.0.0.0" },
                { "Microsoft.Extensions.Options.ConfigurationExtensions", "5.0.0.0" },
                { "Microsoft.Extensions.Options.DataAnnotations", "5.0.0.0" },
                { "Microsoft.Extensions.Primitives", "5.0.0.0" },
                { "Microsoft.Extensions.WebEncoders", "5.0.0.0" },
                { "Microsoft.JSInterop", "5.0.0.0" },
                { "Microsoft.Net.Http.Headers", "5.0.0.0" },
                { "Microsoft.Win32.Registry", "5.0.0.0" },
                { "System.Diagnostics.EventLog", "5.0.0.0" },
                { "System.Security.AccessControl", "5.0.0.0" },
                { "System.Security.Cryptography.Cng", "5.0.0.0" },
                { "System.Security.Cryptography.Xml", "5.0.0.0" },
                { "System.Security.Permissions", "5.0.0.0" },
                { "System.Security.Principal.Windows", "5.0.0.0" },
                { "System.Windows.Extensions", "5.0.0.0" }
            };

            if (!VerifyAncmBinary())
            {
                ListedSharedFxAssemblies.Remove("aspnetcorev2_inprocess");
            }
        }

        public static string GetSharedFxVersion() => GetTestDataValue("SharedFxVersion");

        public static string GetMicrosoftNETCoreAppPackageVersion() => GetTestDataValue("MicrosoftNETCoreAppRuntimeVersion");

        public static string GetReferencePackSharedFxVersion() => GetTestDataValue("ReferencePackSharedFxVersion");

        public static string GetRepositoryCommit() => GetTestDataValue("RepositoryCommit");

        public static string GetSharedFxRuntimeIdentifier() => GetTestDataValue("TargetRuntimeIdentifier");

        public static string GetSharedFxDependencies() => GetTestDataValue("SharedFxDependencies");

        public static string GetTargetingPackDependencies() => GetTestDataValue("TargetingPackDependencies");

        public static string GetRuntimeTargetingPackDependencies() => GetTestDataValue("RuntimeTargetingPackDependencies");

        public static string GetAspNetCoreTargetingPackDependencies() => GetTestDataValue("AspNetCoreTargetingPackDependencies");

        public static bool VerifyAncmBinary() => string.Equals(GetTestDataValue("VerifyAncmBinary"), "true", StringComparison.OrdinalIgnoreCase);

        public static string GetTestDataValue(string key)
             => typeof(TestData).Assembly.GetCustomAttributes<TestDataAttribute>().Single(d => d.Key == key).Value;
    }
}
