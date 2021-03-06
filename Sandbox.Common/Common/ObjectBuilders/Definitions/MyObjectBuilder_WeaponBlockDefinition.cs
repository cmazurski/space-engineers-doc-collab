﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_WeaponBlockDefinition
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 65B9437C-6443-4388-AFE3-5DD75CE6625F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders;
using System.Xml.Serialization;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
  [ProtoContract]
  [MyObjectBuilderDefinition]
  public class MyObjectBuilder_WeaponBlockDefinition : MyObjectBuilder_CubeBlockDefinition
  {
    [ProtoMember(1)]
    public MyObjectBuilder_WeaponBlockDefinition.WeaponBlockWeaponDefinition WeaponDefinitionId;
    [ProtoMember(2)]
    public float InventoryMaxVolume;

    [ProtoContract]
    public class WeaponBlockWeaponDefinition
    {
      [XmlIgnore]
      public MyObjectBuilderType Type = (MyObjectBuilderType) typeof (MyObjectBuilder_WeaponDefinition);
      [XmlAttribute]
      [ProtoMember(1)]
      public string Subtype;
    }
  }
}
