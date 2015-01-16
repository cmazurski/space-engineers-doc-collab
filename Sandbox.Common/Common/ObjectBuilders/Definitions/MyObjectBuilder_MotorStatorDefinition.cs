﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_MotorStatorDefinition
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C37CB42-F216-4F7D-B6D1-CA0779A47F38
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
    [MyObjectBuilderDefinition]
    [ProtoContract]
    public class MyObjectBuilder_MotorStatorDefinition : MyObjectBuilder_CubeBlockDefinition
    {
        [ProtoMember(1)] public float RequiredPowerInput;
        [ProtoMember(2)] public float MaxForceMagnitude;
        [ProtoMember(3)] public string RotorPart;
        [ProtoMember(4)] public float RotorDisplacementMin;
        [ProtoMember(5)] public float RotorDisplacementMax;
        [ProtoMember(6)] public float RotorDisplacementInModel;
    }
}