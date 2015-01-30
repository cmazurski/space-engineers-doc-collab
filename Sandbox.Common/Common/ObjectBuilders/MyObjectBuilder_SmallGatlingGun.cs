﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.MyObjectBuilder_SmallGatlingGun
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 65B9437C-6443-4388-AFE3-5DD75CE6625F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using System.ComponentModel;

namespace Sandbox.Common.ObjectBuilders
{
  [MyObjectBuilderDefinition]
  [ProtoContract]
  public class MyObjectBuilder_SmallGatlingGun : MyObjectBuilder_UserControllableGun
  {
    [DefaultValue(true)]
    [ProtoMember(2)]
    public bool UseConveyorSystem = true;
    [ProtoMember(1)]
    public MyObjectBuilder_Inventory Inventory;
    [ProtoMember(3)]
    public MyObjectBuilder_GunBase GunBase;

    public override void SetupForProjector()
    {
      base.SetupForProjector();
      if (this.Inventory == null)
        return;
      this.Inventory.Clear();
    }
  }
}
