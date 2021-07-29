using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "StructWith50Variables", "Plc", TypeComplexityEnum.Complex)]
	public partial class StructWith50Variables : Vortex.Connector.IVortexObject, IStructWith50Variables, IShadowStructWith50Variables, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		public string Symbol
		{
			get;
			protected set;
		}

		public string HumanReadable
		{
			get
			{
				return PlcTwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		Vortex.Connector.ValueTypes.OnlinerInt _Variable1;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable1
		{
			get
			{
				return _Variable1;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable1
		{
			get
			{
				return Variable1;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable1
		{
			get
			{
				return Variable1;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable2;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable2
		{
			get
			{
				return _Variable2;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable2
		{
			get
			{
				return Variable2;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable2
		{
			get
			{
				return Variable2;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable3;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable3
		{
			get
			{
				return _Variable3;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable3
		{
			get
			{
				return Variable3;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable3
		{
			get
			{
				return Variable3;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable4;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable4
		{
			get
			{
				return _Variable4;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable4
		{
			get
			{
				return Variable4;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable4
		{
			get
			{
				return Variable4;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable5;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable5
		{
			get
			{
				return _Variable5;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable5
		{
			get
			{
				return Variable5;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable5
		{
			get
			{
				return Variable5;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable6;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable6
		{
			get
			{
				return _Variable6;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable6
		{
			get
			{
				return Variable6;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable6
		{
			get
			{
				return Variable6;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable7;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable7
		{
			get
			{
				return _Variable7;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable7
		{
			get
			{
				return Variable7;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable7
		{
			get
			{
				return Variable7;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable8;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable8
		{
			get
			{
				return _Variable8;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable8
		{
			get
			{
				return Variable8;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable8
		{
			get
			{
				return Variable8;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable9;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable9
		{
			get
			{
				return _Variable9;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable9
		{
			get
			{
				return Variable9;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable9
		{
			get
			{
				return Variable9;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable10;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable10
		{
			get
			{
				return _Variable10;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable10
		{
			get
			{
				return Variable10;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable10
		{
			get
			{
				return Variable10;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable11;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable11
		{
			get
			{
				return _Variable11;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable11
		{
			get
			{
				return Variable11;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable11
		{
			get
			{
				return Variable11;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable12;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable12
		{
			get
			{
				return _Variable12;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable12
		{
			get
			{
				return Variable12;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable12
		{
			get
			{
				return Variable12;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable13;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable13
		{
			get
			{
				return _Variable13;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable13
		{
			get
			{
				return Variable13;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable13
		{
			get
			{
				return Variable13;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable14;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable14
		{
			get
			{
				return _Variable14;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable14
		{
			get
			{
				return Variable14;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable14
		{
			get
			{
				return Variable14;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable15;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable15
		{
			get
			{
				return _Variable15;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable15
		{
			get
			{
				return Variable15;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable15
		{
			get
			{
				return Variable15;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable16;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable16
		{
			get
			{
				return _Variable16;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable16
		{
			get
			{
				return Variable16;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable16
		{
			get
			{
				return Variable16;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable17;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable17
		{
			get
			{
				return _Variable17;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable17
		{
			get
			{
				return Variable17;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable17
		{
			get
			{
				return Variable17;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable18;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable18
		{
			get
			{
				return _Variable18;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable18
		{
			get
			{
				return Variable18;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable18
		{
			get
			{
				return Variable18;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable19;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable19
		{
			get
			{
				return _Variable19;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable19
		{
			get
			{
				return Variable19;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable19
		{
			get
			{
				return Variable19;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable20;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable20
		{
			get
			{
				return _Variable20;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable20
		{
			get
			{
				return Variable20;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable20
		{
			get
			{
				return Variable20;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable21;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable21
		{
			get
			{
				return _Variable21;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable21
		{
			get
			{
				return Variable21;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable21
		{
			get
			{
				return Variable21;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable22;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable22
		{
			get
			{
				return _Variable22;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable22
		{
			get
			{
				return Variable22;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable22
		{
			get
			{
				return Variable22;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable23;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable23
		{
			get
			{
				return _Variable23;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable23
		{
			get
			{
				return Variable23;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable23
		{
			get
			{
				return Variable23;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable24;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable24
		{
			get
			{
				return _Variable24;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable24
		{
			get
			{
				return Variable24;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable24
		{
			get
			{
				return Variable24;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable25;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable25
		{
			get
			{
				return _Variable25;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable25
		{
			get
			{
				return Variable25;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable25
		{
			get
			{
				return Variable25;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable26;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable26
		{
			get
			{
				return _Variable26;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable26
		{
			get
			{
				return Variable26;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable26
		{
			get
			{
				return Variable26;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable27;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable27
		{
			get
			{
				return _Variable27;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable27
		{
			get
			{
				return Variable27;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable27
		{
			get
			{
				return Variable27;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable28;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable28
		{
			get
			{
				return _Variable28;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable28
		{
			get
			{
				return Variable28;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable28
		{
			get
			{
				return Variable28;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable29;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable29
		{
			get
			{
				return _Variable29;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable29
		{
			get
			{
				return Variable29;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable29
		{
			get
			{
				return Variable29;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable30;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable30
		{
			get
			{
				return _Variable30;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable30
		{
			get
			{
				return Variable30;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable30
		{
			get
			{
				return Variable30;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable31;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable31
		{
			get
			{
				return _Variable31;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable31
		{
			get
			{
				return Variable31;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable31
		{
			get
			{
				return Variable31;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable32;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable32
		{
			get
			{
				return _Variable32;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable32
		{
			get
			{
				return Variable32;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable32
		{
			get
			{
				return Variable32;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable33;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable33
		{
			get
			{
				return _Variable33;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable33
		{
			get
			{
				return Variable33;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable33
		{
			get
			{
				return Variable33;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable34;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable34
		{
			get
			{
				return _Variable34;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable34
		{
			get
			{
				return Variable34;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable34
		{
			get
			{
				return Variable34;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable35;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable35
		{
			get
			{
				return _Variable35;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable35
		{
			get
			{
				return Variable35;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable35
		{
			get
			{
				return Variable35;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable36;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable36
		{
			get
			{
				return _Variable36;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable36
		{
			get
			{
				return Variable36;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable36
		{
			get
			{
				return Variable36;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable37;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable37
		{
			get
			{
				return _Variable37;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable37
		{
			get
			{
				return Variable37;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable37
		{
			get
			{
				return Variable37;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable38;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable38
		{
			get
			{
				return _Variable38;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable38
		{
			get
			{
				return Variable38;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable38
		{
			get
			{
				return Variable38;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable39;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable39
		{
			get
			{
				return _Variable39;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable39
		{
			get
			{
				return Variable39;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable39
		{
			get
			{
				return Variable39;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable40;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable40
		{
			get
			{
				return _Variable40;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable40
		{
			get
			{
				return Variable40;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable40
		{
			get
			{
				return Variable40;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable41;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable41
		{
			get
			{
				return _Variable41;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable41
		{
			get
			{
				return Variable41;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable41
		{
			get
			{
				return Variable41;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable42;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable42
		{
			get
			{
				return _Variable42;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable42
		{
			get
			{
				return Variable42;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable42
		{
			get
			{
				return Variable42;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable43;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable43
		{
			get
			{
				return _Variable43;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable43
		{
			get
			{
				return Variable43;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable43
		{
			get
			{
				return Variable43;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable44;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable44
		{
			get
			{
				return _Variable44;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable44
		{
			get
			{
				return Variable44;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable44
		{
			get
			{
				return Variable44;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable45;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable45
		{
			get
			{
				return _Variable45;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable45
		{
			get
			{
				return Variable45;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable45
		{
			get
			{
				return Variable45;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable46;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable46
		{
			get
			{
				return _Variable46;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable46
		{
			get
			{
				return Variable46;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable46
		{
			get
			{
				return Variable46;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable47;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable47
		{
			get
			{
				return _Variable47;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable47
		{
			get
			{
				return Variable47;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable47
		{
			get
			{
				return Variable47;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable48;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable48
		{
			get
			{
				return _Variable48;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable48
		{
			get
			{
				return Variable48;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable48
		{
			get
			{
				return Variable48;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable49;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable49
		{
			get
			{
				return _Variable49;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable49
		{
			get
			{
				return Variable49;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable49
		{
			get
			{
				return Variable49;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Variable50;
		public Vortex.Connector.ValueTypes.OnlinerInt Variable50
		{
			get
			{
				return _Variable50;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith50Variables.Variable50
		{
			get
			{
				return Variable50;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith50Variables.Variable50
		{
			get
			{
				return Variable50;
			}
		}

		public void LazyOnlineToShadow()
		{
			Variable1.Shadow = Variable1.LastValue;
			Variable2.Shadow = Variable2.LastValue;
			Variable3.Shadow = Variable3.LastValue;
			Variable4.Shadow = Variable4.LastValue;
			Variable5.Shadow = Variable5.LastValue;
			Variable6.Shadow = Variable6.LastValue;
			Variable7.Shadow = Variable7.LastValue;
			Variable8.Shadow = Variable8.LastValue;
			Variable9.Shadow = Variable9.LastValue;
			Variable10.Shadow = Variable10.LastValue;
			Variable11.Shadow = Variable11.LastValue;
			Variable12.Shadow = Variable12.LastValue;
			Variable13.Shadow = Variable13.LastValue;
			Variable14.Shadow = Variable14.LastValue;
			Variable15.Shadow = Variable15.LastValue;
			Variable16.Shadow = Variable16.LastValue;
			Variable17.Shadow = Variable17.LastValue;
			Variable18.Shadow = Variable18.LastValue;
			Variable19.Shadow = Variable19.LastValue;
			Variable20.Shadow = Variable20.LastValue;
			Variable21.Shadow = Variable21.LastValue;
			Variable22.Shadow = Variable22.LastValue;
			Variable23.Shadow = Variable23.LastValue;
			Variable24.Shadow = Variable24.LastValue;
			Variable25.Shadow = Variable25.LastValue;
			Variable26.Shadow = Variable26.LastValue;
			Variable27.Shadow = Variable27.LastValue;
			Variable28.Shadow = Variable28.LastValue;
			Variable29.Shadow = Variable29.LastValue;
			Variable30.Shadow = Variable30.LastValue;
			Variable31.Shadow = Variable31.LastValue;
			Variable32.Shadow = Variable32.LastValue;
			Variable33.Shadow = Variable33.LastValue;
			Variable34.Shadow = Variable34.LastValue;
			Variable35.Shadow = Variable35.LastValue;
			Variable36.Shadow = Variable36.LastValue;
			Variable37.Shadow = Variable37.LastValue;
			Variable38.Shadow = Variable38.LastValue;
			Variable39.Shadow = Variable39.LastValue;
			Variable40.Shadow = Variable40.LastValue;
			Variable41.Shadow = Variable41.LastValue;
			Variable42.Shadow = Variable42.LastValue;
			Variable43.Shadow = Variable43.LastValue;
			Variable44.Shadow = Variable44.LastValue;
			Variable45.Shadow = Variable45.LastValue;
			Variable46.Shadow = Variable46.LastValue;
			Variable47.Shadow = Variable47.LastValue;
			Variable48.Shadow = Variable48.LastValue;
			Variable49.Shadow = Variable49.LastValue;
			Variable50.Shadow = Variable50.LastValue;
		}

		public void LazyShadowToOnline()
		{
			Variable1.Cyclic = Variable1.Shadow;
			Variable2.Cyclic = Variable2.Shadow;
			Variable3.Cyclic = Variable3.Shadow;
			Variable4.Cyclic = Variable4.Shadow;
			Variable5.Cyclic = Variable5.Shadow;
			Variable6.Cyclic = Variable6.Shadow;
			Variable7.Cyclic = Variable7.Shadow;
			Variable8.Cyclic = Variable8.Shadow;
			Variable9.Cyclic = Variable9.Shadow;
			Variable10.Cyclic = Variable10.Shadow;
			Variable11.Cyclic = Variable11.Shadow;
			Variable12.Cyclic = Variable12.Shadow;
			Variable13.Cyclic = Variable13.Shadow;
			Variable14.Cyclic = Variable14.Shadow;
			Variable15.Cyclic = Variable15.Shadow;
			Variable16.Cyclic = Variable16.Shadow;
			Variable17.Cyclic = Variable17.Shadow;
			Variable18.Cyclic = Variable18.Shadow;
			Variable19.Cyclic = Variable19.Shadow;
			Variable20.Cyclic = Variable20.Shadow;
			Variable21.Cyclic = Variable21.Shadow;
			Variable22.Cyclic = Variable22.Shadow;
			Variable23.Cyclic = Variable23.Shadow;
			Variable24.Cyclic = Variable24.Shadow;
			Variable25.Cyclic = Variable25.Shadow;
			Variable26.Cyclic = Variable26.Shadow;
			Variable27.Cyclic = Variable27.Shadow;
			Variable28.Cyclic = Variable28.Shadow;
			Variable29.Cyclic = Variable29.Shadow;
			Variable30.Cyclic = Variable30.Shadow;
			Variable31.Cyclic = Variable31.Shadow;
			Variable32.Cyclic = Variable32.Shadow;
			Variable33.Cyclic = Variable33.Shadow;
			Variable34.Cyclic = Variable34.Shadow;
			Variable35.Cyclic = Variable35.Shadow;
			Variable36.Cyclic = Variable36.Shadow;
			Variable37.Cyclic = Variable37.Shadow;
			Variable38.Cyclic = Variable38.Shadow;
			Variable39.Cyclic = Variable39.Shadow;
			Variable40.Cyclic = Variable40.Shadow;
			Variable41.Cyclic = Variable41.Shadow;
			Variable42.Cyclic = Variable42.Shadow;
			Variable43.Cyclic = Variable43.Shadow;
			Variable44.Cyclic = Variable44.Shadow;
			Variable45.Cyclic = Variable45.Shadow;
			Variable46.Cyclic = Variable46.Shadow;
			Variable47.Cyclic = Variable47.Shadow;
			Variable48.Cyclic = Variable48.Shadow;
			Variable49.Cyclic = Variable49.Shadow;
			Variable50.Cyclic = Variable50.Shadow;
		}

		public PlainStructWith50Variables CreatePlainerType()
		{
			var cloned = new PlainStructWith50Variables();
			return cloned;
		}

		protected PlainStructWith50Variables CreatePlainerType(PlainStructWith50Variables cloned)
		{
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		private System.Collections.Generic.List<Vortex.Connector.IVortexObject> @Children
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexObject> @GetChildren()
		{
			return this.@Children;
		}

		public void AddChild(Vortex.Connector.IVortexObject vortexObject)
		{
			this.@Children.Add(vortexObject);
		}

		private System.Collections.Generic.List<Vortex.Connector.IVortexElement> Kids
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexElement> GetKids()
		{
			return this.Kids;
		}

		public void AddKid(Vortex.Connector.IVortexElement vortexElement)
		{
			this.Kids.Add(vortexElement);
		}

		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		protected Vortex.Connector.IVortexObject @Parent
		{
			get;
			set;
		}

		public Vortex.Connector.IVortexObject GetParent()
		{
			return this.@Parent;
		}

		private System.Collections.Generic.List<Vortex.Connector.IValueTag> @ValueTags
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IValueTag> GetValueTags()
		{
			return this.@ValueTags;
		}

		public void AddValueTag(Vortex.Connector.IValueTag valueTag)
		{
			this.@ValueTags.Add(valueTag);
		}

		protected Vortex.Connector.IConnector @Connector
		{
			get;
			set;
		}

		public Vortex.Connector.IConnector GetConnector()
		{
			return this.@Connector;
		}

		public void FlushPlainToOnline(Plc.PlainStructWith50Variables source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainStructWith50Variables source)
		{
			source.CopyPlainToShadow(this);
		}

		public void FlushShadowToOnline()
		{
			this.LazyShadowToOnline();
			this.Write();
		}

		public void FlushOnlineToShadow()
		{
			this.Read();
			this.LazyOnlineToShadow();
		}

		public void FlushOnlineToPlain(Plc.PlainStructWith50Variables source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		protected System.String @SymbolTail
		{
			get;
			set;
		}

		public System.String GetSymbolTail()
		{
			return this.SymbolTail;
		}

		public System.String AttributeName
		{
			get
			{
				return PlcTwinController.Translator.Translate(_AttributeName).Interpolate(this);
			}

			set
			{
				_AttributeName = value;
			}
		}

		private System.String _AttributeName
		{
			get;
			set;
		}

		public StructWith50Variables(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			this.Kids = new System.Collections.Generic.List<Vortex.Connector.IVortexElement>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Variable1 = @Connector.Online.Adapter.CreateINT(this, "", "Variable1");
			_Variable2 = @Connector.Online.Adapter.CreateINT(this, "", "Variable2");
			_Variable3 = @Connector.Online.Adapter.CreateINT(this, "", "Variable3");
			_Variable4 = @Connector.Online.Adapter.CreateINT(this, "", "Variable4");
			_Variable5 = @Connector.Online.Adapter.CreateINT(this, "", "Variable5");
			_Variable6 = @Connector.Online.Adapter.CreateINT(this, "", "Variable6");
			_Variable7 = @Connector.Online.Adapter.CreateINT(this, "", "Variable7");
			_Variable8 = @Connector.Online.Adapter.CreateINT(this, "", "Variable8");
			_Variable9 = @Connector.Online.Adapter.CreateINT(this, "", "Variable9");
			_Variable10 = @Connector.Online.Adapter.CreateINT(this, "", "Variable10");
			_Variable11 = @Connector.Online.Adapter.CreateINT(this, "", "Variable11");
			_Variable12 = @Connector.Online.Adapter.CreateINT(this, "", "Variable12");
			_Variable13 = @Connector.Online.Adapter.CreateINT(this, "", "Variable13");
			_Variable14 = @Connector.Online.Adapter.CreateINT(this, "", "Variable14");
			_Variable15 = @Connector.Online.Adapter.CreateINT(this, "", "Variable15");
			_Variable16 = @Connector.Online.Adapter.CreateINT(this, "", "Variable16");
			_Variable17 = @Connector.Online.Adapter.CreateINT(this, "", "Variable17");
			_Variable18 = @Connector.Online.Adapter.CreateINT(this, "", "Variable18");
			_Variable19 = @Connector.Online.Adapter.CreateINT(this, "", "Variable19");
			_Variable20 = @Connector.Online.Adapter.CreateINT(this, "", "Variable20");
			_Variable21 = @Connector.Online.Adapter.CreateINT(this, "", "Variable21");
			_Variable22 = @Connector.Online.Adapter.CreateINT(this, "", "Variable22");
			_Variable23 = @Connector.Online.Adapter.CreateINT(this, "", "Variable23");
			_Variable24 = @Connector.Online.Adapter.CreateINT(this, "", "Variable24");
			_Variable25 = @Connector.Online.Adapter.CreateINT(this, "", "Variable25");
			_Variable26 = @Connector.Online.Adapter.CreateINT(this, "", "Variable26");
			_Variable27 = @Connector.Online.Adapter.CreateINT(this, "", "Variable27");
			_Variable28 = @Connector.Online.Adapter.CreateINT(this, "", "Variable28");
			_Variable29 = @Connector.Online.Adapter.CreateINT(this, "", "Variable29");
			_Variable30 = @Connector.Online.Adapter.CreateINT(this, "", "Variable30");
			_Variable31 = @Connector.Online.Adapter.CreateINT(this, "", "Variable31");
			_Variable32 = @Connector.Online.Adapter.CreateINT(this, "", "Variable32");
			_Variable33 = @Connector.Online.Adapter.CreateINT(this, "", "Variable33");
			_Variable34 = @Connector.Online.Adapter.CreateINT(this, "", "Variable34");
			_Variable35 = @Connector.Online.Adapter.CreateINT(this, "", "Variable35");
			_Variable36 = @Connector.Online.Adapter.CreateINT(this, "", "Variable36");
			_Variable37 = @Connector.Online.Adapter.CreateINT(this, "", "Variable37");
			_Variable38 = @Connector.Online.Adapter.CreateINT(this, "", "Variable38");
			_Variable39 = @Connector.Online.Adapter.CreateINT(this, "", "Variable39");
			_Variable40 = @Connector.Online.Adapter.CreateINT(this, "", "Variable40");
			_Variable41 = @Connector.Online.Adapter.CreateINT(this, "", "Variable41");
			_Variable42 = @Connector.Online.Adapter.CreateINT(this, "", "Variable42");
			_Variable43 = @Connector.Online.Adapter.CreateINT(this, "", "Variable43");
			_Variable44 = @Connector.Online.Adapter.CreateINT(this, "", "Variable44");
			_Variable45 = @Connector.Online.Adapter.CreateINT(this, "", "Variable45");
			_Variable46 = @Connector.Online.Adapter.CreateINT(this, "", "Variable46");
			_Variable47 = @Connector.Online.Adapter.CreateINT(this, "", "Variable47");
			_Variable48 = @Connector.Online.Adapter.CreateINT(this, "", "Variable48");
			_Variable49 = @Connector.Online.Adapter.CreateINT(this, "", "Variable49");
			_Variable50 = @Connector.Online.Adapter.CreateINT(this, "", "Variable50");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public StructWith50Variables()
		{
			PexPreConstructorParameterless();
			_Variable1 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable2 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable3 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable4 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable5 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable6 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable7 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable8 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable9 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable10 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable11 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable12 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable13 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable14 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable15 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable16 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable17 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable18 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable19 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable20 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable21 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable22 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable23 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable24 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable25 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable26 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable27 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable28 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable29 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable30 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable31 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable32 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable33 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable34 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable35 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable36 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable37 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable38 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable39 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable40 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable41 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable42 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable43 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable44 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable45 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable46 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable47 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable48 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable49 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable50 = Vortex.Connector.IConnectorFactory.CreateINT();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainStructWith50Variables
	{
		public void CopyPlainToCyclic(Plc.StructWith50Variables target)
		{
			target.Variable1.Cyclic = Variable1;
			target.Variable2.Cyclic = Variable2;
			target.Variable3.Cyclic = Variable3;
			target.Variable4.Cyclic = Variable4;
			target.Variable5.Cyclic = Variable5;
			target.Variable6.Cyclic = Variable6;
			target.Variable7.Cyclic = Variable7;
			target.Variable8.Cyclic = Variable8;
			target.Variable9.Cyclic = Variable9;
			target.Variable10.Cyclic = Variable10;
			target.Variable11.Cyclic = Variable11;
			target.Variable12.Cyclic = Variable12;
			target.Variable13.Cyclic = Variable13;
			target.Variable14.Cyclic = Variable14;
			target.Variable15.Cyclic = Variable15;
			target.Variable16.Cyclic = Variable16;
			target.Variable17.Cyclic = Variable17;
			target.Variable18.Cyclic = Variable18;
			target.Variable19.Cyclic = Variable19;
			target.Variable20.Cyclic = Variable20;
			target.Variable21.Cyclic = Variable21;
			target.Variable22.Cyclic = Variable22;
			target.Variable23.Cyclic = Variable23;
			target.Variable24.Cyclic = Variable24;
			target.Variable25.Cyclic = Variable25;
			target.Variable26.Cyclic = Variable26;
			target.Variable27.Cyclic = Variable27;
			target.Variable28.Cyclic = Variable28;
			target.Variable29.Cyclic = Variable29;
			target.Variable30.Cyclic = Variable30;
			target.Variable31.Cyclic = Variable31;
			target.Variable32.Cyclic = Variable32;
			target.Variable33.Cyclic = Variable33;
			target.Variable34.Cyclic = Variable34;
			target.Variable35.Cyclic = Variable35;
			target.Variable36.Cyclic = Variable36;
			target.Variable37.Cyclic = Variable37;
			target.Variable38.Cyclic = Variable38;
			target.Variable39.Cyclic = Variable39;
			target.Variable40.Cyclic = Variable40;
			target.Variable41.Cyclic = Variable41;
			target.Variable42.Cyclic = Variable42;
			target.Variable43.Cyclic = Variable43;
			target.Variable44.Cyclic = Variable44;
			target.Variable45.Cyclic = Variable45;
			target.Variable46.Cyclic = Variable46;
			target.Variable47.Cyclic = Variable47;
			target.Variable48.Cyclic = Variable48;
			target.Variable49.Cyclic = Variable49;
			target.Variable50.Cyclic = Variable50;
		}

		public void CopyPlainToCyclic(Plc.IStructWith50Variables target)
		{
			this.CopyPlainToCyclic((Plc.StructWith50Variables)target);
		}

		public void CopyPlainToShadow(Plc.StructWith50Variables target)
		{
			target.Variable1.Shadow = Variable1;
			target.Variable2.Shadow = Variable2;
			target.Variable3.Shadow = Variable3;
			target.Variable4.Shadow = Variable4;
			target.Variable5.Shadow = Variable5;
			target.Variable6.Shadow = Variable6;
			target.Variable7.Shadow = Variable7;
			target.Variable8.Shadow = Variable8;
			target.Variable9.Shadow = Variable9;
			target.Variable10.Shadow = Variable10;
			target.Variable11.Shadow = Variable11;
			target.Variable12.Shadow = Variable12;
			target.Variable13.Shadow = Variable13;
			target.Variable14.Shadow = Variable14;
			target.Variable15.Shadow = Variable15;
			target.Variable16.Shadow = Variable16;
			target.Variable17.Shadow = Variable17;
			target.Variable18.Shadow = Variable18;
			target.Variable19.Shadow = Variable19;
			target.Variable20.Shadow = Variable20;
			target.Variable21.Shadow = Variable21;
			target.Variable22.Shadow = Variable22;
			target.Variable23.Shadow = Variable23;
			target.Variable24.Shadow = Variable24;
			target.Variable25.Shadow = Variable25;
			target.Variable26.Shadow = Variable26;
			target.Variable27.Shadow = Variable27;
			target.Variable28.Shadow = Variable28;
			target.Variable29.Shadow = Variable29;
			target.Variable30.Shadow = Variable30;
			target.Variable31.Shadow = Variable31;
			target.Variable32.Shadow = Variable32;
			target.Variable33.Shadow = Variable33;
			target.Variable34.Shadow = Variable34;
			target.Variable35.Shadow = Variable35;
			target.Variable36.Shadow = Variable36;
			target.Variable37.Shadow = Variable37;
			target.Variable38.Shadow = Variable38;
			target.Variable39.Shadow = Variable39;
			target.Variable40.Shadow = Variable40;
			target.Variable41.Shadow = Variable41;
			target.Variable42.Shadow = Variable42;
			target.Variable43.Shadow = Variable43;
			target.Variable44.Shadow = Variable44;
			target.Variable45.Shadow = Variable45;
			target.Variable46.Shadow = Variable46;
			target.Variable47.Shadow = Variable47;
			target.Variable48.Shadow = Variable48;
			target.Variable49.Shadow = Variable49;
			target.Variable50.Shadow = Variable50;
		}

		public void CopyPlainToShadow(Plc.IShadowStructWith50Variables target)
		{
			this.CopyPlainToShadow((Plc.StructWith50Variables)target);
		}

		public void CopyCyclicToPlain(Plc.StructWith50Variables source)
		{
			Variable1 = source.Variable1.LastValue;
			Variable2 = source.Variable2.LastValue;
			Variable3 = source.Variable3.LastValue;
			Variable4 = source.Variable4.LastValue;
			Variable5 = source.Variable5.LastValue;
			Variable6 = source.Variable6.LastValue;
			Variable7 = source.Variable7.LastValue;
			Variable8 = source.Variable8.LastValue;
			Variable9 = source.Variable9.LastValue;
			Variable10 = source.Variable10.LastValue;
			Variable11 = source.Variable11.LastValue;
			Variable12 = source.Variable12.LastValue;
			Variable13 = source.Variable13.LastValue;
			Variable14 = source.Variable14.LastValue;
			Variable15 = source.Variable15.LastValue;
			Variable16 = source.Variable16.LastValue;
			Variable17 = source.Variable17.LastValue;
			Variable18 = source.Variable18.LastValue;
			Variable19 = source.Variable19.LastValue;
			Variable20 = source.Variable20.LastValue;
			Variable21 = source.Variable21.LastValue;
			Variable22 = source.Variable22.LastValue;
			Variable23 = source.Variable23.LastValue;
			Variable24 = source.Variable24.LastValue;
			Variable25 = source.Variable25.LastValue;
			Variable26 = source.Variable26.LastValue;
			Variable27 = source.Variable27.LastValue;
			Variable28 = source.Variable28.LastValue;
			Variable29 = source.Variable29.LastValue;
			Variable30 = source.Variable30.LastValue;
			Variable31 = source.Variable31.LastValue;
			Variable32 = source.Variable32.LastValue;
			Variable33 = source.Variable33.LastValue;
			Variable34 = source.Variable34.LastValue;
			Variable35 = source.Variable35.LastValue;
			Variable36 = source.Variable36.LastValue;
			Variable37 = source.Variable37.LastValue;
			Variable38 = source.Variable38.LastValue;
			Variable39 = source.Variable39.LastValue;
			Variable40 = source.Variable40.LastValue;
			Variable41 = source.Variable41.LastValue;
			Variable42 = source.Variable42.LastValue;
			Variable43 = source.Variable43.LastValue;
			Variable44 = source.Variable44.LastValue;
			Variable45 = source.Variable45.LastValue;
			Variable46 = source.Variable46.LastValue;
			Variable47 = source.Variable47.LastValue;
			Variable48 = source.Variable48.LastValue;
			Variable49 = source.Variable49.LastValue;
			Variable50 = source.Variable50.LastValue;
		}

		public void CopyCyclicToPlain(Plc.IStructWith50Variables source)
		{
			this.CopyCyclicToPlain((Plc.StructWith50Variables)source);
		}

		public void CopyShadowToPlain(Plc.StructWith50Variables source)
		{
			Variable1 = source.Variable1.Shadow;
			Variable2 = source.Variable2.Shadow;
			Variable3 = source.Variable3.Shadow;
			Variable4 = source.Variable4.Shadow;
			Variable5 = source.Variable5.Shadow;
			Variable6 = source.Variable6.Shadow;
			Variable7 = source.Variable7.Shadow;
			Variable8 = source.Variable8.Shadow;
			Variable9 = source.Variable9.Shadow;
			Variable10 = source.Variable10.Shadow;
			Variable11 = source.Variable11.Shadow;
			Variable12 = source.Variable12.Shadow;
			Variable13 = source.Variable13.Shadow;
			Variable14 = source.Variable14.Shadow;
			Variable15 = source.Variable15.Shadow;
			Variable16 = source.Variable16.Shadow;
			Variable17 = source.Variable17.Shadow;
			Variable18 = source.Variable18.Shadow;
			Variable19 = source.Variable19.Shadow;
			Variable20 = source.Variable20.Shadow;
			Variable21 = source.Variable21.Shadow;
			Variable22 = source.Variable22.Shadow;
			Variable23 = source.Variable23.Shadow;
			Variable24 = source.Variable24.Shadow;
			Variable25 = source.Variable25.Shadow;
			Variable26 = source.Variable26.Shadow;
			Variable27 = source.Variable27.Shadow;
			Variable28 = source.Variable28.Shadow;
			Variable29 = source.Variable29.Shadow;
			Variable30 = source.Variable30.Shadow;
			Variable31 = source.Variable31.Shadow;
			Variable32 = source.Variable32.Shadow;
			Variable33 = source.Variable33.Shadow;
			Variable34 = source.Variable34.Shadow;
			Variable35 = source.Variable35.Shadow;
			Variable36 = source.Variable36.Shadow;
			Variable37 = source.Variable37.Shadow;
			Variable38 = source.Variable38.Shadow;
			Variable39 = source.Variable39.Shadow;
			Variable40 = source.Variable40.Shadow;
			Variable41 = source.Variable41.Shadow;
			Variable42 = source.Variable42.Shadow;
			Variable43 = source.Variable43.Shadow;
			Variable44 = source.Variable44.Shadow;
			Variable45 = source.Variable45.Shadow;
			Variable46 = source.Variable46.Shadow;
			Variable47 = source.Variable47.Shadow;
			Variable48 = source.Variable48.Shadow;
			Variable49 = source.Variable49.Shadow;
			Variable50 = source.Variable50.Shadow;
		}

		public void CopyShadowToPlain(Plc.IShadowStructWith50Variables source)
		{
			this.CopyShadowToPlain((Plc.StructWith50Variables)source);
		}
	}
}