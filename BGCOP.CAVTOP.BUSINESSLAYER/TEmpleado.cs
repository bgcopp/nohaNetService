using System;
using System.ComponentModel;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TEmpleado")]
	[Serializable]
	public class TEmpleado : EntityObject
	{
		private int _idEmpleado;

		private string _nombre;

		private int? _idTipoIdentificacion;

		private string _identificacion;

		private string _Notarjeta;

		private byte[] _foto;

		private int? _idCargo;

		private int _idTipoEstado;

		private int _idEmpresa;

		private int _idDivisionEmpresa;

		private int? _idHorario;

		private string _observaciones;

		private DateTime? _fechaUltimaGestion;

		private int? _usuarioUltimaGestion;

		private string _usuarioHuella;

		private int? _idTarjeta;

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
		public int? idCargo
		{
			get
			{
				return this._idCargo;
			}
			set
			{
				this.ReportPropertyChanging("idCargo");
				this._idCargo = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idCargo");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
		public int idDivisionEmpresa
		{
			get
			{
				return this._idDivisionEmpresa;
			}
			set
			{
				this.ReportPropertyChanging("idDivisionEmpresa");
				this._idDivisionEmpresa = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idDivisionEmpresa");
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
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
		public int idEmpresa
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
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public int? idHorario
		{
			get
			{
				return this._idHorario;
			}
			set
			{
				this.ReportPropertyChanging("idHorario");
				this._idHorario = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idHorario");
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
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
		public int idTipoEstado
		{
			get
			{
				return this._idTipoEstado;
			}
			set
			{
				this.ReportPropertyChanging("idTipoEstado");
				this._idTipoEstado = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idTipoEstado");
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
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				this.ReportPropertyChanging("nombre");
				this._nombre = StructuralObject.SetValidValue(value, false);
				this.ReportPropertyChanged("nombre");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string Notarjeta
		{
			get
			{
				return this._Notarjeta;
			}
			set
			{
				this.ReportPropertyChanging("Notarjeta");
				this._Notarjeta = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("Notarjeta");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string observaciones
		{
			get
			{
				return this._observaciones;
			}
			set
			{
				this.ReportPropertyChanging("observaciones");
				this._observaciones = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("observaciones");
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TEmpleado_TCargo", "TCargo")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.TCargo TCargo
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TCargo>("masterDBACModel.FK_TEmpleado_TCargo", "TCargo").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TCargo>("masterDBACModel.FK_TEmpleado_TCargo", "TCargo").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.TCargo> TCargoReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TCargo>("masterDBACModel.FK_TEmpleado_TCargo", "TCargo");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TCargo>("masterDBACModel.FK_TEmpleado_TCargo", "TCargo", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TEmpleado_TDivisionEmpresa", "TDivisionEmpresa")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.TDivisionEmpresa TDivisionEmpresa
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TDivisionEmpresa>("masterDBACModel.FK_TEmpleado_TDivisionEmpresa", "TDivisionEmpresa").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TDivisionEmpresa>("masterDBACModel.FK_TEmpleado_TDivisionEmpresa", "TDivisionEmpresa").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.TDivisionEmpresa> TDivisionEmpresaReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TDivisionEmpresa>("masterDBACModel.FK_TEmpleado_TDivisionEmpresa", "TDivisionEmpresa");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TDivisionEmpresa>("masterDBACModel.FK_TEmpleado_TDivisionEmpresa", "TDivisionEmpresa", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TEmpleadoVehiculo_TEmpleado", "TEmpleadoVehiculo")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleadoVehiculo> TEmpleadoVehiculo
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleadoVehiculo>("masterDBACModel.FK_TEmpleadoVehiculo_TEmpleado", "TEmpleadoVehiculo");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleadoVehiculo>("masterDBACModel.FK_TEmpleadoVehiculo_TEmpleado", "TEmpleadoVehiculo", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TEmpleado_TEstado", "TEstado")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.TEstado TEstado
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEstado>("masterDBACModel.FK_TEmpleado_TEstado", "TEstado").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEstado>("masterDBACModel.FK_TEmpleado_TEstado", "TEstado").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.TEstado> TEstadoReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEstado>("masterDBACModel.FK_TEmpleado_TEstado", "TEstado");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEstado>("masterDBACModel.FK_TEmpleado_TEstado", "TEstado", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TEmpleado_THorario", "THorario")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.THorario THorario
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.THorario>("masterDBACModel.FK_TEmpleado_THorario", "THorario").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.THorario>("masterDBACModel.FK_TEmpleado_THorario", "THorario").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.THorario> THorarioReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.THorario>("masterDBACModel.FK_TEmpleado_THorario", "THorario");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.THorario>("masterDBACModel.FK_TEmpleado_THorario", "THorario", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TRegistroEmpleado_TEmpleado", "TRegistroEmpleado")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TRegistroEmpleado> TRegistroEmpleado
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TRegistroEmpleado>("masterDBACModel.FK_TRegistroEmpleado_TEmpleado", "TRegistroEmpleado");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TRegistroEmpleado>("masterDBACModel.FK_TRegistroEmpleado_TEmpleado", "TRegistroEmpleado", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TEmpleado_TTipoIdentificacion", "TTipoIdentificacion")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.TTipoIdentificacion TTipoIdentificacion
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoIdentificacion>("masterDBACModel.FK_TEmpleado_TTipoIdentificacion", "TTipoIdentificacion").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoIdentificacion>("masterDBACModel.FK_TEmpleado_TTipoIdentificacion", "TTipoIdentificacion").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoIdentificacion> TTipoIdentificacionReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoIdentificacion>("masterDBACModel.FK_TEmpleado_TTipoIdentificacion", "TTipoIdentificacion");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoIdentificacion>("masterDBACModel.FK_TEmpleado_TTipoIdentificacion", "TTipoIdentificacion", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TVisitanteVisitaProgramada_TEmpleado", "TVisitanteVisitaProgramada")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramada> TVisitanteVisitaProgramada
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramada>("masterDBACModel.FK_TVisitanteVisitaProgramada_TEmpleado", "TVisitanteVisitaProgramada");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramada>("masterDBACModel.FK_TVisitanteVisitaProgramada_TEmpleado", "TVisitanteVisitaProgramada", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TVisitanteVisitaProgramadaLog_TEmpleado", "TVisitanteVisitaProgramadaLog")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramadaLog> TVisitanteVisitaProgramadaLog
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramadaLog>("masterDBACModel.FK_TVisitanteVisitaProgramadaLog_TEmpleado", "TVisitanteVisitaProgramadaLog");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramadaLog>("masterDBACModel.FK_TVisitanteVisitaProgramadaLog_TEmpleado", "TVisitanteVisitaProgramadaLog", value);
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string usuarioHuella
		{
			get
			{
				return this._usuarioHuella;
			}
			set
			{
				this.ReportPropertyChanging("usuarioHuella");
				this._usuarioHuella = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("usuarioHuella");
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

		public TEmpleado()
		{
		}

		public static TEmpleado CreateTEmpleado(int idEmpleado, string nombre, int idTipoEstado, int idEmpresa, int idDivisionEmpresa)
		{
			TEmpleado tEmpleado = new TEmpleado()
			{
				idEmpleado = idEmpleado,
				nombre = nombre,
				idTipoEstado = idTipoEstado,
				idEmpresa = idEmpresa,
				idDivisionEmpresa = idDivisionEmpresa
			};
			return tEmpleado;
		}
	}
}