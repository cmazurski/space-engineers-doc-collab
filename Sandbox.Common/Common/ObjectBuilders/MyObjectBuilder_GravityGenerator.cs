﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.MyObjectBuilder_GravityGenerator
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 65B9437C-6443-4388-AFE3-5DD75CE6625F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders.VRageData;
using System.ComponentModel;

namespace Sandbox.Common.ObjectBuilders
{
  [MyObjectBuilderDefinition]
  [ProtoContract]
  public class MyObjectBuilder_GravityGenerator : MyObjectBuilder_FunctionalBlock
  {
    [ProtoMember(2)]
    public SerializableVector3 FieldSize = new SerializableVector3(150f, 150f, 150f);
    [DefaultValue(9.81f)]
    [ProtoMember(3)]
    public float GravityAcceleration = 9.81f;
  }
}
