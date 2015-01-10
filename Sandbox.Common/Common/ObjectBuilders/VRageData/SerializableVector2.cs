﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.VRageData.SerializableVector2
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AEA4A40D-6023-45C7-A56E-9FAD0E8F073F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using System.Xml.Serialization;
using VRageMath;

namespace Sandbox.Common.ObjectBuilders.VRageData
{
  [ProtoContract]
  public struct SerializableVector2
  {
    public float X;
    public float Y;

    [XmlAttribute]
    [ProtoMember(1)]
    public float x
    {
      get
      {
        return this.X;
      }
      set
      {
        this.X = value;
      }
    }

    [ProtoMember(2)]
    [XmlAttribute]
    public float y
    {
      get
      {
        return this.Y;
      }
      set
      {
        this.Y = value;
      }
    }

    public SerializableVector2(float x, float y)
    {
      this.X = x;
      this.Y = y;
    }

    public static implicit operator Vector2(SerializableVector2 v)
    {
      return new Vector2(v.X, v.Y);
    }

    public static implicit operator SerializableVector2(Vector2 v)
    {
      return new SerializableVector2(v.X, v.Y);
    }

    public bool ShouldSerializeX()
    {
      return false;
    }

    public bool ShouldSerializeY()
    {
      return false;
    }
  }
}
