﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_EdgesDefinition
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 65B9437C-6443-4388-AFE3-5DD75CE6625F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
  [ProtoContract]
  [MyObjectBuilderDefinition]
  public class MyObjectBuilder_EdgesDefinition : MyObjectBuilder_DefinitionBase
  {
    [ProtoMember(1)]
    public MyEdgesModelSet Small;
    [ProtoMember(2)]
    public MyEdgesModelSet Large;
  }
}
