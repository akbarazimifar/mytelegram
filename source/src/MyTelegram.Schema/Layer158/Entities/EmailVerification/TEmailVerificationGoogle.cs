﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/emailVerificationGoogle" />
///</summary>
[TlObject(0xdb909ec2)]
public sealed class TEmailVerificationGoogle : IEmailVerification
{
    public uint ConstructorId => 0xdb909ec2;
    public string Token { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Token);
    }

    public void Deserialize(BinaryReader br)
    {
        Token = br.Deserialize<string>();
    }
}