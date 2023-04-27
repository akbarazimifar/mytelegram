﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.setDefaultReaction" />
///</summary>
[TlObject(0x4f47a016)]
public sealed class RequestSetDefaultReaction : IRequest<IBool>
{
    public uint ConstructorId => 0x4f47a016;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Reaction" />
    ///</summary>
    public MyTelegram.Schema.IReaction Reaction { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Reaction.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Reaction = br.Deserialize<MyTelegram.Schema.IReaction>();
    }
}