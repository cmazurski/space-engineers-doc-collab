﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_CargoContainerDefinition
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C37CB42-F216-4F7D-B6D1-CA0779A47F38
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders;
using VRageMath;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
    [MyObjectBuilderDefinition]
    [ProtoContract]
    public class MyObjectBuilder_CargoContainerDefinition : MyObjectBuilder_CubeBlockDefinition
    {
        [ProtoMember(1)] public Vector3 InventorySize;
    }
}