﻿using System;
using System.Collections.Generic;
using Marvin.Modules;

namespace Marvin.ClientFramework
{
    /// <summary>
    /// Will initialize enabled modules and provides events for the initialization phase
    /// </summary>
    public interface IModuleManager : IDisposable, IInitializable
    {
        /// <summary>
        /// When the module manager is done with the intiailization phase, the initialized and enabled modules
        /// should be provided here
        /// </summary>
        IEnumerable<IClientModule> EnabledModules { get; }

        /// <summary>
        /// Occurs when starting to initialize a module.
        /// </summary>
        event EventHandler<IClientModule> StartInitializeModule;
        
        /// <summary>
        /// Occurs when starting to initilize all modules].
        /// </summary>
        event EventHandler<int> StartInitilizingModules;

        /// <summary>
        /// Occurs when initializing of a module is done].
        /// </summary>
        event EventHandler<IClientModule> InitializingModuleDone;
    }
}