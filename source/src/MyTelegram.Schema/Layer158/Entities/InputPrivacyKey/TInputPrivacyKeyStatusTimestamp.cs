﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputPrivacyKeyStatusTimestamp" />
///</summary>
[TlObject(0x4f96cb18)]
public sealed class TInputPrivacyKeyStatusTimestamp : IInputPrivacyKey
{
    public uint ConstructorId => 0x4f96cb18;


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