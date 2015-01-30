﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.MyObjectBuilder_ConveyorPacket
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 65B9437C-6443-4388-AFE3-5DD75CE6625F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using System.ComponentModel;

namespace Sandbox.Common.ObjectBuilders
{
  [MyObjectBuilderDefinition]
  [ProtoContract]
  public class MyObjectBuilder_ConveyorPacket : MyObjectBuilder_Base
  {
    [ProtoMember(1)]
    public MyObjectBuilder_InventoryItem Item;
    [DefaultValue(0)]
    [ProtoMember(2)]
    public int LinePosition;

    public bool ShouldSerializeLinePosition()
    {
      return this.LinePosition != 0;
    }
  }
}
