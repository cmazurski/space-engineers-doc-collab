﻿// Decompiled with JetBrains decompiler
// Type: ProtoBuf.Meta.MutableList
// Assembly: VRage.Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 98EC8A66-D3FB-4994-A617-48E1C71F8818
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\VRage.Library.dll

namespace ProtoBuf.Meta
{
    internal sealed class MutableList : BasicList
    {
        public new object this[int index]
        {
            get { return this.head[index]; }
            set { this.head[index] = value; }
        }

        public void RemoveLast()
        {
            this.head.RemoveLastWithMutate();
        }
    }
}