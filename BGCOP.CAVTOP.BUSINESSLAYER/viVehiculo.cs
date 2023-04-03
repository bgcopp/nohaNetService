using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="viVehiculo")]
	[Serializable]
	public class viVehiculo : EntityObject
	{
		private int _idVehiculo;

		private string _Placa;

		private string _CodigodeBarras;

		private string _NombreModelo;

		private string _NombreMarcaVehiculo;

		private string _color;

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string CodigodeBarras
		{
			get
			{
				return this._CodigodeBarras;
			}
			set
			{
				this.ReportPropertyChanging("CodigodeBarras");
				this._CodigodeBarras = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("CodigodeBarras");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string color
		{
			get
			{
				return this._color;
			}
			set
			{
				this.ReportPropertyChanging("color");
				this._color = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("color");
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
		public string NombreMarcaVehiculo
		{
			get
			{
				return this._NombreMarcaVehiculo;
			}
			set
			{
				this.ReportPropertyChanging("NombreMarcaVehiculo");
				this._NombreMarcaVehiculo = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("NombreMarcaVehiculo");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string NombreModelo
		{
			get
			{
				return this._NombreModelo;
			}
			set
			{
				this.ReportPropertyChanging("NombreModelo");
				this._NombreModelo = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("NombreModelo");
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

		public viVehiculo()
		{
		}

		public static viVehiculo CreateviVehiculo(int idVehiculo)
		{
			return new viVehiculo()
			{
				idVehiculo = idVehiculo
			};
		}
	}
}