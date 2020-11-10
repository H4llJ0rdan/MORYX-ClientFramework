// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using Moryx.ClientFramework.Configurator.Properties;

namespace Moryx.ClientFramework.Configurator
{
    [ConfigViewModelPlugin]
    internal class ProxyConfigViewModel : ConfigViewModelBase<ProxyConfig>
    {
        public override string DisplayName => Strings.ProxyConfigViewModel_Title;

        public override string ImageSource => "/Moryx.WpfToolkit;component/Images/gear.png";
    }
}
