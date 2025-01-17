﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Auth;

///<summary>
///See <a href="https://core.telegram.org/method/auth.dropTempAuthKeys" />
///</summary>
[TlObject(0x8e48a188)]
public sealed class RequestDropTempAuthKeys : IRequest<IBool>
{
    public uint ConstructorId => 0x8e48a188;
    public TVector<long> ExceptAuthKeys { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        ExceptAuthKeys.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        ExceptAuthKeys = br.Deserialize<TVector<long>>();
    }
}
