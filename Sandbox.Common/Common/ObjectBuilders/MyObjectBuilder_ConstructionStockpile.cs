﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.MyObjectBuilder_ConstructionStockpile
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C37CB42-F216-4F7D-B6D1-CA0779A47F38
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using System.Collections.Generic;

namespace Sandbox.Common.ObjectBuilders
{
    [ProtoContract]
    [MyObjectBuilderDefinition]
    public class MyObjectBuilder_ConstructionStockpile : MyObjectBuilder_Base
    {
        [ProtoMember(1)] public List<MyObjectBuilder_StockpileItem> Items = new List<MyObjectBuilder_StockpileItem>();
    }
}