using System;
using System.ComponentModel;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TVehiculo")]
	[Serializable]
	public class TVehiculo : EntityObject
	{
		private int _idVehiculo;

		private string _Placa;

		private short? _idModeloVehiculo;

		private string _CodigodeBarras;

		private DateTime? _fechaUltimaGestion;

		private int? _usuarioUltimaGestion;

		private string _color;

		private bool? _estaOcupado;

		private DateTime? _fechaUltOcup;

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
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public bool? estaOcupado
		{
			get
			{
				return this._estaOcupado;
			}
			set
			{
				this.ReportPropertyChanging("estaOcupado");
				this._estaOcupado = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("estaOcupado");
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
		public DateTime? fechaUltOcup
		{
			get
			{
				return this._fechaUltOcup;
			}
			set
			{
				this.ReportPropertyChanging("fechaUltOcup");
				this._fechaUltOcup = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("fechaUltOcup");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public short? idModeloVehiculo
		{
			get
			{
				return this._idModeloVehiculo;
			}
			set
			{
				this.ReportPropertyChanging("idModeloVehiculo");
				this._idModeloVehiculo = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idModeloVehiculo");
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
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TEmpleadoVehiculo_TVehiculo", "TEmpleadoVehiculo")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleadoVehiculo> TEmpleadoVehiculo
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleadoVehiculo>("masterDBACModel.FK_TEmpleadoVehiculo_TVehiculo", "TEmpleadoVehiculo");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleadoVehiculo>("masterDBACModel.FK_TEmpleadoVehiculo_TVehiculo", "TEmpleadoVehiculo", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TVehiculo_TModeloVehiculo", "TModeloVehiculo")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.TModeloVehiculo TModeloVehiculo
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TModeloVehiculo>("masterDBACModel.FK_TVehiculo_TModeloVehiculo", "TModeloVehiculo").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TModeloVehiculo>("masterDBACModel.FK_TVehiculo_TModeloVehiculo", "TModeloVehiculo").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.TModeloVehiculo> TModeloVehiculoReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TModeloVehiculo>("masterDBACModel.FK_TVehiculo_TModeloVehiculo", "TModeloVehiculo");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TModeloVehiculo>("masterDBACModel.FK_TVehiculo_TModeloVehiculo", "TModeloVehiculo", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TRegistroVehiculo_TVehiculo", "TRegistroVehiculo")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TRegistroVehiculo> TRegistroVehiculo
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TRegistroVehiculo>("masterDBACModel.FK_TRegistroVehiculo_TVehiculo", "TRegistroVehiculo");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TRegistroVehiculo>("masterDBACModel.FK_TRegistroVehiculo_TVehiculo", "TRegistroVehiculo", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TvehiculoParqueo_TVehiculo", "TvehiculoParqueo")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TvehiculoParqueo> TvehiculoParqueo
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TvehiculoParqueo>("masterDBACModel.FK_TvehiculoParqueo_TVehiculo", "TvehiculoParqueo");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TvehiculoParqueo>("masterDBACModel.FK_TvehiculoParqueo_TVehiculo", "TvehiculoParqueo", value);
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

		public TVehiculo()
		{
		}

		public static TVehiculo CreateTVehiculo(int idVehiculo)
		{
			return new TVehiculo()
			{
				idVehiculo = idVehiculo
			};
		}
	}
}