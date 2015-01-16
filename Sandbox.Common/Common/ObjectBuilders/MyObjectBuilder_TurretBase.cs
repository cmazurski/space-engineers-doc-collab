﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.MyObjectBuilder_TurretBase
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C37CB42-F216-4F7D-B6D1-CA0779A47F38
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using System.ComponentModel;

namespace Sandbox.Common.ObjectBuilders
{
    [MyObjectBuilderDefinition]
    [ProtoContract]
    public class MyObjectBuilder_TurretBase : MyObjectBuilder_FunctionalBlock
    {
        [ProtoMember(2)] [DefaultValue(800)] public float Range = 800f;
        [DefaultValue(true)] [ProtoMember(6)] public bool TargetMeteors = true;
        [ProtoMember(1)] public MyObjectBuilder_Inventory Inventory;
        [ProtoMember(4)] public int RemainingAmmo;
        [ProtoMember(5)] public long Target;
        [ProtoMember(7)] [DefaultValue(false)] public bool TargetMoving;
        [ProtoMember(8)] [DefaultValue(false)] public bool TargetMissiles;
        [ProtoMember(9)] public bool IsPotentialTarget;
        [ProtoMember(10)] public long? PreviousControlledEntityId;
        [ProtoMember(11)] public float Rotation;
        [ProtoMember(12)] public float Elevation;
        [ProtoMember(13)] public bool IsShooting;
        [ProtoMember(14)] public MyObjectBuilder_GunBase GunBase;

        public override void SetupForProjector()
        {
            base.SetupForProjector();
            if (this.Inventory == null)
                return;
            this.Inventory.Clear();
        }
    }
}