﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.MyObjectBuilder_FactionChatHistory
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 65B9437C-6443-4388-AFE3-5DD75CE6625F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Sandbox.Common.ObjectBuilders
{
  [ProtoContract]
  [MyObjectBuilderDefinition]
  public class MyObjectBuilder_FactionChatHistory : MyObjectBuilder_Base
  {
    [XmlArrayItem("FCI")]
    [ProtoMember(1)]
    public List<MyObjectBuilder_FactionChatItem> Chat;
    [ProtoMember(2)]
    [XmlElement(ElementName = "ID1")]
    public long FactionId1;
    [XmlElement(ElementName = "ID2")]
    public long FactionId2;
  }
}
