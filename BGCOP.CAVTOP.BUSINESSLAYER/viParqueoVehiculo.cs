using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="viParqueoVehiculo")]
	[Serializable]
	public class viParqueoVehiculo : EntityObject
	{
		private string _Placa;

		private string _Modelo;

		private string _Parqueadero;

		private bool? _Lunes;

		private bool? _Martes;

		private bool? _Miercoles;

		private bool? _Jueves;

		private bool? _Viernes;

		private bool? _Sábado;

		private bool? _Domingo;

		private int _idVehiculo;

		private int _idParqueadero;

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public bool? Domingo
		{
			get
			{
				return this._Domingo;
			}
			set
			{
				this.ReportPropertyChanging("Domingo");
				this._Domingo = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("Domingo");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
		public int idParqueadero
		{
			get
			{
				return this._idParqueadero;
			}
			set
			{
				if (this._idParqueadero != value)
				{
					this.ReportPropertyChanging("idParqueadero");
					this._idParqueadero = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idParqueadero");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
		public int idVehiculo
		{
			get
			{
				return this._idVehiculo;
			}
			set
			{
				if (this._idVehiculo != value)
				{
					this.ReportPropertyChanging("idVehiculo");
					this._idVehiculo = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idVehiculo");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public bool? Jueves
		{
			get
			{
				return this._Jueves;
			}
			set
			{
				this.ReportPropertyChanging("Jueves");
				this._Jueves = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("Jueves");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public bool? Lunes
		{
			get
			{
				return this._Lunes;
			}
			set
			{
				this.ReportPropertyChanging("Lunes");
				this._Lunes = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("Lunes");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public bool? Martes
		{
			get
			{
				return this._Martes;
			}
			set
			{
				this.ReportPropertyChanging("Martes");
				this._Martes = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("Martes");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public bool? Miercoles
		{
			get
			{
				return this._Miercoles;
			}
			set
			{
				this.ReportPropertyChanging("Miercoles");
				this._Miercoles = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("Miercoles");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string Modelo
		{
			get
			{
				return this._Modelo;
			}
			set
			{
				this.ReportPropertyChanging("Modelo");
				this._Modelo = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("Modelo");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string Parqueadero
		{
			get
			{
				return this._Parqueadero;
			}
			set
			{
				this.ReportPropertyChanging("Parqueadero");
				this._Parqueadero = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("Parqueadero");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string Placa
		{
			get
			{
				return this._Placa;
			}
			set
			{
				this.ReportPropertyChanging("Placa");
				this._Placa = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("Placa");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public bool? Sábado
		{
			get
			{
				return this._Sábado;
			}
			set
			{
				this.ReportPropertyChanging("Sábado");
				this._Sábado = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("Sábado");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public bool? Viernes
		{
			get
			{
				return this._Viernes;
			}
			set
			{
				this.ReportPropertyChanging("Viernes");
				this._Viernes = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("Viernes");
			}
		}

		public viParqueoVehiculo()
		{
		}

		public static viParqueoVehiculo CreateviParqueoVehiculo(int idVehiculo, int idParqueadero)
		{
			return new viParqueoVehiculo()
			{
				idVehiculo = idVehiculo,
				idParqueadero = idParqueadero
			};
		}
	}
}