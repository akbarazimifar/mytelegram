﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/botMenuButton" />
///</summary>
[TlObject(0xc7b57ce6)]
public sealed class TBotMenuButton : IBotMenuButton
{
    public uint ConstructorId => 0xc7b57ce6;
    public string Text { get; set; }
    public string Url { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Text);
        bw.Serialize(Url);
    }

    public void Deserialize(BinaryReader br)
    {
        Text = br.Deserialize<string>();
        Url = br.Deserialize<string>();
    }
}