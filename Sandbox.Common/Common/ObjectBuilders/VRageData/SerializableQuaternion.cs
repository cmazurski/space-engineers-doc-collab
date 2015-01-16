﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.VRageData.SerializableQuaternion
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C37CB42-F216-4F7D-B6D1-CA0779A47F38
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using System.Xml.Serialization;
using VRageMath;

namespace Sandbox.Common.ObjectBuilders.VRageData
{
    [ProtoContract]
    public struct SerializableQuaternion
    {
        public float X;
        public float Y;
        public float Z;
        public float W;

        [XmlAttribute]
        [ProtoMember(1)]
        public float x
        {
            get { return this.X; }
            set { this.X = value; }
        }

        [XmlAttribute]
        [ProtoMember(2)]
        public float y
        {
            get { return this.Y; }
            set { this.Y = value; }
        }

        [XmlAttribute]
        [ProtoMember(3)]
        public float z
        {
            get { return this.Z; }
            set { this.Z = value; }
        }

        [ProtoMember(4)]
        [XmlAttribute]
        public float w
        {
            get { return this.W; }
            set { this.W = value; }
        }

        public SerializableQuaternion(float x, float y, float z, float w)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.W = w;
        }

        public static implicit operator Quaternion(SerializableQuaternion q)
        {
            return new Quaternion(q.X, q.Y, q.Z, q.W);
        }

        public static implicit operator SerializableQuaternion(Quaternion q)
        {
            return new SerializableQuaternion(q.X, q.Y, q.Z, q.W);
        }

        public bool ShouldSerializeX()
        {
            return false;
        }

        public bool ShouldSerializeY()
        {
            return false;
        }

        public bool ShouldSerializeZ()
        {
            return false;
        }

        public bool ShouldSerializeW()
        {
            return false;
        }
    }
}