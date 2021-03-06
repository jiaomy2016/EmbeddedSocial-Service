﻿// <copyright file="LogMetricsConfig.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace SocialPlus.Server.Metrics
{
    /// <summary>
    /// Initial configuration for logging of metrics
    /// </summary>
    public class LogMetricsConfig : IMetricsConfig
    {
        /// <summary>
        /// Gets the name of the tenant.
        /// </summary>
        /// <value>The name of the tenant.</value>
        public string TenantName { get; }

        /// <summary>
        /// Gets the name of the instance.
        /// </summary>
        /// <value>The name of the instance.</value>
        public string InstanceName { get; }

        /// <summary>
        /// Gets the name of the role.
        /// </summary>
        /// <value>The name of the role.</value>
        public string RoleName { get; }
    }
}
