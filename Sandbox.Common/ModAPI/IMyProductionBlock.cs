﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.ModAPI.IMyProductionBlock
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C37CB42-F216-4F7D-B6D1-CA0779A47F38
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using System;

namespace Sandbox.ModAPI
{
    public interface IMyProductionBlock : Sandbox.ModAPI.Ingame.IMyProductionBlock,
        Sandbox.ModAPI.Ingame.IMyFunctionalBlock, Sandbox.ModAPI.Ingame.IMyTerminalBlock,
        Sandbox.ModAPI.Ingame.IMyCubeBlock, IMyEntity
    {
        event Action StartedProducing;

        event Action StoppedProducing;
    }
}