﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.ModAPI.IMyTerminalBlock
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C37CB42-F216-4F7D-B6D1-CA0779A47F38
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using System;

namespace Sandbox.ModAPI
{
    public interface IMyTerminalBlock : Sandbox.ModAPI.Ingame.IMyTerminalBlock, Sandbox.ModAPI.Ingame.IMyCubeBlock,
        IMyEntity
    {
        event Action<IMyTerminalBlock> CustomNameChanged;

        event Action<IMyTerminalBlock> OwnershipChanged;

        event Action<IMyTerminalBlock> PropertiesChanged;

        event Action<IMyTerminalBlock> ShowOnHUDChanged;

        event Action<IMyTerminalBlock> VisibilityChanged;
    }
}