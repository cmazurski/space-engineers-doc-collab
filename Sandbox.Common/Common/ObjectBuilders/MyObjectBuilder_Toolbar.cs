﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.MyObjectBuilder_Toolbar
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C37CB42-F216-4F7D-B6D1-CA0779A47F38
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using VRageMath;

namespace Sandbox.Common.ObjectBuilders
{
    [MyObjectBuilderDefinition]
    [ProtoContract]
    public class MyObjectBuilder_Toolbar : MyObjectBuilder_Base
    {
        [DefaultValue(null)] [ProtoMember(2)] public int? SelectedSlot = new int?();
        [ProtoMember(1)] public MyToolbarType ToolbarType;
        [ProtoMember(3)] public List<MyObjectBuilder_Toolbar.Slot> Slots;
        [ProtoMember(4)] public List<Vector3> ColorMaskHSVList;

        public void Remap(IMyRemapHelper remapHelper)
        {
            if (this.Slots == null)
                return;
            foreach (MyObjectBuilder_Toolbar.Slot slot in this.Slots)
                slot.Data.Remap(remapHelper);
        }

        [ProtoContract]
        public struct Slot
        {
            [ProtoMember(1)] public int Index;
            [ProtoMember(2)] public string Item;
            [ProtoMember(3)] public MyObjectBuilder_ToolbarItem Data;
        }
    }
}