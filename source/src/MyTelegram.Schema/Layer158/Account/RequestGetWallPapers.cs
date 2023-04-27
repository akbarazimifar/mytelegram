﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
///See <a href="https://core.telegram.org/method/account.getWallPapers" />
///</summary>
[TlObject(0x7967d36)]
public sealed class RequestGetWallPapers : IRequest<MyTelegram.Schema.Account.IWallPapers>
{
    public uint ConstructorId => 0x7967d36;
    public long Hash { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Hash);
    }

    public void Deserialize(BinaryReader br)
    {
        Hash = br.ReadInt64();
    }
}