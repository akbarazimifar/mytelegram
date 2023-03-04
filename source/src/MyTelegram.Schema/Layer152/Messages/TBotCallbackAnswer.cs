﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;


///<summary>
///See <a href="https://core.telegram.org/constructor/messages.botCallbackAnswer" />
///</summary>
[TlObject(0x36585ea4)]
public sealed class TBotCallbackAnswer : IBotCallbackAnswer
{
    public uint ConstructorId => 0x36585ea4;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Alert { get; set; }
    public bool HasUrl { get; set; }
    public bool NativeUi { get; set; }
    public string? Message { get; set; }
    public string? Url { get; set; }
    public int CacheTime { get; set; }

    public void ComputeFlag()
    {
        if (Alert) { Flags[1] = true; }
        if (HasUrl) { Flags[3] = true; }
        if (NativeUi) { Flags[4] = true; }
        if (Message != null) { Flags[0] = true; }
        if (Url != null) { Flags[2] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        if (Flags[0]) { bw.Serialize(Message); }
        if (Flags[2]) { bw.Serialize(Url); }
        bw.Write(CacheTime);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[1]) { Alert = true; }
        if (Flags[3]) { HasUrl = true; }
        if (Flags[4]) { NativeUi = true; }
        if (Flags[0]) { Message = br.Deserialize<string>(); }
        if (Flags[2]) { Url = br.Deserialize<string>(); }
        CacheTime = br.ReadInt32();
    }
}