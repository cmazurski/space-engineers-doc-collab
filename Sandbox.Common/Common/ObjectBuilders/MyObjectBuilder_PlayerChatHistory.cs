﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.MyObjectBuilder_PlayerChatHistory
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4C37CB42-F216-4F7D-B6D1-CA0779A47F38
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Sandbox.Common.ObjectBuilders
{
    [MyObjectBuilderDefinition]
    [ProtoContract]
    public class MyObjectBuilder_PlayerChatHistory : MyObjectBuilder_Base
    {
        [XmlArrayItem("PCI")] [ProtoMember(1)] public List<MyObjectBuilder_PlayerChatItem> Chat;
        [ProtoMember(2)] [XmlElement(ElementName = "ID")] public long IdentityId;
    }
}