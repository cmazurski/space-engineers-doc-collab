﻿// Decompiled with JetBrains decompiler
// Type: VRage.Stats.MyNameComparer
// Assembly: VRage.Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FD5D66CE-92BD-4D2D-A5F6-2A600D10290D
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\VRage.Library.dll

using System.Collections.Generic;

namespace VRage.Stats
{
    internal class MyNameComparer : Comparer<KeyValuePair<string, MyStat>>
    {
        public override int Compare(KeyValuePair<string, MyStat> x, KeyValuePair<string, MyStat> y)
        {
            return x.Key.CompareTo(y.Key);
        }
    }
}