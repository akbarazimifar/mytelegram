﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/updateMessageReactions" />
///</summary>
[TlObject(0x5e1b3cb8)]
public sealed class TUpdateMessageReactions : IUpdate
{
    public uint ConstructorId => 0x5e1b3cb8;
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer Peer { get; set; }
    public int MsgId { get; set; }
    public int? TopMsgId { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/MessageReactions" />
    ///</summary>
    public MyTelegram.Schema.IMessageReactions Reactions { get; set; }

    public void ComputeFlag()
    {
        if (TopMsgId != 0 && TopMsgId.HasValue) { Flags[0] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        Peer.Serialize(bw);
        bw.Write(MsgId);
        if (Flags[0]) { bw.Write(TopMsgId.Value); }
        Reactions.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        Peer = br.Deserialize<MyTelegram.Schema.IPeer>();
        MsgId = br.ReadInt32();
        if (Flags[0]) { TopMsgId = br.ReadInt32(); }
        Reactions = br.Deserialize<MyTelegram.Schema.IMessageReactions>();
    }
}