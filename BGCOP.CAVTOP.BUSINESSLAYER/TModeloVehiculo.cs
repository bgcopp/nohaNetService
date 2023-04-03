using System;
using System.ComponentModel;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TModeloVehiculo")]
	[Serializable]
	public class TModeloVehiculo : EntityObject
	{
		private short _idModeloVehiculo;

		private short? _idMarcaVehiculo;

		private string _NombreModelo;

		private byte? _idTipoVehiculo;

		private DateTime? _fechaUltimaGestion;

		private int? _usuarioUltimaGestion;

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
		public short? idMarcaVehiculo
		{
			get
			{
				return this._idMarcaVehiculo;
			}
			set
			{
				this.ReportPropertyChanging("idMarcaVehiculo");
				this._idMarcaVehiculo = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idMarcaVehiculo");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
		public short idModeloVehiculo
		{
			get
			{
				return this._idModeloVehiculo;
			}
			set
			{
				if (this._idModeloVehiculo != value)
				{
					this.ReportPropertyChanging("idModeloVehiculo");
					this._idModeloVehiculo = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idModeloVehiculo");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public byte? idTipoVehiculo
		{
			get
			{
				return this._idTipoVehiculo;
			}
			set
			{
				this.ReportPropertyChanging("idTipoVehiculo");
				this._idTipoVehiculo = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idTipoVehiculo");
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
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TModeloVehiculo_TipoVehiculo", "TipoVehiculo")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.TipoVehiculo TipoVehiculo
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TipoVehiculo>("masterDBACModel.FK_TModeloVehiculo_TipoVehiculo", "TipoVehiculo").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TipoVehiculo>("masterDBACModel.FK_TModeloVehiculo_TipoVehiculo", "TipoVehiculo").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.TipoVehiculo> TipoVehiculoReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TipoVehiculo>("masterDBACModel.FK_TModeloVehiculo_TipoVehiculo", "TipoVehiculo");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TipoVehiculo>("masterDBACModel.FK_TModeloVehiculo_TipoVehiculo", "TipoVehiculo", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TModeloVehiculo_MarcaVehiculo", "TMarcaVehiculo")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.TMarcaVehiculo TMarcaVehiculo
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TMarcaVehiculo>("masterDBACModel.FK_TModeloVehiculo_MarcaVehiculo", "TMarcaVehiculo").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TMarcaVehiculo>("masterDBACModel.FK_TModeloVehiculo_MarcaVehiculo", "TMarcaVehiculo").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.TMarcaVehiculo> TMarcaVehiculoReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TMarcaVehiculo>("masterDBACModel.FK_TModeloVehiculo_MarcaVehiculo", "TMarcaVehiculo");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TMarcaVehiculo>("masterDBACModel.FK_TModeloVehiculo_MarcaVehiculo", "TMarcaVehiculo", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TVehiculo_TModeloVehiculo", "TVehiculo")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo> TVehiculo
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo>("masterDBACModel.FK_TVehiculo_TModeloVehiculo", "TVehiculo");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo>("masterDBACModel.FK_TVehiculo_TModeloVehiculo", "TVehiculo", value);
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

		public TModeloVehiculo()
		{
		}

		public static TModeloVehiculo CreateTModeloVehiculo(short idModeloVehiculo)
		{
			return new TModeloVehiculo()
			{
				idModeloVehiculo = idModeloVehiculo
			};
		}
	}
}