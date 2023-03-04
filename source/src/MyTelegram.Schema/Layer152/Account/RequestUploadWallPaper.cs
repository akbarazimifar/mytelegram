﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
///See <a href="https://core.telegram.org/method/account.uploadWallPaper" />
///</summary>
[TlObject(0xdd853661)]
public sealed class RequestUploadWallPaper : IRequest<MyTelegram.Schema.IWallPaper>
{
    public uint ConstructorId => 0xdd853661;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputFile" />
    ///</summary>
    public MyTelegram.Schema.IInputFile File { get; set; }
    public string MimeType { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/WallPaperSettings" />
    ///</summary>
    public MyTelegram.Schema.IWallPaperSettings Settings { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        File.Serialize(bw);
        bw.Serialize(MimeType);
        Settings.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        File = br.Deserialize<MyTelegram.Schema.IInputFile>();
        MimeType = br.Deserialize<string>();
        Settings = br.Deserialize<MyTelegram.Schema.IWallPaperSettings>();
    }
}