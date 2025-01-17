﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.LayerN;

[TlObject(0xd0d9b163)]
public class TChannelParticipant : IChannelParticipant
{
    public uint ConstructorId => 0xd0d9b163;

    public Schema.IChannelParticipant Participant { get; set; }

    //public TVector<MyTelegram.Schema.IChat> Chats { get; set; }
    public TVector<Schema.IUser> Users { get; set; }

    public void Serialize(BinaryWriter bw)
    {
        bw.Write(ConstructorId);
        ComputeFlag();
        SerializerFactory.CreateObjectSerializer<Schema.IChannelParticipant>().Serialize(Participant, bw);
        //SerializerFactory.CreateObjectSerializer<TVector<MyTelegram.Schema.IChat>>().Serialize(Chats,bw);
        SerializerFactory.CreateObjectSerializer<TVector<Schema.IUser>>().Serialize(Users, bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Participant = SerializerFactory.CreateObjectSerializer<Schema.IChannelParticipant>().Deserialize(br);
        //Chats = SerializerFactory.CreateObjectSerializer<TVector<MyTelegram.Schema.IChat>>().Deserialize(br);
        Users = SerializerFactory.CreateObjectSerializer<TVector<Schema.IUser>>().Deserialize(br);
    }


    public void ComputeFlag()
    {
    }
}
