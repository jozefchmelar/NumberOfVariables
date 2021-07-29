using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "StructWith68Variables", "Plc", TypeComplexityEnum.Complex)]
	public partial class StructWith68Variables : Vortex.Connector.IVortexObject, IStructWith68Variables, IShadowStructWith68Variables, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerString _Variable1;
		public Vortex.Connector.ValueTypes.OnlinerString Variable1
		{
			get
			{
				return _Variable1;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable1
		{
			get
			{
				return Variable1;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable1
		{
			get
			{
				return Variable1;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable2;
		public Vortex.Connector.ValueTypes.OnlinerString Variable2
		{
			get
			{
				return _Variable2;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable2
		{
			get
			{
				return Variable2;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable2
		{
			get
			{
				return Variable2;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable3;
		public Vortex.Connector.ValueTypes.OnlinerString Variable3
		{
			get
			{
				return _Variable3;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable3
		{
			get
			{
				return Variable3;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable3
		{
			get
			{
				return Variable3;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable4;
		public Vortex.Connector.ValueTypes.OnlinerString Variable4
		{
			get
			{
				return _Variable4;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable4
		{
			get
			{
				return Variable4;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable4
		{
			get
			{
				return Variable4;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable5;
		public Vortex.Connector.ValueTypes.OnlinerString Variable5
		{
			get
			{
				return _Variable5;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable5
		{
			get
			{
				return Variable5;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable5
		{
			get
			{
				return Variable5;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable6;
		public Vortex.Connector.ValueTypes.OnlinerString Variable6
		{
			get
			{
				return _Variable6;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable6
		{
			get
			{
				return Variable6;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable6
		{
			get
			{
				return Variable6;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable7;
		public Vortex.Connector.ValueTypes.OnlinerString Variable7
		{
			get
			{
				return _Variable7;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable7
		{
			get
			{
				return Variable7;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable7
		{
			get
			{
				return Variable7;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable8;
		public Vortex.Connector.ValueTypes.OnlinerString Variable8
		{
			get
			{
				return _Variable8;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable8
		{
			get
			{
				return Variable8;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable8
		{
			get
			{
				return Variable8;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable9;
		public Vortex.Connector.ValueTypes.OnlinerString Variable9
		{
			get
			{
				return _Variable9;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable9
		{
			get
			{
				return Variable9;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable9
		{
			get
			{
				return Variable9;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable10;
		public Vortex.Connector.ValueTypes.OnlinerString Variable10
		{
			get
			{
				return _Variable10;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable10
		{
			get
			{
				return Variable10;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable10
		{
			get
			{
				return Variable10;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable11;
		public Vortex.Connector.ValueTypes.OnlinerString Variable11
		{
			get
			{
				return _Variable11;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable11
		{
			get
			{
				return Variable11;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable11
		{
			get
			{
				return Variable11;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable12;
		public Vortex.Connector.ValueTypes.OnlinerString Variable12
		{
			get
			{
				return _Variable12;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable12
		{
			get
			{
				return Variable12;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable12
		{
			get
			{
				return Variable12;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable13;
		public Vortex.Connector.ValueTypes.OnlinerString Variable13
		{
			get
			{
				return _Variable13;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable13
		{
			get
			{
				return Variable13;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable13
		{
			get
			{
				return Variable13;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable14;
		public Vortex.Connector.ValueTypes.OnlinerString Variable14
		{
			get
			{
				return _Variable14;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable14
		{
			get
			{
				return Variable14;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable14
		{
			get
			{
				return Variable14;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable15;
		public Vortex.Connector.ValueTypes.OnlinerString Variable15
		{
			get
			{
				return _Variable15;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable15
		{
			get
			{
				return Variable15;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable15
		{
			get
			{
				return Variable15;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable16;
		public Vortex.Connector.ValueTypes.OnlinerString Variable16
		{
			get
			{
				return _Variable16;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable16
		{
			get
			{
				return Variable16;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable16
		{
			get
			{
				return Variable16;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable17;
		public Vortex.Connector.ValueTypes.OnlinerString Variable17
		{
			get
			{
				return _Variable17;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable17
		{
			get
			{
				return Variable17;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable17
		{
			get
			{
				return Variable17;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable18;
		public Vortex.Connector.ValueTypes.OnlinerString Variable18
		{
			get
			{
				return _Variable18;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable18
		{
			get
			{
				return Variable18;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable18
		{
			get
			{
				return Variable18;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable19;
		public Vortex.Connector.ValueTypes.OnlinerString Variable19
		{
			get
			{
				return _Variable19;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable19
		{
			get
			{
				return Variable19;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable19
		{
			get
			{
				return Variable19;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable20;
		public Vortex.Connector.ValueTypes.OnlinerString Variable20
		{
			get
			{
				return _Variable20;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable20
		{
			get
			{
				return Variable20;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable20
		{
			get
			{
				return Variable20;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable21;
		public Vortex.Connector.ValueTypes.OnlinerString Variable21
		{
			get
			{
				return _Variable21;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable21
		{
			get
			{
				return Variable21;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable21
		{
			get
			{
				return Variable21;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable22;
		public Vortex.Connector.ValueTypes.OnlinerString Variable22
		{
			get
			{
				return _Variable22;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable22
		{
			get
			{
				return Variable22;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable22
		{
			get
			{
				return Variable22;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable23;
		public Vortex.Connector.ValueTypes.OnlinerString Variable23
		{
			get
			{
				return _Variable23;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable23
		{
			get
			{
				return Variable23;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable23
		{
			get
			{
				return Variable23;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable24;
		public Vortex.Connector.ValueTypes.OnlinerString Variable24
		{
			get
			{
				return _Variable24;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable24
		{
			get
			{
				return Variable24;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable24
		{
			get
			{
				return Variable24;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable25;
		public Vortex.Connector.ValueTypes.OnlinerString Variable25
		{
			get
			{
				return _Variable25;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable25
		{
			get
			{
				return Variable25;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable25
		{
			get
			{
				return Variable25;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable26;
		public Vortex.Connector.ValueTypes.OnlinerString Variable26
		{
			get
			{
				return _Variable26;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable26
		{
			get
			{
				return Variable26;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable26
		{
			get
			{
				return Variable26;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable27;
		public Vortex.Connector.ValueTypes.OnlinerString Variable27
		{
			get
			{
				return _Variable27;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable27
		{
			get
			{
				return Variable27;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable27
		{
			get
			{
				return Variable27;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable28;
		public Vortex.Connector.ValueTypes.OnlinerString Variable28
		{
			get
			{
				return _Variable28;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable28
		{
			get
			{
				return Variable28;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable28
		{
			get
			{
				return Variable28;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable29;
		public Vortex.Connector.ValueTypes.OnlinerString Variable29
		{
			get
			{
				return _Variable29;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable29
		{
			get
			{
				return Variable29;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable29
		{
			get
			{
				return Variable29;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable30;
		public Vortex.Connector.ValueTypes.OnlinerString Variable30
		{
			get
			{
				return _Variable30;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable30
		{
			get
			{
				return Variable30;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable30
		{
			get
			{
				return Variable30;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable31;
		public Vortex.Connector.ValueTypes.OnlinerString Variable31
		{
			get
			{
				return _Variable31;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable31
		{
			get
			{
				return Variable31;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable31
		{
			get
			{
				return Variable31;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable32;
		public Vortex.Connector.ValueTypes.OnlinerString Variable32
		{
			get
			{
				return _Variable32;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable32
		{
			get
			{
				return Variable32;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable32
		{
			get
			{
				return Variable32;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable33;
		public Vortex.Connector.ValueTypes.OnlinerString Variable33
		{
			get
			{
				return _Variable33;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable33
		{
			get
			{
				return Variable33;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable33
		{
			get
			{
				return Variable33;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable34;
		public Vortex.Connector.ValueTypes.OnlinerString Variable34
		{
			get
			{
				return _Variable34;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable34
		{
			get
			{
				return Variable34;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable34
		{
			get
			{
				return Variable34;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable35;
		public Vortex.Connector.ValueTypes.OnlinerString Variable35
		{
			get
			{
				return _Variable35;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable35
		{
			get
			{
				return Variable35;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable35
		{
			get
			{
				return Variable35;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable36;
		public Vortex.Connector.ValueTypes.OnlinerString Variable36
		{
			get
			{
				return _Variable36;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable36
		{
			get
			{
				return Variable36;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable36
		{
			get
			{
				return Variable36;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable37;
		public Vortex.Connector.ValueTypes.OnlinerString Variable37
		{
			get
			{
				return _Variable37;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable37
		{
			get
			{
				return Variable37;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable37
		{
			get
			{
				return Variable37;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable38;
		public Vortex.Connector.ValueTypes.OnlinerString Variable38
		{
			get
			{
				return _Variable38;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable38
		{
			get
			{
				return Variable38;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable38
		{
			get
			{
				return Variable38;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable39;
		public Vortex.Connector.ValueTypes.OnlinerString Variable39
		{
			get
			{
				return _Variable39;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable39
		{
			get
			{
				return Variable39;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable39
		{
			get
			{
				return Variable39;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable40;
		public Vortex.Connector.ValueTypes.OnlinerString Variable40
		{
			get
			{
				return _Variable40;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable40
		{
			get
			{
				return Variable40;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable40
		{
			get
			{
				return Variable40;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable41;
		public Vortex.Connector.ValueTypes.OnlinerString Variable41
		{
			get
			{
				return _Variable41;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable41
		{
			get
			{
				return Variable41;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable41
		{
			get
			{
				return Variable41;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable42;
		public Vortex.Connector.ValueTypes.OnlinerString Variable42
		{
			get
			{
				return _Variable42;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable42
		{
			get
			{
				return Variable42;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable42
		{
			get
			{
				return Variable42;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable43;
		public Vortex.Connector.ValueTypes.OnlinerString Variable43
		{
			get
			{
				return _Variable43;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable43
		{
			get
			{
				return Variable43;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable43
		{
			get
			{
				return Variable43;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable44;
		public Vortex.Connector.ValueTypes.OnlinerString Variable44
		{
			get
			{
				return _Variable44;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable44
		{
			get
			{
				return Variable44;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable44
		{
			get
			{
				return Variable44;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable45;
		public Vortex.Connector.ValueTypes.OnlinerString Variable45
		{
			get
			{
				return _Variable45;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable45
		{
			get
			{
				return Variable45;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable45
		{
			get
			{
				return Variable45;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable46;
		public Vortex.Connector.ValueTypes.OnlinerString Variable46
		{
			get
			{
				return _Variable46;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable46
		{
			get
			{
				return Variable46;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable46
		{
			get
			{
				return Variable46;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable47;
		public Vortex.Connector.ValueTypes.OnlinerString Variable47
		{
			get
			{
				return _Variable47;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable47
		{
			get
			{
				return Variable47;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable47
		{
			get
			{
				return Variable47;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable48;
		public Vortex.Connector.ValueTypes.OnlinerString Variable48
		{
			get
			{
				return _Variable48;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable48
		{
			get
			{
				return Variable48;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable48
		{
			get
			{
				return Variable48;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable49;
		public Vortex.Connector.ValueTypes.OnlinerString Variable49
		{
			get
			{
				return _Variable49;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable49
		{
			get
			{
				return Variable49;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable49
		{
			get
			{
				return Variable49;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable50;
		public Vortex.Connector.ValueTypes.OnlinerString Variable50
		{
			get
			{
				return _Variable50;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable50
		{
			get
			{
				return Variable50;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable50
		{
			get
			{
				return Variable50;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable51;
		public Vortex.Connector.ValueTypes.OnlinerString Variable51
		{
			get
			{
				return _Variable51;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable51
		{
			get
			{
				return Variable51;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable51
		{
			get
			{
				return Variable51;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable52;
		public Vortex.Connector.ValueTypes.OnlinerString Variable52
		{
			get
			{
				return _Variable52;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable52
		{
			get
			{
				return Variable52;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable52
		{
			get
			{
				return Variable52;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable53;
		public Vortex.Connector.ValueTypes.OnlinerString Variable53
		{
			get
			{
				return _Variable53;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable53
		{
			get
			{
				return Variable53;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable53
		{
			get
			{
				return Variable53;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable54;
		public Vortex.Connector.ValueTypes.OnlinerString Variable54
		{
			get
			{
				return _Variable54;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable54
		{
			get
			{
				return Variable54;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable54
		{
			get
			{
				return Variable54;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable55;
		public Vortex.Connector.ValueTypes.OnlinerString Variable55
		{
			get
			{
				return _Variable55;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable55
		{
			get
			{
				return Variable55;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable55
		{
			get
			{
				return Variable55;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable56;
		public Vortex.Connector.ValueTypes.OnlinerString Variable56
		{
			get
			{
				return _Variable56;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable56
		{
			get
			{
				return Variable56;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable56
		{
			get
			{
				return Variable56;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable57;
		public Vortex.Connector.ValueTypes.OnlinerString Variable57
		{
			get
			{
				return _Variable57;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable57
		{
			get
			{
				return Variable57;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable57
		{
			get
			{
				return Variable57;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable58;
		public Vortex.Connector.ValueTypes.OnlinerString Variable58
		{
			get
			{
				return _Variable58;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable58
		{
			get
			{
				return Variable58;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable58
		{
			get
			{
				return Variable58;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable59;
		public Vortex.Connector.ValueTypes.OnlinerString Variable59
		{
			get
			{
				return _Variable59;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable59
		{
			get
			{
				return Variable59;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable59
		{
			get
			{
				return Variable59;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable60;
		public Vortex.Connector.ValueTypes.OnlinerString Variable60
		{
			get
			{
				return _Variable60;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable60
		{
			get
			{
				return Variable60;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable60
		{
			get
			{
				return Variable60;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable61;
		public Vortex.Connector.ValueTypes.OnlinerString Variable61
		{
			get
			{
				return _Variable61;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable61
		{
			get
			{
				return Variable61;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable61
		{
			get
			{
				return Variable61;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable62;
		public Vortex.Connector.ValueTypes.OnlinerString Variable62
		{
			get
			{
				return _Variable62;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable62
		{
			get
			{
				return Variable62;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable62
		{
			get
			{
				return Variable62;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable63;
		public Vortex.Connector.ValueTypes.OnlinerString Variable63
		{
			get
			{
				return _Variable63;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable63
		{
			get
			{
				return Variable63;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable63
		{
			get
			{
				return Variable63;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable64;
		public Vortex.Connector.ValueTypes.OnlinerString Variable64
		{
			get
			{
				return _Variable64;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable64
		{
			get
			{
				return Variable64;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable64
		{
			get
			{
				return Variable64;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable65;
		public Vortex.Connector.ValueTypes.OnlinerString Variable65
		{
			get
			{
				return _Variable65;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable65
		{
			get
			{
				return Variable65;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable65
		{
			get
			{
				return Variable65;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable66;
		public Vortex.Connector.ValueTypes.OnlinerString Variable66
		{
			get
			{
				return _Variable66;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable66
		{
			get
			{
				return Variable66;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable66
		{
			get
			{
				return Variable66;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable67;
		public Vortex.Connector.ValueTypes.OnlinerString Variable67
		{
			get
			{
				return _Variable67;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable67
		{
			get
			{
				return Variable67;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable67
		{
			get
			{
				return Variable67;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _Variable68;
		public Vortex.Connector.ValueTypes.OnlinerString Variable68
		{
			get
			{
				return _Variable68;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IStructWith68Variables.Variable68
		{
			get
			{
				return Variable68;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowStructWith68Variables.Variable68
		{
			get
			{
				return Variable68;
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
			Variable51.Shadow = Variable51.LastValue;
			Variable52.Shadow = Variable52.LastValue;
			Variable53.Shadow = Variable53.LastValue;
			Variable54.Shadow = Variable54.LastValue;
			Variable55.Shadow = Variable55.LastValue;
			Variable56.Shadow = Variable56.LastValue;
			Variable57.Shadow = Variable57.LastValue;
			Variable58.Shadow = Variable58.LastValue;
			Variable59.Shadow = Variable59.LastValue;
			Variable60.Shadow = Variable60.LastValue;
			Variable61.Shadow = Variable61.LastValue;
			Variable62.Shadow = Variable62.LastValue;
			Variable63.Shadow = Variable63.LastValue;
			Variable64.Shadow = Variable64.LastValue;
			Variable65.Shadow = Variable65.LastValue;
			Variable66.Shadow = Variable66.LastValue;
			Variable67.Shadow = Variable67.LastValue;
			Variable68.Shadow = Variable68.LastValue;
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
			Variable51.Cyclic = Variable51.Shadow;
			Variable52.Cyclic = Variable52.Shadow;
			Variable53.Cyclic = Variable53.Shadow;
			Variable54.Cyclic = Variable54.Shadow;
			Variable55.Cyclic = Variable55.Shadow;
			Variable56.Cyclic = Variable56.Shadow;
			Variable57.Cyclic = Variable57.Shadow;
			Variable58.Cyclic = Variable58.Shadow;
			Variable59.Cyclic = Variable59.Shadow;
			Variable60.Cyclic = Variable60.Shadow;
			Variable61.Cyclic = Variable61.Shadow;
			Variable62.Cyclic = Variable62.Shadow;
			Variable63.Cyclic = Variable63.Shadow;
			Variable64.Cyclic = Variable64.Shadow;
			Variable65.Cyclic = Variable65.Shadow;
			Variable66.Cyclic = Variable66.Shadow;
			Variable67.Cyclic = Variable67.Shadow;
			Variable68.Cyclic = Variable68.Shadow;
		}

		public PlainStructWith68Variables CreatePlainerType()
		{
			var cloned = new PlainStructWith68Variables();
			return cloned;
		}

		protected PlainStructWith68Variables CreatePlainerType(PlainStructWith68Variables cloned)
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

		public void FlushPlainToOnline(Plc.PlainStructWith68Variables source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainStructWith68Variables source)
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

		public void FlushOnlineToPlain(Plc.PlainStructWith68Variables source)
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

		public StructWith68Variables(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_Variable1 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable1");
			_Variable2 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable2");
			_Variable3 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable3");
			_Variable4 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable4");
			_Variable5 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable5");
			_Variable6 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable6");
			_Variable7 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable7");
			_Variable8 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable8");
			_Variable9 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable9");
			_Variable10 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable10");
			_Variable11 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable11");
			_Variable12 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable12");
			_Variable13 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable13");
			_Variable14 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable14");
			_Variable15 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable15");
			_Variable16 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable16");
			_Variable17 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable17");
			_Variable18 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable18");
			_Variable19 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable19");
			_Variable20 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable20");
			_Variable21 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable21");
			_Variable22 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable22");
			_Variable23 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable23");
			_Variable24 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable24");
			_Variable25 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable25");
			_Variable26 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable26");
			_Variable27 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable27");
			_Variable28 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable28");
			_Variable29 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable29");
			_Variable30 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable30");
			_Variable31 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable31");
			_Variable32 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable32");
			_Variable33 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable33");
			_Variable34 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable34");
			_Variable35 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable35");
			_Variable36 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable36");
			_Variable37 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable37");
			_Variable38 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable38");
			_Variable39 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable39");
			_Variable40 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable40");
			_Variable41 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable41");
			_Variable42 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable42");
			_Variable43 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable43");
			_Variable44 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable44");
			_Variable45 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable45");
			_Variable46 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable46");
			_Variable47 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable47");
			_Variable48 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable48");
			_Variable49 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable49");
			_Variable50 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable50");
			_Variable51 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable51");
			_Variable52 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable52");
			_Variable53 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable53");
			_Variable54 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable54");
			_Variable55 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable55");
			_Variable56 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable56");
			_Variable57 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable57");
			_Variable58 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable58");
			_Variable59 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable59");
			_Variable60 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable60");
			_Variable61 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable61");
			_Variable62 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable62");
			_Variable63 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable63");
			_Variable64 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable64");
			_Variable65 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable65");
			_Variable66 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable66");
			_Variable67 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable67");
			_Variable68 = @Connector.Online.Adapter.CreateSTRING(this, "", "Variable68");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public StructWith68Variables()
		{
			PexPreConstructorParameterless();
			_Variable1 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable2 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable3 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable4 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable5 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable6 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable7 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable8 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable9 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable10 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable11 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable12 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable13 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable14 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable15 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable16 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable17 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable18 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable19 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable20 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable21 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable22 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable23 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable24 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable25 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable26 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable27 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable28 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable29 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable30 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable31 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable32 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable33 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable34 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable35 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable36 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable37 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable38 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable39 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable40 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable41 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable42 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable43 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable44 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable45 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable46 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable47 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable48 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable49 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable50 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable51 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable52 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable53 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable54 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable55 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable56 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable57 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable58 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable59 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable60 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable61 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable62 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable63 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable64 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable65 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable66 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable67 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_Variable68 = Vortex.Connector.IConnectorFactory.CreateSTRING();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainStructWith68Variables
	{
		public void CopyPlainToCyclic(Plc.StructWith68Variables target)
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
			target.Variable51.Cyclic = Variable51;
			target.Variable52.Cyclic = Variable52;
			target.Variable53.Cyclic = Variable53;
			target.Variable54.Cyclic = Variable54;
			target.Variable55.Cyclic = Variable55;
			target.Variable56.Cyclic = Variable56;
			target.Variable57.Cyclic = Variable57;
			target.Variable58.Cyclic = Variable58;
			target.Variable59.Cyclic = Variable59;
			target.Variable60.Cyclic = Variable60;
			target.Variable61.Cyclic = Variable61;
			target.Variable62.Cyclic = Variable62;
			target.Variable63.Cyclic = Variable63;
			target.Variable64.Cyclic = Variable64;
			target.Variable65.Cyclic = Variable65;
			target.Variable66.Cyclic = Variable66;
			target.Variable67.Cyclic = Variable67;
			target.Variable68.Cyclic = Variable68;
		}

		public void CopyPlainToCyclic(Plc.IStructWith68Variables target)
		{
			this.CopyPlainToCyclic((Plc.StructWith68Variables)target);
		}

		public void CopyPlainToShadow(Plc.StructWith68Variables target)
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
			target.Variable51.Shadow = Variable51;
			target.Variable52.Shadow = Variable52;
			target.Variable53.Shadow = Variable53;
			target.Variable54.Shadow = Variable54;
			target.Variable55.Shadow = Variable55;
			target.Variable56.Shadow = Variable56;
			target.Variable57.Shadow = Variable57;
			target.Variable58.Shadow = Variable58;
			target.Variable59.Shadow = Variable59;
			target.Variable60.Shadow = Variable60;
			target.Variable61.Shadow = Variable61;
			target.Variable62.Shadow = Variable62;
			target.Variable63.Shadow = Variable63;
			target.Variable64.Shadow = Variable64;
			target.Variable65.Shadow = Variable65;
			target.Variable66.Shadow = Variable66;
			target.Variable67.Shadow = Variable67;
			target.Variable68.Shadow = Variable68;
		}

		public void CopyPlainToShadow(Plc.IShadowStructWith68Variables target)
		{
			this.CopyPlainToShadow((Plc.StructWith68Variables)target);
		}

		public void CopyCyclicToPlain(Plc.StructWith68Variables source)
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
			Variable51 = source.Variable51.LastValue;
			Variable52 = source.Variable52.LastValue;
			Variable53 = source.Variable53.LastValue;
			Variable54 = source.Variable54.LastValue;
			Variable55 = source.Variable55.LastValue;
			Variable56 = source.Variable56.LastValue;
			Variable57 = source.Variable57.LastValue;
			Variable58 = source.Variable58.LastValue;
			Variable59 = source.Variable59.LastValue;
			Variable60 = source.Variable60.LastValue;
			Variable61 = source.Variable61.LastValue;
			Variable62 = source.Variable62.LastValue;
			Variable63 = source.Variable63.LastValue;
			Variable64 = source.Variable64.LastValue;
			Variable65 = source.Variable65.LastValue;
			Variable66 = source.Variable66.LastValue;
			Variable67 = source.Variable67.LastValue;
			Variable68 = source.Variable68.LastValue;
		}

		public void CopyCyclicToPlain(Plc.IStructWith68Variables source)
		{
			this.CopyCyclicToPlain((Plc.StructWith68Variables)source);
		}

		public void CopyShadowToPlain(Plc.StructWith68Variables source)
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
			Variable51 = source.Variable51.Shadow;
			Variable52 = source.Variable52.Shadow;
			Variable53 = source.Variable53.Shadow;
			Variable54 = source.Variable54.Shadow;
			Variable55 = source.Variable55.Shadow;
			Variable56 = source.Variable56.Shadow;
			Variable57 = source.Variable57.Shadow;
			Variable58 = source.Variable58.Shadow;
			Variable59 = source.Variable59.Shadow;
			Variable60 = source.Variable60.Shadow;
			Variable61 = source.Variable61.Shadow;
			Variable62 = source.Variable62.Shadow;
			Variable63 = source.Variable63.Shadow;
			Variable64 = source.Variable64.Shadow;
			Variable65 = source.Variable65.Shadow;
			Variable66 = source.Variable66.Shadow;
			Variable67 = source.Variable67.Shadow;
			Variable68 = source.Variable68.Shadow;
		}

		public void CopyShadowToPlain(Plc.IShadowStructWith68Variables source)
		{
			this.CopyShadowToPlain((Plc.StructWith68Variables)source);
		}
	}
}