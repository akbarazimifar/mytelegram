﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/securePasswordKdfAlgoPBKDF2HMACSHA512iter100000" />
///</summary>
[TlObject(0xbbf2dda0)]
public sealed class TSecurePasswordKdfAlgoPBKDF2HMACSHA512iter100000 : ISecurePasswordKdfAlgo
{
    public uint ConstructorId => 0xbbf2dda0;
    public byte[] Salt { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Salt);
    }

    public void Deserialize(BinaryReader br)
    {
        Salt = br.Deserialize<byte[]>();
    }
}