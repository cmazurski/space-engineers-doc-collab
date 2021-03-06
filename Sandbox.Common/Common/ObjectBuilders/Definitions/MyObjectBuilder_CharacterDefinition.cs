﻿// Decompiled with JetBrains decompiler
// Type: Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_CharacterDefinition
// Assembly: Sandbox.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 65B9437C-6443-4388-AFE3-5DD75CE6625F
// Assembly location: D:\Games\Steam Library\SteamApps\common\SpaceEngineers\Bin64\Sandbox.Common.dll

using ProtoBuf;
using Sandbox.Common.ObjectBuilders;
using System.Xml.Serialization;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
  [MyObjectBuilderDefinition]
  [ProtoContract]
  public class MyObjectBuilder_CharacterDefinition : MyObjectBuilder_DefinitionBase
  {
    [ModdableContentFile("dds")]
    [ProtoMember(3)]
    public string ReflectorTexture = "Textures\\Lights\\reflector.dds";
    [ProtoMember(4)]
    public string LeftGlare = "GlareHeadlight";
    [ProtoMember(5)]
    public string RightGlare = "GlareHeadlight";
    [ProtoMember(6)]
    public string Skeleton = "Humanoid";
    [ProtoMember(7)]
    public float LightGlareSize = 0.02f;
    [ProtoMember(9)]
    public float JetpackSlowdown = 0.975f;
    [ProtoMember(12)]
    public string LeftLightBone = "LeftLightDummy";
    [ProtoMember(13)]
    public string RightLightBone = "RightLightDummy";
    [ProtoMember(14)]
    public string HeadBone = "HeadDummy";
    [ProtoMember(15)]
    public string LeftHandIKStartBone = "l_Clavicle";
    [ProtoMember(16)]
    public string LeftHandIKEndBone = "l_Hand";
    [ProtoMember(17)]
    public string RightHandIKStartBone = "r_Clavicle";
    [ProtoMember(18)]
    public string RightHandIKEndBone = "r_Hand";
    [ProtoMember(19)]
    public string WeaponBone = "r_Hand";
    [ProtoMember(20)]
    public string Camera3rdBone = "HeadDummy";
    [ProtoMember(21)]
    public string LeftHandItemBone = "l_hand";
    [ProtoMember(1)]
    public string Name;
    [ProtoMember(2)]
    [ModdableContentFile("mwm")]
    public string Model;
    [ProtoMember(8)]
    public bool JetpackAvailable;
    [XmlArrayItem("Thrust")]
    [ProtoMember(10)]
    public MyJetpackThrustDefinition[] Thrusts;
    [ProtoMember(11)]
    [XmlArrayItem("BoneSet")]
    public MyBoneSetDefinition[] BoneSets;
  }
}
