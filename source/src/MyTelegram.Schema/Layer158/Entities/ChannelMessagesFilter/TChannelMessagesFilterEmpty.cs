﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/channelMessagesFilterEmpty" />
///</summary>
[TlObject(0x94d42ee7)]
public sealed class TChannelMessagesFilterEmpty : IChannelMessagesFilter,IEmpty
{
    public uint ConstructorId => 0x94d42ee7;


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