﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/webPageNotModified" />
///</summary>
[TlObject(0x7311ca11)]
public sealed class TWebPageNotModified : IWebPage
{
    public uint ConstructorId => 0x7311ca11;
    public BitArray Flags { get; set; } = new BitArray(32);
    public int? CachedPageViews { get; set; }

    public void ComputeFlag()
    {
        if (CachedPageViews != 0 && CachedPageViews.HasValue) { Flags[0] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        if (Flags[0]) { bw.Write(CachedPageViews.Value); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { CachedPageViews = br.ReadInt32(); }
    }
}