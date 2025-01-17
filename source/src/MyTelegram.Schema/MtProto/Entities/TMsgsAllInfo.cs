﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


[TlObject(0x8cc0d131)]
public sealed class TMsgsAllInfo : IObject
{
    public uint ConstructorId => 0x8cc0d131;
    public TVector<long> MsgIds { get; set; }
    public byte[] Info { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        MsgIds.Serialize(bw);
        bw.Serialize(Info);
    }

    public void Deserialize(BinaryReader br)
    {
        MsgIds = br.Deserialize<TVector<long>>();
        Info = br.Deserialize<byte[]>();
    }
}