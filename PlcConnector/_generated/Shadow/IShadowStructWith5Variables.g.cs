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
	public partial interface IShadowStructWith5Variables : Vortex.Connector.IVortexShadowObject
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

		System.String AttributeName
		{
			get;
		}

		Plc.PlainStructWith5Variables CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainStructWith5Variables source);
	}
}