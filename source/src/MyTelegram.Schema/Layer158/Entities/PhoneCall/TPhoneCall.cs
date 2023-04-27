﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/phoneCall" />
///</summary>
[TlObject(0x967f7c67)]
public sealed class TPhoneCall : IPhoneCall
{
    public uint ConstructorId => 0x967f7c67;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool P2pAllowed { get; set; }
    public bool Video { get; set; }
    public long Id { get; set; }
    public long AccessHash { get; set; }
    public int Date { get; set; }
    public long AdminId { get; set; }
    public long ParticipantId { get; set; }
    public byte[] GAOrB { get; set; }
    public long KeyFingerprint { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/PhoneCallProtocol" />
    ///</summary>
    public MyTelegram.Schema.IPhoneCallProtocol Protocol { get; set; }
    public TVector<MyTelegram.Schema.IPhoneConnection> Connections { get; set; }
    public int StartDate { get; set; }

    public void ComputeFlag()
    {
        if (P2pAllowed) { Flags[5] = true; }
        if (Video) { Flags[6] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Write(Id);
        bw.Write(AccessHash);
        bw.Write(Date);
        bw.Write(AdminId);
        bw.Write(ParticipantId);
        bw.Serialize(GAOrB);
        bw.Write(KeyFingerprint);
        Protocol.Serialize(bw);
        Connections.Serialize(bw);
        bw.Write(StartDate);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[5]) { P2pAllowed = true; }
        if (Flags[6]) { Video = true; }
        Id = br.ReadInt64();
        AccessHash = br.ReadInt64();
        Date = br.ReadInt32();
        AdminId = br.ReadInt64();
        ParticipantId = br.ReadInt64();
        GAOrB = br.Deserialize<byte[]>();
        KeyFingerprint = br.ReadInt64();
        Protocol = br.Deserialize<MyTelegram.Schema.IPhoneCallProtocol>();
        Connections = br.Deserialize<TVector<MyTelegram.Schema.IPhoneConnection>>();
        StartDate = br.ReadInt32();
    }
}