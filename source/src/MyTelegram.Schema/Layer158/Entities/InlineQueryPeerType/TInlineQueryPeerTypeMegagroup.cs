﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inlineQueryPeerTypeMegagroup" />
///</summary>
[TlObject(0x5ec4be43)]
public sealed class TInlineQueryPeerTypeMegagroup : IInlineQueryPeerType
{
    public uint ConstructorId => 0x5ec4be43;


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