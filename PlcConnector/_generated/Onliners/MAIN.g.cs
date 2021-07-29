using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "MAIN", "Plc", TypeComplexityEnum.Complex)]
	public partial class MAIN : Vortex.Connector.IVortexObject, IMAIN, IShadowMAIN, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		StructWith50Variables _first;
		public StructWith50Variables first
		{
			get
			{
				return _first;
			}
		}

		IStructWith50Variables IMAIN.first
		{
			get
			{
				return first;
			}
		}

		IShadowStructWith50Variables IShadowMAIN.first
		{
			get
			{
				return first;
			}
		}

		StructWith5Variables _second;
		public StructWith5Variables second
		{
			get
			{
				return _second;
			}
		}

		IStructWith5Variables IMAIN.second
		{
			get
			{
				return second;
			}
		}

		IShadowStructWith5Variables IShadowMAIN.second
		{
			get
			{
				return second;
			}
		}

		StructWith68Variables _third;
		public StructWith68Variables third
		{
			get
			{
				return _third;
			}
		}

		IStructWith68Variables IMAIN.third
		{
			get
			{
				return third;
			}
		}

		IShadowStructWith68Variables IShadowMAIN.third
		{
			get
			{
				return third;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _ShouldBe5;
		public Vortex.Connector.ValueTypes.OnlinerInt ShouldBe5
		{
			get
			{
				return _ShouldBe5;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IMAIN.ShouldBe5
		{
			get
			{
				return ShouldBe5;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowMAIN.ShouldBe5
		{
			get
			{
				return ShouldBe5;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _ShouldBe68;
		public Vortex.Connector.ValueTypes.OnlinerInt ShouldBe68
		{
			get
			{
				return _ShouldBe68;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IMAIN.ShouldBe68
		{
			get
			{
				return ShouldBe68;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowMAIN.ShouldBe68
		{
			get
			{
				return ShouldBe68;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _ShouldBe50;
		public Vortex.Connector.ValueTypes.OnlinerInt ShouldBe50
		{
			get
			{
				return _ShouldBe50;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IMAIN.ShouldBe50
		{
			get
			{
				return ShouldBe50;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowMAIN.ShouldBe50
		{
			get
			{
				return ShouldBe50;
			}
		}

		public void LazyOnlineToShadow()
		{
			first.LazyOnlineToShadow();
			second.LazyOnlineToShadow();
			third.LazyOnlineToShadow();
			ShouldBe5.Shadow = ShouldBe5.LastValue;
			ShouldBe68.Shadow = ShouldBe68.LastValue;
			ShouldBe50.Shadow = ShouldBe50.LastValue;
		}

		public void LazyShadowToOnline()
		{
			first.LazyShadowToOnline();
			second.LazyShadowToOnline();
			third.LazyShadowToOnline();
			ShouldBe5.Cyclic = ShouldBe5.Shadow;
			ShouldBe68.Cyclic = ShouldBe68.Shadow;
			ShouldBe50.Cyclic = ShouldBe50.Shadow;
		}

		public PlainMAIN CreatePlainerType()
		{
			var cloned = new PlainMAIN();
			cloned.first = first.CreatePlainerType();
			cloned.second = second.CreatePlainerType();
			cloned.third = third.CreatePlainerType();
			return cloned;
		}

		protected PlainMAIN CreatePlainerType(PlainMAIN cloned)
		{
			cloned.first = first.CreatePlainerType();
			cloned.second = second.CreatePlainerType();
			cloned.third = third.CreatePlainerType();
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

		public void FlushPlainToOnline(Plc.PlainMAIN source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainMAIN source)
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

		public void FlushOnlineToPlain(Plc.PlainMAIN source)
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

		public MAIN(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_first = new StructWith50Variables(this, "", "first");
			_second = new StructWith5Variables(this, "", "second");
			_third = new StructWith68Variables(this, "", "third");
			_ShouldBe5 = @Connector.Online.Adapter.CreateINT(this, "", "ShouldBe5");
			_ShouldBe68 = @Connector.Online.Adapter.CreateINT(this, "", "ShouldBe68");
			_ShouldBe50 = @Connector.Online.Adapter.CreateINT(this, "", "ShouldBe50");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public MAIN()
		{
			PexPreConstructorParameterless();
			_first = new StructWith50Variables();
			_second = new StructWith5Variables();
			_third = new StructWith68Variables();
			_ShouldBe5 = Vortex.Connector.IConnectorFactory.CreateINT();
			_ShouldBe68 = Vortex.Connector.IConnectorFactory.CreateINT();
			_ShouldBe50 = Vortex.Connector.IConnectorFactory.CreateINT();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMAIN
	{
		public void CopyPlainToCyclic(Plc.MAIN target)
		{
			first.CopyPlainToCyclic(target.first);
			second.CopyPlainToCyclic(target.second);
			third.CopyPlainToCyclic(target.third);
			target.ShouldBe5.Cyclic = ShouldBe5;
			target.ShouldBe68.Cyclic = ShouldBe68;
			target.ShouldBe50.Cyclic = ShouldBe50;
		}

		public void CopyPlainToCyclic(Plc.IMAIN target)
		{
			this.CopyPlainToCyclic((Plc.MAIN)target);
		}

		public void CopyPlainToShadow(Plc.MAIN target)
		{
			first.CopyPlainToShadow(target.first);
			second.CopyPlainToShadow(target.second);
			third.CopyPlainToShadow(target.third);
			target.ShouldBe5.Shadow = ShouldBe5;
			target.ShouldBe68.Shadow = ShouldBe68;
			target.ShouldBe50.Shadow = ShouldBe50;
		}

		public void CopyPlainToShadow(Plc.IShadowMAIN target)
		{
			this.CopyPlainToShadow((Plc.MAIN)target);
		}

		public void CopyCyclicToPlain(Plc.MAIN source)
		{
			first.CopyCyclicToPlain(source.first);
			second.CopyCyclicToPlain(source.second);
			third.CopyCyclicToPlain(source.third);
			ShouldBe5 = source.ShouldBe5.LastValue;
			ShouldBe68 = source.ShouldBe68.LastValue;
			ShouldBe50 = source.ShouldBe50.LastValue;
		}

		public void CopyCyclicToPlain(Plc.IMAIN source)
		{
			this.CopyCyclicToPlain((Plc.MAIN)source);
		}

		public void CopyShadowToPlain(Plc.MAIN source)
		{
			first.CopyShadowToPlain(source.first);
			second.CopyShadowToPlain(source.second);
			third.CopyShadowToPlain(source.third);
			ShouldBe5 = source.ShouldBe5.Shadow;
			ShouldBe68 = source.ShouldBe68.Shadow;
			ShouldBe50 = source.ShouldBe50.Shadow;
		}

		public void CopyShadowToPlain(Plc.IShadowMAIN source)
		{
			this.CopyShadowToPlain((Plc.MAIN)source);
		}
	}
}