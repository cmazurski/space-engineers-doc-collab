﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.ModAPI.Ingame.IMyTerminalBlock
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87AD5BE9-1B9D-42F5-8000-067AE4AE8CE7
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using Sandbox.ModAPI;
using Sandbox.ModAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sandbox.ModAPI.Ingame
{
    public interface IMyTerminalBlock : IMyCubeBlock, IMyEntity
    {
        string CustomName { get; }

        string CustomNameWithFaction { get; }

        string DetailedInfo { get; }

        bool ShowOnHUD { get; }

        bool HasLocalPlayerAccess();

        bool HasPlayerAccess(long playerId);

        void RequestShowOnHUD(bool enable);

        void SetCustomName(string text);

        void SetCustomName(StringBuilder text);

        void GetActions(List<ITerminalAction> resultList, Func<ITerminalAction, bool> collect = null);

        void SearchActionsOfName(string name, List<ITerminalAction> resultList,
            Func<ITerminalAction, bool> collect = null);

        ITerminalAction GetActionWithName(string name);

        ITerminalProperty GetProperty(string id);

        void GetProperties(List<ITerminalProperty> resultList, Func<ITerminalProperty, bool> collect = null);
    }
}