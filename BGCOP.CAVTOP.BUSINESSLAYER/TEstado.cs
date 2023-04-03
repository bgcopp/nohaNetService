using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TEstado")]
	[Serializable]
	public class TEstado : EntityObject
	{
		private int _idTipoEstado;

		private string _NombreEstado;

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
		public int idTipoEstado
		{
			get
			{
				return this._idTipoEstado;
			}
			set
			{
				if (this._idTipoEstado != value)
				{
					this.ReportPropertyChanging("idTipoEstado");
					this._idTipoEstado = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idTipoEstado");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string NombreEstado
		{
			get
			{
				return this._NombreEstado;
			}
			set
			{
				this.ReportPropertyChanging("NombreEstado");
				this._NombreEstado = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("NombreEstado");
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TEmpleado_TEstado", "TEmpleado")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado> TEmpleado
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado>("masterDBACModel.FK_TEmpleado_TEstado", "TEmpleado");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado>("masterDBACModel.FK_TEmpleado_TEstado", "TEmpleado", value);
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

		public TEstado()
		{
		}

		public static TEstado CreateTEstado(int idTipoEstado)
		{
			return new TEstado()
			{
				idTipoEstado = idTipoEstado
			};
		}
	}
}