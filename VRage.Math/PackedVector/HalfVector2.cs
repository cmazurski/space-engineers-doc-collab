﻿// Decompiled with JetBrains decompiler
// Type: VRageMath.PackedVector.HalfVector2
// Assembly: VRage.Math, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0D0468A-72EF-4E34-8D6D-888CDEEC91D0
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\VRage.Math.dll

using System;
using VRageMath;

namespace VRageMath.PackedVector
{
    public struct HalfVector2 : IPackedVector<uint>, IPackedVector, IEquatable<HalfVector2>
    {
        private uint packedValue;

        public uint PackedValue
        {
            get { return this.packedValue; }
            set { this.packedValue = value; }
        }

        public HalfVector2(float x, float y)
        {
            this.packedValue = HalfVector2.PackHelper(x, y);
        }

        public HalfVector2(Vector2 vector)
        {
            this.packedValue = HalfVector2.PackHelper(vector.X, vector.Y);
        }

        public static bool operator ==(HalfVector2 a, HalfVector2 b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(HalfVector2 a, HalfVector2 b)
        {
            return !a.Equals(b);
        }

        void IPackedVector.PackFromVector4(Vector4 vector)
        {
            this.packedValue = HalfVector2.PackHelper(vector.X, vector.Y);
        }

        private static uint PackHelper(float vectorX, float vectorY)
        {
            return (uint) HalfUtils.Pack(vectorX) | (uint) HalfUtils.Pack(vectorY) << 16;
        }

        public Vector2 ToVector2()
        {
            Vector2 vector2;
            vector2.X = HalfUtils.Unpack((ushort) this.packedValue);
            vector2.Y = HalfUtils.Unpack((ushort) (this.packedValue >> 16));
            return vector2;
        }

        Vector4 IPackedVector.ToVector4()
        {
            Vector2 vector2 = this.ToVector2();
            return new Vector4(vector2.X, vector2.Y, 0.0f, 1f);
        }

        public override string ToString()
        {
            return this.ToVector2().ToString();
        }

        public override int GetHashCode()
        {
            return this.packedValue.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is HalfVector2)
                return this.Equals((HalfVector2) obj);
            else
                return false;
        }

        public bool Equals(HalfVector2 other)
        {
            return this.packedValue.Equals(other.packedValue);
        }
    }
}