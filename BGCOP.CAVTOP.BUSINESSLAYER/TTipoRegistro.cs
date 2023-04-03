using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TTipoRegistro")]
	[Serializable]
	public class TTipoRegistro : EntityObject
	{
		private int _idTipoRegistro;

		private string _TipoRegistro;

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
		public int idTipoRegistro
		{
			get
			{
				return this._idTipoRegistro;
			}
			set
			{
				if (this._idTipoRegistro != value)
				{
					this.ReportPropertyChanging("idTipoRegistro");
					this._idTipoRegistro = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idTipoRegistro");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string TipoRegistro
		{
			get
			{
				return this._TipoRegistro;
			}
			set
			{
				this.ReportPropertyChanging("TipoRegistro");
				this._TipoRegistro = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("TipoRegistro");
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TRegistroEmpleado_TTipoRegistro", "TRegistroEmpleado")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TRegistroEmpleado> TRegistroEmpleado
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TRegistroEmpleado>("masterDBACModel.FK_TRegistroEmpleado_TTipoRegistro", "TRegistroEmpleado");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TRegistroEmpleado>("masterDBACModel.FK_TRegistroEmpleado_TTipoRegistro", "TRegistroEmpleado", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TRegistroVehiculo_TTipoRegistro", "TRegistroVehiculo")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TRegistroVehiculo> TRegistroVehiculo
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TRegistroVehiculo>("masterDBACModel.FK_TRegistroVehiculo_TTipoRegistro", "TRegistroVehiculo");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TRegistroVehiculo>("masterDBACModel.FK_TRegistroVehiculo_TTipoRegistro", "TRegistroVehiculo", value);
				}
			}
		}

		public TTipoRegistro()
		{
		}

		public static TTipoRegistro CreateTTipoRegistro(int idTipoRegistro)
		{
			return new TTipoRegistro()
			{
				idTipoRegistro = idTipoRegistro
			};
		}
	}
}