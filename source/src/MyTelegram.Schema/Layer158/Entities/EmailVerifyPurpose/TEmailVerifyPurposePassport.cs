﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/emailVerifyPurposePassport" />
///</summary>
[TlObject(0xbbf51685)]
public sealed class TEmailVerifyPurposePassport : IEmailVerifyPurpose
{
    public uint ConstructorId => 0xbbf51685;


    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);

    }

    public void Deserialize(BinaryReader br)
    {

    }
}