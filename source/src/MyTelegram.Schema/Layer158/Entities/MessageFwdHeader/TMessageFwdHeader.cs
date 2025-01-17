﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/messageFwdHeader" />
///</summary>
[TlObject(0x5f777dce)]
public sealed class TMessageFwdHeader : IMessageFwdHeader
{
    public uint ConstructorId => 0x5f777dce;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Imported { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer? FromId { get; set; }
    public string? FromName { get; set; }
    public int Date { get; set; }
    public int? ChannelPost { get; set; }
    public string? PostAuthor { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer? SavedFromPeer { get; set; }
    public int? SavedFromMsgId { get; set; }
    public string? PsaType { get; set; }

    public void ComputeFlag()
    {
        if (Imported) { Flags[7] = true; }
        if (FromId != null) { Flags[0] = true; }
        if (FromName != null) { Flags[5] = true; }
        if (ChannelPost != 0 && ChannelPost.HasValue) { Flags[2] = true; }
        if (PostAuthor != null) { Flags[3] = true; }
        if (SavedFromPeer != null) { Flags[4] = true; }
        if (SavedFromMsgId != 0 && SavedFromMsgId.HasValue) { Flags[4] = true; }
        if (PsaType != null) { Flags[6] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        if (Flags[0]) { FromId.Serialize(bw); }
        if (Flags[5]) { bw.Serialize(FromName); }
        bw.Write(Date);
        if (Flags[2]) { bw.Write(ChannelPost.Value); }
        if (Flags[3]) { bw.Serialize(PostAuthor); }
        if (Flags[4]) { SavedFromPeer.Serialize(bw); }
        if (Flags[4]) { bw.Write(SavedFromMsgId.Value); }
        if (Flags[6]) { bw.Serialize(PsaType); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[7]) { Imported = true; }
        if (Flags[0]) { FromId = br.Deserialize<MyTelegram.Schema.IPeer>(); }
        if (Flags[5]) { FromName = br.Deserialize<string>(); }
        Date = br.ReadInt32();
        if (Flags[2]) { ChannelPost = br.ReadInt32(); }
        if (Flags[3]) { PostAuthor = br.Deserialize<string>(); }
        if (Flags[4]) { SavedFromPeer = br.Deserialize<MyTelegram.Schema.IPeer>(); }
        if (Flags[4]) { SavedFromMsgId = br.ReadInt32(); }
        if (Flags[6]) { PsaType = br.Deserialize<string>(); }
    }
}