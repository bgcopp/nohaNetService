using System;
using System.ComponentModel;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TEmpleadoVehiculo")]
	[Serializable]
	public class TEmpleadoVehiculo : EntityObject
	{
		private int _IdEmpleado;

		private int _IdVehiculo;

		private DateTime? _fechaUltimaGestion;

		private int? _usuarioUltimaGestion;

		private int _id;

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
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if (this._id != value)
				{
					this.ReportPropertyChanging("id");
					this._id = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("id");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
		public int IdEmpleado
		{
			get
			{
				return this._IdEmpleado;
			}
			set
			{
				this.ReportPropertyChanging("IdEmpleado");
				this._IdEmpleado = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("IdEmpleado");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
		public int IdVehiculo
		{
			get
			{
				return this._IdVehiculo;
			}
			set
			{
				this.ReportPropertyChanging("IdVehiculo");
				this._IdVehiculo = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("IdVehiculo");
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TEmpleadoVehiculo_TEmpleado", "TEmpleado")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado TEmpleado
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado>("masterDBACModel.FK_TEmpleadoVehiculo_TEmpleado", "TEmpleado").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado>("masterDBACModel.FK_TEmpleadoVehiculo_TEmpleado", "TEmpleado").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado> TEmpleadoReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado>("masterDBACModel.FK_TEmpleadoVehiculo_TEmpleado", "TEmpleado");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado>("masterDBACModel.FK_TEmpleadoVehiculo_TEmpleado", "TEmpleado", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TEmpleadoVehiculo_TVehiculo", "TVehiculo")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo TVehiculo
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo>("masterDBACModel.FK_TEmpleadoVehiculo_TVehiculo", "TVehiculo").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo>("masterDBACModel.FK_TEmpleadoVehiculo_TVehiculo", "TVehiculo").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo> TVehiculoReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo>("masterDBACModel.FK_TEmpleadoVehiculo_TVehiculo", "TVehiculo");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo>("masterDBACModel.FK_TEmpleadoVehiculo_TVehiculo", "TVehiculo", value);
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

		public TEmpleadoVehiculo()
		{
		}

		public static TEmpleadoVehiculo CreateTEmpleadoVehiculo(int idEmpleado, int idVehiculo, int id)
		{
			TEmpleadoVehiculo tEmpleadoVehiculo = new TEmpleadoVehiculo()
			{
				IdEmpleado = idEmpleado,
				IdVehiculo = idVehiculo,
				id = id
			};
			return tEmpleadoVehiculo;
		}
	}
}