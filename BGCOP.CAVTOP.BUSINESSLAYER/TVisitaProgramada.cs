using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TVisitaProgramada")]
	[Serializable]
	public class TVisitaProgramada : EntityObject
	{
		private decimal _idVisitaProgramada;

		private string _DescripcionVisita;

		private DateTime? _fechaInicio;

		private DateTime? _fechafin;

		private int? _idEmpresa;

		private int? _idEmpleado;

		private string _ObservacionesVisita;

		private int? _idEstadoVisita;

		private DateTime? _fechadeIngreso;

		private DateTime? _fechaUltimaGestion;

		private int? _usuarioUltimaGestion;

		private int? _IdDivisionEmpresa;

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string DescripcionVisita
		{
			get
			{
				return this._DescripcionVisita;
			}
			set
			{
				this.ReportPropertyChanging("DescripcionVisita");
				this._DescripcionVisita = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("DescripcionVisita");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public DateTime? fechadeIngreso
		{
			get
			{
				return this._fechadeIngreso;
			}
			set
			{
				this.ReportPropertyChanging("fechadeIngreso");
				this._fechadeIngreso = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("fechadeIngreso");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public DateTime? fechafin
		{
			get
			{
				return this._fechafin;
			}
			set
			{
				this.ReportPropertyChanging("fechafin");
				this._fechafin = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("fechafin");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public DateTime? fechaInicio
		{
			get
			{
				return this._fechaInicio;
			}
			set
			{
				this.ReportPropertyChanging("fechaInicio");
				this._fechaInicio = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("fechaInicio");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public DateTime? fechaUltimaGestion
		{
			get
			{
				return this._fechaUltimaGestion;
			}
			set
			{
				this.ReportPropertyChanging("fechaUltimaGestion");
				this._fechaUltimaGestion = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("fechaUltimaGestion");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public int? IdDivisionEmpresa
		{
			get
			{
				return this._IdDivisionEmpresa;
			}
			set
			{
				this.ReportPropertyChanging("IdDivisionEmpresa");
				this._IdDivisionEmpresa = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("IdDivisionEmpresa");
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
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public int? idEmpresa
		{
			get
			{
				return this._idEmpresa;
			}
			set
			{
				this.ReportPropertyChanging("idEmpresa");
				this._idEmpresa = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idEmpresa");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public int? idEstadoVisita
		{
			get
			{
				return this._idEstadoVisita;
			}
			set
			{
				this.ReportPropertyChanging("idEstadoVisita");
				this._idEstadoVisita = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idEstadoVisita");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
		public decimal idVisitaProgramada
		{
			get
			{
				return this._idVisitaProgramada;
			}
			set
			{
				if (this._idVisitaProgramada != value)
				{
					this.ReportPropertyChanging("idVisitaProgramada");
					this._idVisitaProgramada = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idVisitaProgramada");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string ObservacionesVisita
		{
			get
			{
				return this._ObservacionesVisita;
			}
			set
			{
				this.ReportPropertyChanging("ObservacionesVisita");
				this._ObservacionesVisita = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("ObservacionesVisita");
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TVisitanteVisitaProgramada_TVisitaProgramada", "TVisitanteVisitaProgramada")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramada> TVisitanteVisitaProgramada
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramada>("masterDBACModel.FK_TVisitanteVisitaProgramada_TVisitaProgramada", "TVisitanteVisitaProgramada");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramada>("masterDBACModel.FK_TVisitanteVisitaProgramada_TVisitaProgramada", "TVisitanteVisitaProgramada", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TVisitanteVisitaProgramadaLog_TVisitaProgramada", "TVisitanteVisitaProgramadaLog")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramadaLog> TVisitanteVisitaProgramadaLog
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramadaLog>("masterDBACModel.FK_TVisitanteVisitaProgramadaLog_TVisitaProgramada", "TVisitanteVisitaProgramadaLog");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramadaLog>("masterDBACModel.FK_TVisitanteVisitaProgramadaLog_TVisitaProgramada", "TVisitanteVisitaProgramadaLog", value);
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public int? usuarioUltimaGestion
		{
			get
			{
				return this._usuarioUltimaGestion;
			}
			set
			{
				this.ReportPropertyChanging("usuarioUltimaGestion");
				this._usuarioUltimaGestion = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("usuarioUltimaGestion");
			}
		}

		public TVisitaProgramada()
		{
		}

		public static TVisitaProgramada CreateTVisitaProgramada(decimal idVisitaProgramada)
		{
			return new TVisitaProgramada()
			{
				idVisitaProgramada = idVisitaProgramada
			};
		}
	}
}