﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/channelParticipantsBots" />
///</summary>
[TlObject(0xb0d1865b)]
public sealed class TChannelParticipantsBots : IChannelParticipantsFilter
{
    public uint ConstructorId => 0xb0d1865b;


    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);

    }

    public void Deserialize(BinaryReader br)
    {

    }
}