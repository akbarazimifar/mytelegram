﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/secureValueErrorData" />
///</summary>
[TlObject(0xe8a40bd9)]
public sealed class TSecureValueErrorData : ISecureValueError
{
    public uint ConstructorId => 0xe8a40bd9;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/SecureValueType" />
    ///</summary>
    public MyTelegram.Schema.ISecureValueType Type { get; set; }
    public byte[] DataHash { get; set; }
    public string Field { get; set; }
    public string Text { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Type.Serialize(bw);
        bw.Serialize(DataHash);
        bw.Serialize(Field);
        bw.Serialize(Text);
    }

    public void Deserialize(BinaryReader br)
    {
        Type = br.Deserialize<MyTelegram.Schema.ISecureValueType>();
        DataHash = br.Deserialize<byte[]>();
        Field = br.Deserialize<string>();
        Text = br.Deserialize<string>();
    }
}