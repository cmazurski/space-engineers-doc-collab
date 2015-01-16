﻿// Decompiled with JetBrains decompiler
// Type: System.ArrayExtensions
// Assembly: VRage.Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 98EC8A66-D3FB-4994-A617-48E1C71F8818
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\VRage.Library.dll

using VRage.Extensions;

namespace System
{
    public static class ArrayExtensions
    {
        public static bool IsValidIndex<T>(this T[] self, int index)
        {
            if (0 <= index)
                return index < self.Length;
            else
                return false;
        }

        public static bool TryGetValue<T>(this T[] self, int index, out T value)
        {
            if ((uint) index < (uint) self.Length)
            {
                value = self[index];
                return true;
            }
            else
            {
                value = default (T);
                return false;
            }
        }

        public static ArrayOfTypeEnumerator<TBase, ArrayEnumerator<TBase>, T> OfTypeFast<TBase, T>(this TBase[] array)
            where T : TBase
        {
            return new ArrayOfTypeEnumerator<TBase, ArrayEnumerator<TBase>, T>(new ArrayEnumerator<TBase>(array));
        }
    }
}