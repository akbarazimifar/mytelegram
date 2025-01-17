﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
///See <a href="https://core.telegram.org/method/invokeWithMessagesRange" />
///</summary>
[TlObject(0x365275f2)]
public sealed class RequestInvokeWithMessagesRange : IRequest<IObject>
{
    public uint ConstructorId => 0x365275f2;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/MessageRange" />
    ///</summary>
    public MyTelegram.Schema.IMessageRange Range { get; set; }
    public IObject Query { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Range.Serialize(bw);
        Query.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Range = br.Deserialize<MyTelegram.Schema.IMessageRange>();
        Query = br.Deserialize<IObject>();
    }
}
