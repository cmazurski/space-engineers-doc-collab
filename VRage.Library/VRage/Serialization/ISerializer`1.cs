﻿// Decompiled with JetBrains decompiler
// Type: VRage.Serialization.ISerializer`1
// Assembly: VRage.Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 98EC8A66-D3FB-4994-A617-48E1C71F8818
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\VRage.Library.dll

using VRage;

namespace VRage.Serialization
{
    public interface ISerializer<T>
    {
        void Serialize(ByteStream destination, ref T data);

        void Deserialize(ByteStream source, out T data);
    }
}