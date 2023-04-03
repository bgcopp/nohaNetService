using System;
using System.ComponentModel;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TVisitante")]
	[Serializable]
	public class TVisitante : EntityObject
	{
		private decimal _idVisitante;

		private string _nombreVisitante;

		private int? _idTipoIdentificacion;

		private string _identificacionVisitante;

		private string _huella;

		private byte[] _foto;

		private int _idEmpresaVisitante;

		private string _observacionesVisitante;

		private DateTime? _fechaUltimaGestion;

		private int? _usuarioUltimaGestion;

		private string _empresa;

		private string _direccion;

		private string _telefonos;

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string direccion
		{
			get
			{
				return this._direccion;
			}
			set
			{
				this.ReportPropertyChanging("direccion");
				this._direccion = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("direccion");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string empresa
		{
			get
			{
				return this._empresa;
			}
			set
			{
				this.ReportPropertyChanging("empresa");
				this._empresa = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("empresa");
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
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string huella
		{
			get
			{
				return this._huella;
			}
			set
			{
				this.ReportPropertyChanging("huella");
				this._huella = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("huella");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
		public int idEmpresaVisitante
		{
			get
			{
				return this._idEmpresaVisitante;
			}
			set
			{
				this.ReportPropertyChanging("idEmpresaVisitante");
				this._idEmpresaVisitante = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idEmpresaVisitante");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string identificacionVisitante
		{
			get
			{
				return this._identificacionVisitante;
			}
			set
			{
				this.ReportPropertyChanging("identificacionVisitante");
				this._identificacionVisitante = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("identificacionVisitante");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public int? idTipoIdentificacion
		{
			get
			{
				return this._idTipoIdentificacion;
			}
			set
			{
				this.ReportPropertyChanging("idTipoIdentificacion");
				this._idTipoIdentificacion = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idTipoIdentificacion");
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
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
		public string nombreVisitante
		{
			get
			{
				return this._nombreVisitante;
			}
			set
			{
				this.ReportPropertyChanging("nombreVisitante");
				this._nombreVisitante = StructuralObject.SetValidValue(value, false);
				this.ReportPropertyChanged("nombreVisitante");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string observacionesVisitante
		{
			get
			{
				return this._observacionesVisitante;
			}
			set
			{
				this.ReportPropertyChanging("observacionesVisitante");
				this._observacionesVisitante = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("observacionesVisitante");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string telefonos
		{
			get
			{
				return this._telefonos;
			}
			set
			{
				this.ReportPropertyChanging("telefonos");
				this._telefonos = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("telefonos");
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TVisitante_TEmpresaVisitante", "TEmpresaVisitante")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.TEmpresaVisitante TEmpresaVisitante
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpresaVisitante>("masterDBACModel.FK_TVisitante_TEmpresaVisitante", "TEmpresaVisitante").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpresaVisitante>("masterDBACModel.FK_TVisitante_TEmpresaVisitante", "TEmpresaVisitante").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpresaVisitante> TEmpresaVisitanteReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpresaVisitante>("masterDBACModel.FK_TVisitante_TEmpresaVisitante", "TEmpresaVisitante");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpresaVisitante>("masterDBACModel.FK_TVisitante_TEmpresaVisitante", "TEmpresaVisitante", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TVisitante_TTipoIdentificacion", "TTipoIdentificacion")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.TTipoIdentificacion TTipoIdentificacion
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoIdentificacion>("masterDBACModel.FK_TVisitante_TTipoIdentificacion", "TTipoIdentificacion").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoIdentificacion>("masterDBACModel.FK_TVisitante_TTipoIdentificacion", "TTipoIdentificacion").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoIdentificacion> TTipoIdentificacionReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoIdentificacion>("masterDBACModel.FK_TVisitante_TTipoIdentificacion", "TTipoIdentificacion");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoIdentificacion>("masterDBACModel.FK_TVisitante_TTipoIdentificacion", "TTipoIdentificacion", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TVisitanteVisitaProgramada_TVisitante", "TVisitanteVisitaProgramada")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramada> TVisitanteVisitaProgramada
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramada>("masterDBACModel.FK_TVisitanteVisitaProgramada_TVisitante", "TVisitanteVisitaProgramada");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramada>("masterDBACModel.FK_TVisitanteVisitaProgramada_TVisitante", "TVisitanteVisitaProgramada", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TVisitanteVisitaProgramadaLog_TVisitante", "TVisitanteVisitaProgramadaLog")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramadaLog> TVisitanteVisitaProgramadaLog
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramadaLog>("masterDBACModel.FK_TVisitanteVisitaProgramadaLog_TVisitante", "TVisitanteVisitaProgramadaLog");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramadaLog>("masterDBACModel.FK_TVisitanteVisitaProgramadaLog_TVisitante", "TVisitanteVisitaProgramadaLog", value);
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

		public TVisitante()
		{
		}

		public static TVisitante CreateTVisitante(decimal idVisitante, string nombreVisitante, int idEmpresaVisitante)
		{
			TVisitante tVisitante = new TVisitante()
			{
				idVisitante = idVisitante,
				nombreVisitante = nombreVisitante,
				idEmpresaVisitante = idEmpresaVisitante
			};
			return tVisitante;
		}
	}
}