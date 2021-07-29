using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowStructWith50Variables : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable1
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable2
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable3
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable4
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable5
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable6
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable7
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable8
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable9
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable10
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable11
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable12
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable13
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable14
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable15
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable16
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable17
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable18
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable19
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable20
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable21
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable22
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable23
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable24
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable25
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable26
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable27
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable28
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable29
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable30
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable31
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable32
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable33
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable34
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable35
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable36
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable37
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable38
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable39
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable40
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable41
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable42
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable43
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable44
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable45
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable46
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable47
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable48
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable49
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt Variable50
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainStructWith50Variables CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainStructWith50Variables source);
	}
}