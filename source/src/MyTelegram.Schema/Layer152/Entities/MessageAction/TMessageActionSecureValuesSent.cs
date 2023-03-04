﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/messageActionSecureValuesSent" />
///</summary>
[TlObject(0xd95c6154)]
public sealed class TMessageActionSecureValuesSent : IMessageAction
{
    public uint ConstructorId => 0xd95c6154;
    public TVector<MyTelegram.Schema.ISecureValueType> Types { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Types.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Types = br.Deserialize<TVector<MyTelegram.Schema.ISecureValueType>>();
    }
}