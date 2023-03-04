﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/messageActionSecureValuesSentMe" />
///</summary>
[TlObject(0x1b287353)]
public sealed class TMessageActionSecureValuesSentMe : IMessageAction
{
    public uint ConstructorId => 0x1b287353;
    public TVector<MyTelegram.Schema.ISecureValue> Values { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/SecureCredentialsEncrypted" />
    ///</summary>
    public MyTelegram.Schema.ISecureCredentialsEncrypted Credentials { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Values.Serialize(bw);
        Credentials.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Values = br.Deserialize<TVector<MyTelegram.Schema.ISecureValue>>();
        Credentials = br.Deserialize<MyTelegram.Schema.ISecureCredentialsEncrypted>();
    }
}