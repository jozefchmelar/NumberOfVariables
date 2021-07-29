using System;

namespace Plc
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainStructWith5Variables : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Int16 _Variable1;
		public System.Int16 Variable1
		{
			get
			{
				return _Variable1;
			}

			set
			{
				if (_Variable1 != value)
				{
					_Variable1 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Variable1)));
				}
			}
		}

		System.Int16 _Variable2;
		public System.Int16 Variable2
		{
			get
			{
				return _Variable2;
			}

			set
			{
				if (_Variable2 != value)
				{
					_Variable2 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Variable2)));
				}
			}
		}

		System.Int16 _Variable3;
		public System.Int16 Variable3
		{
			get
			{
				return _Variable3;
			}

			set
			{
				if (_Variable3 != value)
				{
					_Variable3 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Variable3)));
				}
			}
		}

		System.Int16 _Variable4;
		public System.Int16 Variable4
		{
			get
			{
				return _Variable4;
			}

			set
			{
				if (_Variable4 != value)
				{
					_Variable4 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Variable4)));
				}
			}
		}

		System.Int16 _Variable5;
		public System.Int16 Variable5
		{
			get
			{
				return _Variable5;
			}

			set
			{
				if (_Variable5 != value)
				{
					_Variable5 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Variable5)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainStructWith5Variables()
		{
		}
	}
}