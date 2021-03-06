﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_PrefabDefinition
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 65B9437C-6443-4388-AFE3-5DD75CE6625F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders;
using System.Xml.Serialization;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
  [MyObjectBuilderDefinition]
  [ProtoContract]
  public class MyObjectBuilder_PrefabDefinition : MyObjectBuilder_DefinitionBase
  {
    [ProtoMember(1)]
    public bool RespawnShip;
    [ProtoMember(2)]
    public MyObjectBuilder_CubeGrid CubeGrid;
    [XmlArrayItem("CubeGrid")]
    [ProtoMember(3)]
    public MyObjectBuilder_CubeGrid[] CubeGrids;

    public bool ShouldSerializeRespawnShip()
    {
      return false;
    }

    public bool ShouldSerializeCubeGrid()
    {
      return false;
    }
  }
}
