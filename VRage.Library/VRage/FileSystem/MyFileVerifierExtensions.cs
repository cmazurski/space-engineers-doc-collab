﻿// Decompiled with JetBrains decompiler
// Type: VRage.FileSystem.MyFileVerifierExtensions
// Assembly: VRage.Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3595035D-D240-4390-9773-1FE64718FDDB
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\VRage.Library.dll

using System.IO;

namespace VRage.FileSystem
{
  public static class MyFileVerifierExtensions
  {
    public static Stream Verify(this IFileVerifier verifier, string path, Stream stream)
    {
      return verifier.Verify(path, stream);
    }
  }
}
