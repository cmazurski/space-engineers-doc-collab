﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.ModAPI.IMyGamePaths
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AEA4A40D-6023-45C7-A56E-9FAD0E8F073F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

namespace Sandbox.ModAPI
{
  public interface IMyGamePaths
  {
    string ContentPath { get; }

    string ModsPath { get; }

    string UserDataPath { get; }

    string SavesPath { get; }
  }
}
