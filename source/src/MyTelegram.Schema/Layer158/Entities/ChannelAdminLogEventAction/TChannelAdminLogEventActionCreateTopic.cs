﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/channelAdminLogEventActionCreateTopic" />
///</summary>
[TlObject(0x58707d28)]
public sealed class TChannelAdminLogEventActionCreateTopic : IChannelAdminLogEventAction
{
    public uint ConstructorId => 0x58707d28;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/ForumTopic" />
    ///</summary>
    public MyTelegram.Schema.IForumTopic Topic { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Topic.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Topic = br.Deserialize<MyTelegram.Schema.IForumTopic>();
    }
}