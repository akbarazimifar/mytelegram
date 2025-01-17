﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;


///<summary>
///See <a href="https://core.telegram.org/constructor/messages.reactions" />
///</summary>
[TlObject(0xeafdf716)]
public sealed class TReactions : IReactions
{
    public uint ConstructorId => 0xeafdf716;
    public long Hash { get; set; }
    public TVector<MyTelegram.Schema.IReaction> Reactions { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Hash);
        Reactions.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Hash = br.ReadInt64();
        Reactions = br.Deserialize<TVector<MyTelegram.Schema.IReaction>>();
    }
}