﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/pageListOrderedItemText" />
///</summary>
[TlObject(0x5e068047)]
public sealed class TPageListOrderedItemText : IPageListOrderedItem
{
    public uint ConstructorId => 0x5e068047;
    public string Num { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/RichText" />
    ///</summary>
    public MyTelegram.Schema.IRichText Text { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Num);
        Text.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Num = br.Deserialize<string>();
        Text = br.Deserialize<MyTelegram.Schema.IRichText>();
    }
}