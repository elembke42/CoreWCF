﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// While not auto-generated, this file is automatically included by consumers of the NuGet package.
// To prevent analyzer warnings in consuming projects, it's marked as auto-generated.
// <auto-generated/>

using System;

namespace CoreWCF.Configuration
{
    public static class WebApplicationExtensions
    {
        public static Microsoft.Extensions.Hosting.IHost UseServiceModel(this Microsoft.AspNetCore.Builder.WebApplication app, Action<IServiceBuilder> configureServices)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            ((Microsoft.AspNetCore.Builder.IApplicationBuilder)app).UseServiceModel(configureServices);
            return app;
        }
    }
}
