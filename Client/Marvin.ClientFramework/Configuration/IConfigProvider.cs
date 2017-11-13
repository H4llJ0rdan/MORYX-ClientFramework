﻿using Marvin.ClientFramework.Shell;
using Marvin.Configuration;

namespace Marvin.ClientFramework
{
    /// <summary>
    /// Interface for config providers used in module structure
    /// This provider should not be used in the kernel
    /// </summary>
    public interface IConfigProvider : IConfigManager
    {
        /// <summary>
        /// Gets the module configuration by the module name
        /// </summary>
        T GetModuleConfiguration<T>(string name) where T : class, IClientModuleConfig, new();

        /// <summary>
        /// Gets the shell configuration by the shell type.
        /// </summary>
        T GetShellConfig<T>() where T : class, IShellRegionConfig, new();
    }
}