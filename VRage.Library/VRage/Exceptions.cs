﻿// Decompiled with JetBrains decompiler
// Type: VRage.Exceptions
// Assembly: VRage.Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 98EC8A66-D3FB-4994-A617-48E1C71F8818
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\VRage.Library.dll

using System;
using System.Diagnostics;

namespace VRage
{
    public static class Exceptions
    {
        [DebuggerStepThrough]
        public static void ThrowIf<TException>(bool condition) where TException : Exception
        {
            if (condition)
                throw (Exception) Activator.CreateInstance(typeof (TException));
        }

        [DebuggerStepThrough]
        public static void ThrowIf<TException>(bool condition, string arg1) where TException : Exception
        {
            if (!condition)
                return;
            throw (Exception) Activator.CreateInstance(typeof (TException), new object[1]
            {
                (object) arg1
            });
        }

        [DebuggerStepThrough]
        public static void ThrowIf<TException>(bool condition, string arg1, string arg2) where TException : Exception
        {
            if (!condition)
                return;
            throw (Exception) Activator.CreateInstance(typeof (TException), new object[2]
            {
                (object) arg1,
                (object) arg2
            });
        }

        [DebuggerStepThrough]
        public static void ThrowIf<TException>(bool condition, params object[] args) where TException : Exception
        {
            if (condition)
                throw (Exception) Activator.CreateInstance(typeof (TException), args);
        }

        [DebuggerStepThrough]
        public static void ThrowAny<TException>(bool[] conditions, params object[] args) where TException : Exception
        {
            // lazy fix for decomplier shenanigans
        }

        [DebuggerStepThrough]
        public static void ThrowAll<TException>(bool[] conditions, params object[] args) where TException : Exception
        {
            // lazy fix for decomplier shenanigans
        }
    }
}