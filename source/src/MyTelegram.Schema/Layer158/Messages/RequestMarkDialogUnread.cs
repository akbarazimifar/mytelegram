﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.markDialogUnread" />
///</summary>
[TlObject(0xc286d98f)]
public sealed class RequestMarkDialogUnread : IRequest<IBool>
{
    public uint ConstructorId => 0xc286d98f;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Unread { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputDialogPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputDialogPeer Peer { get; set; }

    public void ComputeFlag()
    {
        if (Unread) { Flags[0] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        Peer.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Unread = true; }
        Peer = br.Deserialize<MyTelegram.Schema.IInputDialogPeer>();
    }
}
