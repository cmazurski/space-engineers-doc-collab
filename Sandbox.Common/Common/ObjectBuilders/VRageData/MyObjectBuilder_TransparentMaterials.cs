﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.VRageData.MyObjectBuilder_TransparentMaterials
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 65B9437C-6443-4388-AFE3-5DD75CE6625F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders;
using System.Xml.Serialization;

namespace Sandbox.Common.ObjectBuilders.VRageData
{
  [ProtoContract]
  [MyObjectBuilderDefinition]
  public class MyObjectBuilder_TransparentMaterials : MyObjectBuilder_Base
  {
    [XmlArrayItem("TransparentMaterial")]
    [ProtoMember(1)]
    public MyObjectBuilder_TransparentMaterial[] Materials;
  }
}
