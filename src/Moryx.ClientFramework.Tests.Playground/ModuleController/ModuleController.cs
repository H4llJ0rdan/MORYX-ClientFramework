// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System.Windows.Media;
using Moryx.ClientFramework.Tests.Playground.Properties;
using Moryx.WpfToolkit;

namespace Moryx.ClientFramework.Tests.Playground
{
    [ClientModule("Playground")]
    [ClassDisplay(Name = nameof(Strings.ModuleController_Playground), Description = "", ResourceType = typeof(Strings))]
    public class ModuleController : WorkspaceModuleBase<ModuleConfig>
    {
        public override Geometry Icon => MdiShapeFactory.GetShapeGeometry(MdiShapeType.Weather_Cloudy);

        protected override void OnInitialize()
        {
        }

        protected override void OnActivate()
        {
        }

        protected override void OnDeactivate(bool close)
        {
        }

        protected override IModuleWorkspace OnCreateWorkspace()
        {
            return Container.Resolve<IModuleWorkspace>(PlaygroundWorkspaceViewModel.WorkspaceName);
        }

        protected override void OnDestroyWorkspace(IModuleWorkspace workspace)
        {
        }
    }
}
