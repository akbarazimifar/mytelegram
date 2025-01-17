﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/messageUserVote" />
///</summary>
[TlObject(0x34d247b4)]
public sealed class TMessageUserVote : IMessageUserVote
{
    public uint ConstructorId => 0x34d247b4;
    public long UserId { get; set; }
    public byte[] Option { get; set; }
    public int Date { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(UserId);
        bw.Serialize(Option);
        bw.Write(Date);
    }

    public void Deserialize(BinaryReader br)
    {
        UserId = br.ReadInt64();
        Option = br.Deserialize<byte[]>();
        Date = br.ReadInt32();
    }
}