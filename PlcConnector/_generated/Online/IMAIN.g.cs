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
	public partial interface IMAIN : Vortex.Connector.IVortexOnlineObject
	{
		IStructWith50Variables first
		{
			get;
		}

		IStructWith5Variables second
		{
			get;
		}

		IStructWith68Variables third
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt ShouldBe5
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt ShouldBe68
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt ShouldBe50
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainMAIN CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainMAIN source);
		void FlushOnlineToPlain(Plc.PlainMAIN source);
	}
}