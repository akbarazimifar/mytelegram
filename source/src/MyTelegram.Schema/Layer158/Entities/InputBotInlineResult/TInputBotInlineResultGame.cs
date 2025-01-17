﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputBotInlineResultGame" />
///</summary>
[TlObject(0x4fa417f2)]
public sealed class TInputBotInlineResultGame : IInputBotInlineResult
{
    public uint ConstructorId => 0x4fa417f2;
    public string Id { get; set; }
    public string ShortName { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputBotInlineMessage" />
    ///</summary>
    public MyTelegram.Schema.IInputBotInlineMessage SendMessage { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Id);
        bw.Serialize(ShortName);
        SendMessage.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Id = br.Deserialize<string>();
        ShortName = br.Deserialize<string>();
        SendMessage = br.Deserialize<MyTelegram.Schema.IInputBotInlineMessage>();
    }
}