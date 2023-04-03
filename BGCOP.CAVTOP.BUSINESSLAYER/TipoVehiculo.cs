using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TipoVehiculo")]
	[Serializable]
	public class TipoVehiculo : EntityObject
	{
		private byte _idTipoVehiculo;

		private string _NombreTipoVehiculo;

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
		[EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
		public byte idTipoVehiculo
		{
			get
			{
				return this._idTipoVehiculo;
			}
			set
			{
				if (this._idTipoVehiculo != value)
				{
					this.ReportPropertyChanging("idTipoVehiculo");
					this._idTipoVehiculo = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idTipoVehiculo");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string NombreTipoVehiculo
		{
			get
			{
				return this._NombreTipoVehiculo;
			}
			set
			{
				this.ReportPropertyChanging("NombreTipoVehiculo");
				this._NombreTipoVehiculo = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("NombreTipoVehiculo");
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TModeloVehiculo_TipoVehiculo", "TModeloVehiculo")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TModeloVehiculo> TModeloVehiculo
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TModeloVehiculo>("masterDBACModel.FK_TModeloVehiculo_TipoVehiculo", "TModeloVehiculo");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TModeloVehiculo>("masterDBACModel.FK_TModeloVehiculo_TipoVehiculo", "TModeloVehiculo", value);
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

		public TipoVehiculo()
		{
		}

		public static TipoVehiculo CreateTipoVehiculo(byte idTipoVehiculo)
		{
			return new TipoVehiculo()
			{
				idTipoVehiculo = idTipoVehiculo
			};
		}
	}
}