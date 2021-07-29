using System;
using Vortex.Adapters.Connector.Tc3.Adapter;

namespace Plc
{
    public static class Entry
    {
        public static Plc.PlcTwinController Plc { get; }= new Plc.PlcTwinController(Tc3ConnectorAdapter.Create(null, 851, true));
    }
}   
