﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_ScenarioDefinitions
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C37CB42-F216-4F7D-B6D1-CA0779A47F38
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders;
using System.Xml.Serialization;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
    [ProtoContract]
    [MyObjectBuilderDefinition]
    [XmlRoot("ScenarioDefinitions")]
    public class MyObjectBuilder_ScenarioDefinitions : MyObjectBuilder_Base
    {
        [ProtoMember(1)] [XmlArrayItem("ScenarioDefinition")] public MyObjectBuilder_ScenarioDefinition[] Scenarios;
    }
}