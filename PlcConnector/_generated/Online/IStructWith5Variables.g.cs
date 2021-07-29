using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IStructWith5Variables : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable1
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable2
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable3
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable4
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable5
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainStructWith5Variables CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainStructWith5Variables source);
		void FlushOnlineToPlain(Plc.PlainStructWith5Variables source);
	}
}