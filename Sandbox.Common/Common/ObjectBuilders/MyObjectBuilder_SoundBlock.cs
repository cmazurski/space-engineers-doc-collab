﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.MyObjectBuilder_SoundBlock
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AEA4A40D-6023-45C7-A56E-9FAD0E8F073F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;

namespace Sandbox.Common.ObjectBuilders
{
  [ProtoContract]
  [MyObjectBuilderDefinition]
  public class MyObjectBuilder_SoundBlock : MyObjectBuilder_FunctionalBlock
  {
    [ProtoMember(1)]
    public float Range = 50f;
    [ProtoMember(2)]
    public float Volume = 1f;
    [ProtoMember(4)]
    public float LoopPeriod = 1f;
    [ProtoMember(3)]
    public int CueId;
  }
}
