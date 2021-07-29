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
	public partial interface IStructWith50Variables : Vortex.Connector.IVortexOnlineObject
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

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable6
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable7
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable8
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable9
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable10
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable11
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable12
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable13
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable14
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable15
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable16
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable17
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable18
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable19
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable20
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable21
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable22
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable23
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable24
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable25
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable26
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable27
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable28
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable29
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable30
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable31
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable32
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable33
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable34
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable35
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable36
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable37
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable38
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable39
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable40
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable41
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable42
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable43
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable44
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable45
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable46
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable47
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable48
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable49
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt Variable50
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainStructWith50Variables CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainStructWith50Variables source);
		void FlushOnlineToPlain(Plc.PlainStructWith50Variables source);
	}
}