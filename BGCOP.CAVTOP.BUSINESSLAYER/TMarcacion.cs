using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TMarcacion")]
	[Serializable]
	public class TMarcacion : EntityObject
	{
		private decimal _idMarcacion;

		private string _NoTarjeta;

		private DateTime? _fechaMarcacion;

		private string _NoInner;

		private decimal? _idVisitante;

		private int? _idEmpleado;

		private decimal? _idVisitanteVistaP;

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public DateTime? fechaMarcacion
		{
			get
			{
				return this._fechaMarcacion;
			}
			set
			{
				this.ReportPropertyChanging("fechaMarcacion");
				this._fechaMarcacion = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("fechaMarcacion");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public int? idEmpleado
		{
			get
			{
				return this._idEmpleado;
			}
			set
			{
				this.ReportPropertyChanging("idEmpleado");
				this._idEmpleado = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idEmpleado");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
		public decimal idMarcacion
		{
			get
			{
				return this._idMarcacion;
			}
			set
			{
				if (this._idMarcacion != value)
				{
					this.ReportPropertyChanging("idMarcacion");
					this._idMarcacion = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idMarcacion");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public decimal? idVisitante
		{
			get
			{
				return this._idVisitante;
			}
			set
			{
				this.ReportPropertyChanging("idVisitante");
				this._idVisitante = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idVisitante");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public decimal? idVisitanteVistaP
		{
			get
			{
				return this._idVisitanteVistaP;
			}
			set
			{
				this.ReportPropertyChanging("idVisitanteVistaP");
				this._idVisitanteVistaP = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idVisitanteVistaP");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string NoInner
		{
			get
			{
				return this._NoInner;
			}
			set
			{
				this.ReportPropertyChanging("NoInner");
				this._NoInner = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("NoInner");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string NoTarjeta
		{
			get
			{
				return this._NoTarjeta;
			}
			set
			{
				this.ReportPropertyChanging("NoTarjeta");
				this._NoTarjeta = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("NoTarjeta");
			}
		}

		public TMarcacion()
		{
		}

		public static TMarcacion CreateTMarcacion(decimal idMarcacion)
		{
			return new TMarcacion()
			{
				idMarcacion = idMarcacion
			};
		}
	}
}