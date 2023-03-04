﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.sendEncryptedFile" />
///</summary>
[TlObject(0x5559481d)]
public sealed class RequestSendEncryptedFile : IRequest<MyTelegram.Schema.Messages.ISentEncryptedMessage>
{
    public uint ConstructorId => 0x5559481d;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Silent { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputEncryptedChat" />
    ///</summary>
    public MyTelegram.Schema.IInputEncryptedChat Peer { get; set; }
    public long RandomId { get; set; }
    public byte[] Data { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputEncryptedFile" />
    ///</summary>
    public MyTelegram.Schema.IInputEncryptedFile File { get; set; }

    public void ComputeFlag()
    {
        if (Silent) { Flags[0] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        Peer.Serialize(bw);
        bw.Write(RandomId);
        bw.Serialize(Data);
        File.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Silent = true; }
        Peer = br.Deserialize<MyTelegram.Schema.IInputEncryptedChat>();
        RandomId = br.ReadInt64();
        Data = br.Deserialize<byte[]>();
        File = br.Deserialize<MyTelegram.Schema.IInputEncryptedFile>();
    }
}