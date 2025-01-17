﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/pageBlockAudio" />
///</summary>
[TlObject(0x804361ea)]
public sealed class TPageBlockAudio : IPageBlock
{
    public uint ConstructorId => 0x804361ea;
    public long AudioId { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/PageCaption" />
    ///</summary>
    public MyTelegram.Schema.IPageCaption Caption { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(AudioId);
        Caption.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        AudioId = br.ReadInt64();
        Caption = br.Deserialize<MyTelegram.Schema.IPageCaption>();
    }
}