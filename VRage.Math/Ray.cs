﻿// Decompiled with JetBrains decompiler
// Type: VRageMath.Ray
// Assembly: VRage.Math, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 76578FE0-3A72-4D7F-8EAF-153F1DCC9FAC
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\VRage.Math.dll

using System;
using System.Globalization;

namespace VRageMath
{
  [Serializable]
  public struct Ray : IEquatable<Ray>
  {
    public Vector3 Position;
    public Vector3 Direction;

    public Ray(Vector3 position, Vector3 direction)
    {
      this.Position = position;
      this.Direction = direction;
    }

    public static bool operator ==(Ray a, Ray b)
    {
      if ((double) a.Position.X == (double) b.Position.X && (double) a.Position.Y == (double) b.Position.Y && ((double) a.Position.Z == (double) b.Position.Z && (double) a.Direction.X == (double) b.Direction.X) && (double) a.Direction.Y == (double) b.Direction.Y)
        return (double) a.Direction.Z == (double) b.Direction.Z;
      else
        return false;
    }

    public static bool operator !=(Ray a, Ray b)
    {
      if ((double) a.Position.X == (double) b.Position.X && (double) a.Position.Y == (double) b.Position.Y && ((double) a.Position.Z == (double) b.Position.Z && (double) a.Direction.X == (double) b.Direction.X) && (double) a.Direction.Y == (double) b.Direction.Y)
        return (double) a.Direction.Z != (double) b.Direction.Z;
      else
        return true;
    }

    public bool Equals(Ray other)
    {
      if ((double) this.Position.X == (double) other.Position.X && (double) this.Position.Y == (double) other.Position.Y && ((double) this.Position.Z == (double) other.Position.Z && (double) this.Direction.X == (double) other.Direction.X) && (double) this.Direction.Y == (double) other.Direction.Y)
        return (double) this.Direction.Z == (double) other.Direction.Z;
      else
        return false;
    }

    public override bool Equals(object obj)
    {
      bool flag = false;
      if (obj != null && obj is Ray)
        flag = this.Equals((Ray) obj);
      return flag;
    }

    public override int GetHashCode()
    {
      return this.Position.GetHashCode() + this.Direction.GetHashCode();
    }

    public override string ToString()
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{{Position:{0} Direction:{1}}}", new object[2]
      {
        (object) this.Position.ToString(),
        (object) this.Direction.ToString()
      });
    }

    public float? Intersects(BoundingBox box)
    {
      return box.Intersects(this);
    }

    public void Intersects(ref BoundingBox box, out float? result)
    {
      box.Intersects(ref this, out result);
    }

    public float? Intersects(BoundingFrustum frustum)
    {
      if (frustum == (BoundingFrustum) null)
        throw new ArgumentNullException("frustum");
      else
        return frustum.Intersects(this);
    }

    public float? Intersects(Plane plane)
    {
      float num1 = (float) ((double) plane.Normal.X * (double) this.Direction.X + (double) plane.Normal.Y * (double) this.Direction.Y + (double) plane.Normal.Z * (double) this.Direction.Z);
      if ((double) Math.Abs(num1) < 9.99999974737875E-06)
        return new float?();
      float num2 = (float) ((double) plane.Normal.X * (double) this.Position.X + (double) plane.Normal.Y * (double) this.Position.Y + (double) plane.Normal.Z * (double) this.Position.Z);
      float num3 = (-plane.D - num2) / num1;
      if ((double) num3 < 0.0)
      {
        if ((double) num3 < -9.99999974737875E-06)
          return new float?();
        num3 = 0.0f;
      }
      return new float?(num3);
    }

    public void Intersects(ref Plane plane, out float? result)
    {
      float num1 = (float) ((double) plane.Normal.X * (double) this.Direction.X + (double) plane.Normal.Y * (double) this.Direction.Y + (double) plane.Normal.Z * (double) this.Direction.Z);
      if ((double) Math.Abs(num1) < 9.99999974737875E-06)
      {
        result = new float?();
      }
      else
      {
        float num2 = (float) ((double) plane.Normal.X * (double) this.Position.X + (double) plane.Normal.Y * (double) this.Position.Y + (double) plane.Normal.Z * (double) this.Position.Z);
        float num3 = (-plane.D - num2) / num1;
        if ((double) num3 < 0.0)
        {
          if ((double) num3 < -9.99999974737875E-06)
          {
            result = new float?();
            return;
          }
          else
            result = new float?(0.0f);
        }
        result = new float?(num3);
      }
    }

    public float? Intersects(BoundingSphere sphere)
    {
      float num1 = sphere.Center.X - this.Position.X;
      float num2 = sphere.Center.Y - this.Position.Y;
      float num3 = sphere.Center.Z - this.Position.Z;
      float num4 = (float) ((double) num1 * (double) num1 + (double) num2 * (double) num2 + (double) num3 * (double) num3);
      float num5 = sphere.Radius * sphere.Radius;
      if ((double) num4 <= (double) num5)
        return new float?(0.0f);
      float num6 = (float) ((double) num1 * (double) this.Direction.X + (double) num2 * (double) this.Direction.Y + (double) num3 * (double) this.Direction.Z);
      if ((double) num6 < 0.0)
        return new float?();
      float num7 = num4 - num6 * num6;
      if ((double) num7 > (double) num5)
        return new float?();
      float num8 = (float) Math.Sqrt((double) num5 - (double) num7);
      return new float?(num6 - num8);
    }

    public void Intersects(ref BoundingSphere sphere, out float? result)
    {
      float num1 = sphere.Center.X - this.Position.X;
      float num2 = sphere.Center.Y - this.Position.Y;
      float num3 = sphere.Center.Z - this.Position.Z;
      float num4 = (float) ((double) num1 * (double) num1 + (double) num2 * (double) num2 + (double) num3 * (double) num3);
      float num5 = sphere.Radius * sphere.Radius;
      if ((double) num4 <= (double) num5)
      {
        result = new float?(0.0f);
      }
      else
      {
        result = new float?();
        float num6 = (float) ((double) num1 * (double) this.Direction.X + (double) num2 * (double) this.Direction.Y + (double) num3 * (double) this.Direction.Z);
        if ((double) num6 < 0.0)
          return;
        float num7 = num4 - num6 * num6;
        if ((double) num7 > (double) num5)
          return;
        float num8 = (float) Math.Sqrt((double) num5 - (double) num7);
        result = new float?(num6 - num8);
      }
    }
  }
}
