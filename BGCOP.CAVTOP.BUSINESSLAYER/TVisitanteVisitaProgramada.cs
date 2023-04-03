using System;
using System.ComponentModel;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TVisitanteVisitaProgramada")]
	[Serializable]
	public class TVisitanteVisitaProgramada : EntityObject
	{
		private decimal _idVisitante;

		private decimal _idVisitaProgramada;

		private int? _idEmpleadoAutorizaEntrada;

		private DateTime? _fechaLlegada;

		private DateTime? _fechaSalida;

		private DateTime? _fechaUltimaGestion;

		private int? _usuarioUltimaGestion;

		private bool? _visitacumplida;

		private string _tarjeta;

		private int? _idTarjeta;

		private string _ObservacionesVisita;

		private decimal _idTabla;

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public DateTime? fechaLlegada
		{
			get
			{
				return this._fechaLlegada;
			}
			set
			{
				this.ReportPropertyChanging("fechaLlegada");
				this._fechaLlegada = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("fechaLlegada");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public DateTime? fechaSalida
		{
			get
			{
				return this._fechaSalida;
			}
			set
			{
				this.ReportPropertyChanging("fechaSalida");
				this._fechaSalida = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("fechaSalida");
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
		public int? idEmpleadoAutorizaEntrada
		{
			get
			{
				return this._idEmpleadoAutorizaEntrada;
			}
			set
			{
				this.ReportPropertyChanging("idEmpleadoAutorizaEntrada");
				this._idEmpleadoAutorizaEntrada = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idEmpleadoAutorizaEntrada");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
		public decimal idTabla
		{
			get
			{
				return this._idTabla;
			}
			set
			{
				this.ReportPropertyChanging("idTabla");
				this._idTabla = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idTabla");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public int? idTarjeta
		{
			get
			{
				return this._idTarjeta;
			}
			set
			{
				this.ReportPropertyChanging("idTarjeta");
				this._idTarjeta = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idTarjeta");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
		public decimal idVisitante
		{
			get
			{
				return this._idVisitante;
			}
			set
			{
				if (this._idVisitante != value)
				{
					this.ReportPropertyChanging("idVisitante");
					this._idVisitante = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idVisitante");
				}
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
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string tarjeta
		{
			get
			{
				return this._tarjeta;
			}
			set
			{
				this.ReportPropertyChanging("tarjeta");
				this._tarjeta = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("tarjeta");
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TVisitanteVisitaProgramada_TEmpleado", "TEmpleado")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado TEmpleado
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado>("masterDBACModel.FK_TVisitanteVisitaProgramada_TEmpleado", "TEmpleado").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado>("masterDBACModel.FK_TVisitanteVisitaProgramada_TEmpleado", "TEmpleado").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado> TEmpleadoReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado>("masterDBACModel.FK_TVisitanteVisitaProgramada_TEmpleado", "TEmpleado");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado>("masterDBACModel.FK_TVisitanteVisitaProgramada_TEmpleado", "TEmpleado", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TVisitanteVisitaProgramada_TVisitante", "TVisitante")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.TVisitante TVisitante
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TVisitante>("masterDBACModel.FK_TVisitanteVisitaProgramada_TVisitante", "TVisitante").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TVisitante>("masterDBACModel.FK_TVisitanteVisitaProgramada_TVisitante", "TVisitante").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.TVisitante> TVisitanteReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TVisitante>("masterDBACModel.FK_TVisitanteVisitaProgramada_TVisitante", "TVisitante");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TVisitante>("masterDBACModel.FK_TVisitanteVisitaProgramada_TVisitante", "TVisitante", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TVisitanteVisitaProgramada_TVisitaProgramada", "TVisitaProgramada")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.TVisitaProgramada TVisitaProgramada
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TVisitaProgramada>("masterDBACModel.FK_TVisitanteVisitaProgramada_TVisitaProgramada", "TVisitaProgramada").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TVisitaProgramada>("masterDBACModel.FK_TVisitanteVisitaProgramada_TVisitaProgramada", "TVisitaProgramada").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.TVisitaProgramada> TVisitaProgramadaReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TVisitaProgramada>("masterDBACModel.FK_TVisitanteVisitaProgramada_TVisitaProgramada", "TVisitaProgramada");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TVisitaProgramada>("masterDBACModel.FK_TVisitanteVisitaProgramada_TVisitaProgramada", "TVisitaProgramada", value);
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

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public bool? visitacumplida
		{
			get
			{
				return this._visitacumplida;
			}
			set
			{
				this.ReportPropertyChanging("visitacumplida");
				this._visitacumplida = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("visitacumplida");
			}
		}

		public TVisitanteVisitaProgramada()
		{
		}

		public static TVisitanteVisitaProgramada CreateTVisitanteVisitaProgramada(decimal idVisitante, decimal idVisitaProgramada, decimal idTabla)
		{
			TVisitanteVisitaProgramada tVisitanteVisitaProgramada = new TVisitanteVisitaProgramada()
			{
				idVisitante = idVisitante,
				idVisitaProgramada = idVisitaProgramada,
				idTabla = idTabla
			};
			return tVisitanteVisitaProgramada;
		}
	}
}