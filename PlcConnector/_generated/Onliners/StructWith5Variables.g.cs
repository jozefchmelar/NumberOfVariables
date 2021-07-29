using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "StructWith5Variables", "Plc", TypeComplexityEnum.Complex)]
	public partial class StructWith5Variables : Vortex.Connector.IVortexObject, IStructWith5Variables, IShadowStructWith5Variables, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith5Variables.Variable1
		{
			get
			{
				return Variable1;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith5Variables.Variable1
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

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith5Variables.Variable2
		{
			get
			{
				return Variable2;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith5Variables.Variable2
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

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith5Variables.Variable3
		{
			get
			{
				return Variable3;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith5Variables.Variable3
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

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith5Variables.Variable4
		{
			get
			{
				return Variable4;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith5Variables.Variable4
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

		Vortex.Connector.ValueTypes.Online.IOnlineInt IStructWith5Variables.Variable5
		{
			get
			{
				return Variable5;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowStructWith5Variables.Variable5
		{
			get
			{
				return Variable5;
			}
		}

		public void LazyOnlineToShadow()
		{
			Variable1.Shadow = Variable1.LastValue;
			Variable2.Shadow = Variable2.LastValue;
			Variable3.Shadow = Variable3.LastValue;
			Variable4.Shadow = Variable4.LastValue;
			Variable5.Shadow = Variable5.LastValue;
		}

		public void LazyShadowToOnline()
		{
			Variable1.Cyclic = Variable1.Shadow;
			Variable2.Cyclic = Variable2.Shadow;
			Variable3.Cyclic = Variable3.Shadow;
			Variable4.Cyclic = Variable4.Shadow;
			Variable5.Cyclic = Variable5.Shadow;
		}

		public PlainStructWith5Variables CreatePlainerType()
		{
			var cloned = new PlainStructWith5Variables();
			return cloned;
		}

		protected PlainStructWith5Variables CreatePlainerType(PlainStructWith5Variables cloned)
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

		public void FlushPlainToOnline(Plc.PlainStructWith5Variables source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainStructWith5Variables source)
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

		public void FlushOnlineToPlain(Plc.PlainStructWith5Variables source)
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

		public StructWith5Variables(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public StructWith5Variables()
		{
			PexPreConstructorParameterless();
			_Variable1 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable2 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable3 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable4 = Vortex.Connector.IConnectorFactory.CreateINT();
			_Variable5 = Vortex.Connector.IConnectorFactory.CreateINT();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainStructWith5Variables
	{
		public void CopyPlainToCyclic(Plc.StructWith5Variables target)
		{
			target.Variable1.Cyclic = Variable1;
			target.Variable2.Cyclic = Variable2;
			target.Variable3.Cyclic = Variable3;
			target.Variable4.Cyclic = Variable4;
			target.Variable5.Cyclic = Variable5;
		}

		public void CopyPlainToCyclic(Plc.IStructWith5Variables target)
		{
			this.CopyPlainToCyclic((Plc.StructWith5Variables)target);
		}

		public void CopyPlainToShadow(Plc.StructWith5Variables target)
		{
			target.Variable1.Shadow = Variable1;
			target.Variable2.Shadow = Variable2;
			target.Variable3.Shadow = Variable3;
			target.Variable4.Shadow = Variable4;
			target.Variable5.Shadow = Variable5;
		}

		public void CopyPlainToShadow(Plc.IShadowStructWith5Variables target)
		{
			this.CopyPlainToShadow((Plc.StructWith5Variables)target);
		}

		public void CopyCyclicToPlain(Plc.StructWith5Variables source)
		{
			Variable1 = source.Variable1.LastValue;
			Variable2 = source.Variable2.LastValue;
			Variable3 = source.Variable3.LastValue;
			Variable4 = source.Variable4.LastValue;
			Variable5 = source.Variable5.LastValue;
		}

		public void CopyCyclicToPlain(Plc.IStructWith5Variables source)
		{
			this.CopyCyclicToPlain((Plc.StructWith5Variables)source);
		}

		public void CopyShadowToPlain(Plc.StructWith5Variables source)
		{
			Variable1 = source.Variable1.Shadow;
			Variable2 = source.Variable2.Shadow;
			Variable3 = source.Variable3.Shadow;
			Variable4 = source.Variable4.Shadow;
			Variable5 = source.Variable5.Shadow;
		}

		public void CopyShadowToPlain(Plc.IShadowStructWith5Variables source)
		{
			this.CopyShadowToPlain((Plc.StructWith5Variables)source);
		}
	}
}