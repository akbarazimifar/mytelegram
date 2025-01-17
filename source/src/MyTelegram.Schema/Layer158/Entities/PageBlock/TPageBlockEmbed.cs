﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/pageBlockEmbed" />
///</summary>
[TlObject(0xa8718dc5)]
public sealed class TPageBlockEmbed : IPageBlock
{
    public uint ConstructorId => 0xa8718dc5;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool FullWidth { get; set; }
    public bool AllowScrolling { get; set; }
    public string? Url { get; set; }
    public string? Html { get; set; }
    public long? PosterPhotoId { get; set; }
    public int? W { get; set; }
    public int? H { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/PageCaption" />
    ///</summary>
    public MyTelegram.Schema.IPageCaption Caption { get; set; }

    public void ComputeFlag()
    {
        if (FullWidth) { Flags[0] = true; }
        if (AllowScrolling) { Flags[3] = true; }
        if (Url != null) { Flags[1] = true; }
        if (Html != null) { Flags[2] = true; }
        if (PosterPhotoId != 0 && PosterPhotoId.HasValue) { Flags[4] = true; }
        if (W != 0 && W.HasValue) { Flags[5] = true; }
        if (H != 0 && H.HasValue) { Flags[5] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        if (Flags[1]) { bw.Serialize(Url); }
        if (Flags[2]) { bw.Serialize(Html); }
        if (Flags[4]) { bw.Write(PosterPhotoId.Value); }
        if (Flags[5]) { bw.Write(W.Value); }
        if (Flags[5]) { bw.Write(H.Value); }
        Caption.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { FullWidth = true; }
        if (Flags[3]) { AllowScrolling = true; }
        if (Flags[1]) { Url = br.Deserialize<string>(); }
        if (Flags[2]) { Html = br.Deserialize<string>(); }
        if (Flags[4]) { PosterPhotoId = br.ReadInt64(); }
        if (Flags[5]) { W = br.ReadInt32(); }
        if (Flags[5]) { H = br.ReadInt32(); }
        Caption = br.Deserialize<MyTelegram.Schema.IPageCaption>();
    }
}