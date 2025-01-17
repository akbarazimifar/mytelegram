﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/updateUserName" />
///</summary>
[TlObject(0xa7848924)]
public sealed class TUpdateUserName : IUpdate
{
    public uint ConstructorId => 0xa7848924;
    public long UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public TVector<MyTelegram.Schema.IUsername> Usernames { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(UserId);
        bw.Serialize(FirstName);
        bw.Serialize(LastName);
        Usernames.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        UserId = br.ReadInt64();
        FirstName = br.Deserialize<string>();
        LastName = br.Deserialize<string>();
        Usernames = br.Deserialize<TVector<MyTelegram.Schema.IUsername>>();
    }
}