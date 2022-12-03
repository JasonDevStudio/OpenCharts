﻿using System.Runtime.CompilerServices;
using Autofac;
using Autofac.Core;

namespace OpenCharts;

public static class GlobaService
{
    /// <summary>
    /// The container builder
    /// </summary>
    public static ContainerBuilder ContainerBuilder = new ContainerBuilder();

    /// <summary>
    /// Gets or sets the container.
    /// </summary>
    /// <value>
    /// The container.
    /// </value>
    public static IContainer Container { get; set; }

    /// <summary>
    /// Gets the service.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="key">The key.</param>
    /// <returns>T</returns>
    public static T GetService<T>(object key = null) => key == null ? Container.Resolve<T>() : Container.ResolveKeyed<T>(key);
}
