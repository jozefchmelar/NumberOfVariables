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
	public partial interface IShadowMAIN : Vortex.Connector.IVortexShadowObject
	{
		IShadowStructWith50Variables first
		{
			get;
		}

		IShadowStructWith5Variables second
		{
			get;
		}

		IShadowStructWith68Variables third
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt ShouldBe5
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt ShouldBe68
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt ShouldBe50
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainMAIN CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainMAIN source);
	}
}