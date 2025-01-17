﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Channels;

///<summary>
///See <a href="https://core.telegram.org/method/channels.getAdminLog" />
///</summary>
[TlObject(0x33ddf480)]
public sealed class RequestGetAdminLog : IRequest<MyTelegram.Schema.Channels.IAdminLogResults>
{
    public uint ConstructorId => 0x33ddf480;
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputChannel" />
    ///</summary>
    public MyTelegram.Schema.IInputChannel Channel { get; set; }
    public string Q { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/ChannelAdminLogEventsFilter" />
    ///</summary>
    public MyTelegram.Schema.IChannelAdminLogEventsFilter? EventsFilter { get; set; }
    public TVector<MyTelegram.Schema.IInputUser>? Admins { get; set; }
    public long MaxId { get; set; }
    public long MinId { get; set; }
    public int Limit { get; set; }

    public void ComputeFlag()
    {
        if (EventsFilter != null) { Flags[0] = true; }
        if (Admins?.Count > 0) { Flags[1] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        Channel.Serialize(bw);
        bw.Serialize(Q);
        if (Flags[0]) { EventsFilter.Serialize(bw); }
        if (Flags[1]) { Admins.Serialize(bw); }
        bw.Write(MaxId);
        bw.Write(MinId);
        bw.Write(Limit);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        Channel = br.Deserialize<MyTelegram.Schema.IInputChannel>();
        Q = br.Deserialize<string>();
        if (Flags[0]) { EventsFilter = br.Deserialize<MyTelegram.Schema.IChannelAdminLogEventsFilter>(); }
        if (Flags[1]) { Admins = br.Deserialize<TVector<MyTelegram.Schema.IInputUser>>(); }
        MaxId = br.ReadInt64();
        MinId = br.ReadInt64();
        Limit = br.ReadInt32();
    }
}
