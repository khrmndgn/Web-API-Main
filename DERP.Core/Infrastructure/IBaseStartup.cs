﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DERP.Core.Infrastructure;

public interface IBaseStartup
{
    /// <summary>
    /// Add and configure any of the middleware
    /// </summary>
    /// <param name="services">Collection of service descriptors</param>
    /// <param name="configuration">Configuration root of the application</param>
    void ConfigureServices(IServiceCollection services, IConfiguration configuration);

    /// <summary>
    /// Configure the using of added middleware
    /// </summary>
    /// <param name="app">Builder for configuring an application's request pipeline</param>
    /// <param name="webHostEnvironment">WebHostEnvironment</param>
    void Configure(IApplicationBuilder app, IWebHostEnvironment webHostEnvironment);

    /// <summary>
    /// Gets order of this startup configuration implementation
    /// </summary>
    int Order { get; }
}