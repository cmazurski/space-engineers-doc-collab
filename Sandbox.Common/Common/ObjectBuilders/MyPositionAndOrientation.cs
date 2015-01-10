﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.MyPositionAndOrientation
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AEA4A40D-6023-45C7-A56E-9FAD0E8F073F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders.VRageData;
using System.Xml.Serialization;
using VRageMath;

namespace Sandbox.Common.ObjectBuilders
{
  [ProtoContract]
  public struct MyPositionAndOrientation
  {
    public static readonly MyPositionAndOrientation Default = new MyPositionAndOrientation((Vector3D) Vector3.Zero, Vector3.Forward, Vector3.Up);
    [XmlElement("Position")]
    [ProtoMember(1)]
    public SerializableVector3D Position;
    [ProtoMember(2)]
    [XmlElement("Forward")]
    public SerializableVector3 Forward;
    [ProtoMember(3)]
    [XmlElement("Up")]
    public SerializableVector3 Up;

    public MyPositionAndOrientation(Vector3D position, Vector3 forward, Vector3 up)
    {
      this.Position = (SerializableVector3D) position;
      this.Forward = (SerializableVector3) forward;
      this.Up = (SerializableVector3) up;
    }

    public MyPositionAndOrientation(ref MatrixD matrix)
    {
      this.Position = (SerializableVector3D) matrix.Translation;
      this.Forward = (SerializableVector3) (Vector3) matrix.Forward;
      this.Up = (SerializableVector3) (Vector3) matrix.Up;
    }

    public MyPositionAndOrientation(MatrixD matrix)
    {
      this = new MyPositionAndOrientation(matrix.Translation, (Vector3) matrix.Forward, (Vector3) matrix.Up);
    }

    public MatrixD GetMatrix()
    {
      return MatrixD.CreateWorld((Vector3D) this.Position, (Vector3) this.Forward, (Vector3) this.Up);
    }

    public override string ToString()
    {
      return this.Position.ToString() + "; " + this.Forward.ToString() + "; " + this.Up.ToString();
    }
  }
}
