﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Channels;


///<summary>
///See <a href="https://core.telegram.org/constructor/channels.channelParticipant" />
///</summary>
[TlObject(0xdfb80317)]
public sealed class TChannelParticipant : IChannelParticipant
{
    public uint ConstructorId => 0xdfb80317;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/ChannelParticipant" />
    ///</summary>
    public MyTelegram.Schema.IChannelParticipant Participant { get; set; }
    public TVector<MyTelegram.Schema.IChat> Chats { get; set; }
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Participant.Serialize(bw);
        Chats.Serialize(bw);
        Users.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Participant = br.Deserialize<MyTelegram.Schema.IChannelParticipant>();
        Chats = br.Deserialize<TVector<MyTelegram.Schema.IChat>>();
        Users = br.Deserialize<TVector<MyTelegram.Schema.IUser>>();
    }
}