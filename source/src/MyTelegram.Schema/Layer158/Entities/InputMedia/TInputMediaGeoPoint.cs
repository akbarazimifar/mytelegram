﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputMediaGeoPoint" />
///</summary>
[TlObject(0xf9c44144)]
public sealed class TInputMediaGeoPoint : IInputMedia
{
    public uint ConstructorId => 0xf9c44144;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputGeoPoint" />
    ///</summary>
    public MyTelegram.Schema.IInputGeoPoint GeoPoint { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        GeoPoint.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        GeoPoint = br.Deserialize<MyTelegram.Schema.IInputGeoPoint>();
    }
}