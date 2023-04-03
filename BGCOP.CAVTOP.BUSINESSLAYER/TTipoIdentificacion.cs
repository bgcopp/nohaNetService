using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TTipoIdentificacion")]
	[Serializable]
	public class TTipoIdentificacion : EntityObject
	{
		private int _idTipoIdentificacion;

		private string _descripcionIdentificacion;

		private DateTime? _fechaUltimaGestion;

		private int? _usuarioUltimaGestion;

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string descripcionIdentificacion
		{
			get
			{
				return this._descripcionIdentificacion;
			}
			set
			{
				this.ReportPropertyChanging("descripcionIdentificacion");
				this._descripcionIdentificacion = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("descripcionIdentificacion");
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
		[EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
		public int idTipoIdentificacion
		{
			get
			{
				return this._idTipoIdentificacion;
			}
			set
			{
				if (this._idTipoIdentificacion != value)
				{
					this.ReportPropertyChanging("idTipoIdentificacion");
					this._idTipoIdentificacion = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idTipoIdentificacion");
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TEmpleado_TTipoIdentificacion", "TEmpleado")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado> TEmpleado
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado>("masterDBACModel.FK_TEmpleado_TTipoIdentificacion", "TEmpleado");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado>("masterDBACModel.FK_TEmpleado_TTipoIdentificacion", "TEmpleado", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TVisitante_TTipoIdentificacion", "TVisitante")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitante> TVisitante
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitante>("masterDBACModel.FK_TVisitante_TTipoIdentificacion", "TVisitante");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitante>("masterDBACModel.FK_TVisitante_TTipoIdentificacion", "TVisitante", value);
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

		public TTipoIdentificacion()
		{
		}

		public static TTipoIdentificacion CreateTTipoIdentificacion(int idTipoIdentificacion)
		{
			return new TTipoIdentificacion()
			{
				idTipoIdentificacion = idTipoIdentificacion
			};
		}
	}
}