﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/page" />
///</summary>
[TlObject(0x98657f0d)]
public sealed class TPage : IPage
{
    public uint ConstructorId => 0x98657f0d;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Part { get; set; }
    public bool Rtl { get; set; }
    public bool V2 { get; set; }
    public string Url { get; set; }
    public TVector<MyTelegram.Schema.IPageBlock> Blocks { get; set; }
    public TVector<MyTelegram.Schema.IPhoto> Photos { get; set; }
    public TVector<MyTelegram.Schema.IDocument> Documents { get; set; }
    public int? Views { get; set; }

    public void ComputeFlag()
    {
        if (Part) { Flags[0] = true; }
        if (Rtl) { Flags[1] = true; }
        if (V2) { Flags[2] = true; }
        if (Views != 0 && Views.HasValue) { Flags[3] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Serialize(Url);
        Blocks.Serialize(bw);
        Photos.Serialize(bw);
        Documents.Serialize(bw);
        if (Flags[3]) { bw.Write(Views.Value); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Part = true; }
        if (Flags[1]) { Rtl = true; }
        if (Flags[2]) { V2 = true; }
        Url = br.Deserialize<string>();
        Blocks = br.Deserialize<TVector<MyTelegram.Schema.IPageBlock>>();
        Photos = br.Deserialize<TVector<MyTelegram.Schema.IPhoto>>();
        Documents = br.Deserialize<TVector<MyTelegram.Schema.IDocument>>();
        if (Flags[3]) { Views = br.ReadInt32(); }
    }
}