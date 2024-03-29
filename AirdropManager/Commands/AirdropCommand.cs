﻿using Rocket.API;
using Rocket.Core.Logging;
using System;
using System.Collections.Generic;

namespace RestoreMonarchy.AirdropManager.Commands
{
    public class AirdropCommand : IRocketCommand
    {
        private AirdropManagerPlugin pluginInstance => AirdropManagerPlugin.Instance;

        public void Execute(IRocketPlayer caller, params string[] command)
        {
            pluginInstance.CallAirdrop(false);
        }

        public string Help => "Calls in airdrop at the random spawn";

        public string Name => "airdrop";

        public string Syntax => "";

        public List<string> Aliases => new();

        public List<string> Permissions => new();

        public AllowedCaller AllowedCaller => AllowedCaller.Both;
    }
}
