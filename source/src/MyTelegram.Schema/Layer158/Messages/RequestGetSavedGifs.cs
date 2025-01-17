﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.getSavedGifs" />
///</summary>
[TlObject(0x5cf09635)]
public sealed class RequestGetSavedGifs : IRequest<MyTelegram.Schema.Messages.ISavedGifs>
{
    public uint ConstructorId => 0x5cf09635;
    public long Hash { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Hash);
    }

    public void Deserialize(BinaryReader br)
    {
        Hash = br.ReadInt64();
    }
}
