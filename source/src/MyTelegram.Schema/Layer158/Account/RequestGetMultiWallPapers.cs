﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
///See <a href="https://core.telegram.org/method/account.getMultiWallPapers" />
///</summary>
[TlObject(0x65ad71dc)]
public sealed class RequestGetMultiWallPapers : IRequest<TVector<MyTelegram.Schema.IWallPaper>>
{
    public uint ConstructorId => 0x65ad71dc;
    public TVector<MyTelegram.Schema.IInputWallPaper> Wallpapers { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Wallpapers.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Wallpapers = br.Deserialize<TVector<MyTelegram.Schema.IInputWallPaper>>();
    }
}
