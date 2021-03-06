﻿// Decompiled with JetBrains decompiler
// Type: VRage.Collections.DictionaryValuesReader`2
// Assembly: VRage.Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3595035D-D240-4390-9773-1FE64718FDDB
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\VRage.Library.dll

using System.Collections;
using System.Collections.Generic;

namespace VRage.Collections
{
  public struct DictionaryValuesReader<K, V> : IEnumerable<V>, IEnumerable
  {
    private readonly Dictionary<K, V> m_collection;

    public int Count
    {
      get
      {
        return this.m_collection.Count;
      }
    }

    public V this[K key]
    {
      get
      {
        return this.m_collection[key];
      }
    }

    public DictionaryValuesReader(Dictionary<K, V> collection)
    {
      this.m_collection = collection;
    }

    public static implicit operator DictionaryValuesReader<K, V>(Dictionary<K, V> v)
    {
      return new DictionaryValuesReader<K, V>(v);
    }

    public bool TryGetValue(K key, out V result)
    {
      return this.m_collection.TryGetValue(key, out result);
    }

    public Dictionary<K, V>.ValueCollection.Enumerator GetEnumerator()
    {
      return this.m_collection.Values.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this.GetEnumerator();
    }

    IEnumerator<V> IEnumerable<V>.GetEnumerator()
    {
      return (IEnumerator<V>) this.GetEnumerator();
    }
  }
}
