﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/updateBotPrecheckoutQuery" />
///</summary>
[TlObject(0x8caa9a96)]
public sealed class TUpdateBotPrecheckoutQuery : IUpdate
{
    public uint ConstructorId => 0x8caa9a96;
    public BitArray Flags { get; set; } = new BitArray(32);
    public long QueryId { get; set; }
    public long UserId { get; set; }
    public byte[] Payload { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/PaymentRequestedInfo" />
    ///</summary>
    public MyTelegram.Schema.IPaymentRequestedInfo? Info { get; set; }
    public string? ShippingOptionId { get; set; }
    public string Currency { get; set; }
    public long TotalAmount { get; set; }

    public void ComputeFlag()
    {
        if (Info != null) { Flags[0] = true; }
        if (ShippingOptionId != null) { Flags[1] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Write(QueryId);
        bw.Write(UserId);
        bw.Serialize(Payload);
        if (Flags[0]) { Info.Serialize(bw); }
        if (Flags[1]) { bw.Serialize(ShippingOptionId); }
        bw.Serialize(Currency);
        bw.Write(TotalAmount);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        QueryId = br.ReadInt64();
        UserId = br.ReadInt64();
        Payload = br.Deserialize<byte[]>();
        if (Flags[0]) { Info = br.Deserialize<MyTelegram.Schema.IPaymentRequestedInfo>(); }
        if (Flags[1]) { ShippingOptionId = br.Deserialize<string>(); }
        Currency = br.Deserialize<string>();
        TotalAmount = br.ReadInt64();
    }
}