﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Contacts;


///<summary>
///See <a href="https://core.telegram.org/constructor/contacts.importedContacts" />
///</summary>
[TlObject(0x77d01c3b)]
public sealed class TImportedContacts : IImportedContacts
{
    public uint ConstructorId => 0x77d01c3b;
    public TVector<MyTelegram.Schema.IImportedContact> Imported { get; set; }
    public TVector<MyTelegram.Schema.IPopularContact> PopularInvites { get; set; }
    public TVector<long> RetryContacts { get; set; }
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Imported.Serialize(bw);
        PopularInvites.Serialize(bw);
        RetryContacts.Serialize(bw);
        Users.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Imported = br.Deserialize<TVector<MyTelegram.Schema.IImportedContact>>();
        PopularInvites = br.Deserialize<TVector<MyTelegram.Schema.IPopularContact>>();
        RetryContacts = br.Deserialize<TVector<long>>();
        Users = br.Deserialize<TVector<MyTelegram.Schema.IUser>>();
    }
}