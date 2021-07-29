using System;

namespace Plc
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMAIN : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainStructWith50Variables _first;
		public PlainStructWith50Variables first
		{
			get
			{
				return _first;
			}

			set
			{
				if (_first != value)
				{
					_first = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(first)));
				}
			}
		}

		PlainStructWith5Variables _second;
		public PlainStructWith5Variables second
		{
			get
			{
				return _second;
			}

			set
			{
				if (_second != value)
				{
					_second = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(second)));
				}
			}
		}

		PlainStructWith68Variables _third;
		public PlainStructWith68Variables third
		{
			get
			{
				return _third;
			}

			set
			{
				if (_third != value)
				{
					_third = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(third)));
				}
			}
		}

		System.Int16 _ShouldBe5;
		public System.Int16 ShouldBe5
		{
			get
			{
				return _ShouldBe5;
			}

			set
			{
				if (_ShouldBe5 != value)
				{
					_ShouldBe5 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(ShouldBe5)));
				}
			}
		}

		System.Int16 _ShouldBe68;
		public System.Int16 ShouldBe68
		{
			get
			{
				return _ShouldBe68;
			}

			set
			{
				if (_ShouldBe68 != value)
				{
					_ShouldBe68 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(ShouldBe68)));
				}
			}
		}

		System.Int16 _ShouldBe50;
		public System.Int16 ShouldBe50
		{
			get
			{
				return _ShouldBe50;
			}

			set
			{
				if (_ShouldBe50 != value)
				{
					_ShouldBe50 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(ShouldBe50)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainMAIN()
		{
			_first = new PlainStructWith50Variables();
			_second = new PlainStructWith5Variables();
			_third = new PlainStructWith68Variables();
		}
	}
}