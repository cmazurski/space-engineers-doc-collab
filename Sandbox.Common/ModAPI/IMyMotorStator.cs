﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.ModAPI.IMyMotorStator
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C37CB42-F216-4F7D-B6D1-CA0779A47F38
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using Sandbox.ModAPI.Ingame;
using System;

namespace Sandbox.ModAPI
{
    public interface IMyMotorStator : Sandbox.ModAPI.Ingame.IMyMotorStator, IMyMotorBase,
        Sandbox.ModAPI.Ingame.IMyFunctionalBlock, Sandbox.ModAPI.Ingame.IMyTerminalBlock,
        Sandbox.ModAPI.Ingame.IMyCubeBlock, IMyEntity
    {
        event Action<bool> LimitReached;
    }
}