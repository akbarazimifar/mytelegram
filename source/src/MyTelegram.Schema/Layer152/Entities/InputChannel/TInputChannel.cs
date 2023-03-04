﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputChannel" />
///</summary>
[TlObject(0xf35aec28)]
public sealed class TInputChannel : IInputChannel
{
    public uint ConstructorId => 0xf35aec28;
    public long ChannelId { get; set; }
    public long AccessHash { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(ChannelId);
        bw.Write(AccessHash);
    }

    public void Deserialize(BinaryReader br)
    {
        ChannelId = br.ReadInt64();
        AccessHash = br.ReadInt64();
    }
}