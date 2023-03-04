﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputMediaPhoto" />
///</summary>
[TlObject(0xb3ba0635)]
public sealed class TInputMediaPhoto : IInputMedia
{
    public uint ConstructorId => 0xb3ba0635;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Spoiler { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputPhoto" />
    ///</summary>
    public MyTelegram.Schema.IInputPhoto Id { get; set; }
    public int? TtlSeconds { get; set; }

    public void ComputeFlag()
    {
        if (Spoiler) { Flags[1] = true; }
        if (TtlSeconds != 0 && TtlSeconds.HasValue) { Flags[0] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        Id.Serialize(bw);
        if (Flags[0]) { bw.Write(TtlSeconds.Value); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[1]) { Spoiler = true; }
        Id = br.Deserialize<MyTelegram.Schema.IInputPhoto>();
        if (Flags[0]) { TtlSeconds = br.ReadInt32(); }
    }
}