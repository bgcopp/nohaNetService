using System;
using System.ComponentModel;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TRegistroVehiculo")]
	[Serializable]
	public class TRegistroVehiculo : EntityObject
	{
		private int _idRegistroVehiculo;

		private int? _idVehiculo;

		private DateTime? _fechadeRegistro;

		private int? _idPanel;

		private int? _idTipoRegistro;

		private string _descripcionRegistro;

		private string _ObservacionesRegistro;

		private DateTime? _fechaUltimaGestion;

		private int? _usuarioUltimaGestion;

		private int? _idempleado;

		private string _mregistro;

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string descripcionRegistro
		{
			get
			{
				return this._descripcionRegistro;
			}
			set
			{
				this.ReportPropertyChanging("descripcionRegistro");
				this._descripcionRegistro = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("descripcionRegistro");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public DateTime? fechadeRegistro
		{
			get
			{
				return this._fechadeRegistro;
			}
			set
			{
				this.ReportPropertyChanging("fechadeRegistro");
				this._fechadeRegistro = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("fechadeRegistro");
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
		public int? idempleado
		{
			get
			{
				return this._idempleado;
			}
			set
			{
				this.ReportPropertyChanging("idempleado");
				this._idempleado = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idempleado");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public int? idPanel
		{
			get
			{
				return this._idPanel;
			}
			set
			{
				this.ReportPropertyChanging("idPanel");
				this._idPanel = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idPanel");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
		public int idRegistroVehiculo
		{
			get
			{
				return this._idRegistroVehiculo;
			}
			set
			{
				if (this._idRegistroVehiculo != value)
				{
					this.ReportPropertyChanging("idRegistroVehiculo");
					this._idRegistroVehiculo = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idRegistroVehiculo");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public int? idTipoRegistro
		{
			get
			{
				return this._idTipoRegistro;
			}
			set
			{
				this.ReportPropertyChanging("idTipoRegistro");
				this._idTipoRegistro = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idTipoRegistro");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public int? idVehiculo
		{
			get
			{
				return this._idVehiculo;
			}
			set
			{
				this.ReportPropertyChanging("idVehiculo");
				this._idVehiculo = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idVehiculo");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string mregistro
		{
			get
			{
				return this._mregistro;
			}
			set
			{
				this.ReportPropertyChanging("mregistro");
				this._mregistro = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("mregistro");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string ObservacionesRegistro
		{
			get
			{
				return this._ObservacionesRegistro;
			}
			set
			{
				this.ReportPropertyChanging("ObservacionesRegistro");
				this._ObservacionesRegistro = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("ObservacionesRegistro");
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TRegistroVehiculo_TTipoRegistro", "TTipoRegistro")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.TTipoRegistro TTipoRegistro
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoRegistro>("masterDBACModel.FK_TRegistroVehiculo_TTipoRegistro", "TTipoRegistro").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoRegistro>("masterDBACModel.FK_TRegistroVehiculo_TTipoRegistro", "TTipoRegistro").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoRegistro> TTipoRegistroReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoRegistro>("masterDBACModel.FK_TRegistroVehiculo_TTipoRegistro", "TTipoRegistro");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoRegistro>("masterDBACModel.FK_TRegistroVehiculo_TTipoRegistro", "TTipoRegistro", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TRegistroVehiculo_TVehiculo", "TVehiculo")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo TVehiculo
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo>("masterDBACModel.FK_TRegistroVehiculo_TVehiculo", "TVehiculo").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo>("masterDBACModel.FK_TRegistroVehiculo_TVehiculo", "TVehiculo").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo> TVehiculoReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo>("masterDBACModel.FK_TRegistroVehiculo_TVehiculo", "TVehiculo");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo>("masterDBACModel.FK_TRegistroVehiculo_TVehiculo", "TVehiculo", value);
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

		public TRegistroVehiculo()
		{
		}

		public static TRegistroVehiculo CreateTRegistroVehiculo(int idRegistroVehiculo)
		{
			return new TRegistroVehiculo()
			{
				idRegistroVehiculo = idRegistroVehiculo
			};
		}
	}
}