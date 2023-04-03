using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TMarcaVehiculo")]
	[Serializable]
	public class TMarcaVehiculo : EntityObject
	{
		private short _idMarcaVehiculo;

		private string _NombreMarcaVehiculo;

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
		public short idMarcaVehiculo
		{
			get
			{
				return this._idMarcaVehiculo;
			}
			set
			{
				if (this._idMarcaVehiculo != value)
				{
					this.ReportPropertyChanging("idMarcaVehiculo");
					this._idMarcaVehiculo = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idMarcaVehiculo");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string NombreMarcaVehiculo
		{
			get
			{
				return this._NombreMarcaVehiculo;
			}
			set
			{
				this.ReportPropertyChanging("NombreMarcaVehiculo");
				this._NombreMarcaVehiculo = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("NombreMarcaVehiculo");
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TModeloVehiculo_MarcaVehiculo", "TModeloVehiculo")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TModeloVehiculo> TModeloVehiculo
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TModeloVehiculo>("masterDBACModel.FK_TModeloVehiculo_MarcaVehiculo", "TModeloVehiculo");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TModeloVehiculo>("masterDBACModel.FK_TModeloVehiculo_MarcaVehiculo", "TModeloVehiculo", value);
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

		public TMarcaVehiculo()
		{
		}

		public static TMarcaVehiculo CreateTMarcaVehiculo(short idMarcaVehiculo)
		{
			return new TMarcaVehiculo()
			{
				idMarcaVehiculo = idMarcaVehiculo
			};
		}
	}
}