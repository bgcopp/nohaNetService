using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="viEmpleado")]
	[Serializable]
	public class viEmpleado : EntityObject
	{
		private int _idEmpleado;

		private string _nombre;

		private string _descripcionIdentificacion;

		private string _identificacion;

		private byte[] _foto;

		private string _RazonSocial;

		private string _NombreDivision;

		private string _NombreCargo;

		private string _NombreEstado;

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string descripcionIdentificacion
		{
			get
			{
				return this._descripcionIdentificacion;
			}
			set
			{
				this.ReportPropertyChanging("descripcionIdentificacion");
				this._descripcionIdentificacion = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("descripcionIdentificacion");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public byte[] foto
		{
			get
			{
				return StructuralObject.GetValidValue(this._foto);
			}
			set
			{
				this.ReportPropertyChanging("foto");
				this._foto = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("foto");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
		public int idEmpleado
		{
			get
			{
				return this._idEmpleado;
			}
			set
			{
				if (this._idEmpleado != value)
				{
					this.ReportPropertyChanging("idEmpleado");
					this._idEmpleado = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idEmpleado");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string identificacion
		{
			get
			{
				return this._identificacion;
			}
			set
			{
				this.ReportPropertyChanging("identificacion");
				this._identificacion = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("identificacion");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if (this._nombre != value)
				{
					this.ReportPropertyChanging("nombre");
					this._nombre = StructuralObject.SetValidValue(value, false);
					this.ReportPropertyChanged("nombre");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string NombreCargo
		{
			get
			{
				return this._NombreCargo;
			}
			set
			{
				this.ReportPropertyChanging("NombreCargo");
				this._NombreCargo = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("NombreCargo");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string NombreDivision
		{
			get
			{
				return this._NombreDivision;
			}
			set
			{
				this.ReportPropertyChanging("NombreDivision");
				this._NombreDivision = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("NombreDivision");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string NombreEstado
		{
			get
			{
				return this._NombreEstado;
			}
			set
			{
				this.ReportPropertyChanging("NombreEstado");
				this._NombreEstado = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("NombreEstado");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string RazonSocial
		{
			get
			{
				return this._RazonSocial;
			}
			set
			{
				this.ReportPropertyChanging("RazonSocial");
				this._RazonSocial = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("RazonSocial");
			}
		}

		public viEmpleado()
		{
		}

		public static viEmpleado CreateviEmpleado(int idEmpleado, string nombre)
		{
			return new viEmpleado()
			{
				idEmpleado = idEmpleado,
				nombre = nombre
			};
		}
	}
}