﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.MyObjectBuilder_AutomaticRifle
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 65B9437C-6443-4388-AFE3-5DD75CE6625F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;

namespace Sandbox.Common.ObjectBuilders
{
  [ProtoContract]
  [MyObjectBuilderDefinition]
  public class MyObjectBuilder_AutomaticRifle : MyObjectBuilder_EntityBase
  {
    public int CurrentAmmo;
    [ProtoMember(1)]
    public MyObjectBuilder_GunBase GunBase;

    public bool ShouldSerializeCurrentAmmo()
    {
      return false;
    }
  }
}
