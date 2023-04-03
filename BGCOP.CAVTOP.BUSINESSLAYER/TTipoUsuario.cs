using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TTipoUsuario")]
	[Serializable]
	public class TTipoUsuario : EntityObject
	{
		private int _idTipoUsuario;

		private string _NombreTipoUsuario;

		private string _permisos;

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
		public int idTipoUsuario
		{
			get
			{
				return this._idTipoUsuario;
			}
			set
			{
				if (this._idTipoUsuario != value)
				{
					this.ReportPropertyChanging("idTipoUsuario");
					this._idTipoUsuario = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idTipoUsuario");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string NombreTipoUsuario
		{
			get
			{
				return this._NombreTipoUsuario;
			}
			set
			{
				this.ReportPropertyChanging("NombreTipoUsuario");
				this._NombreTipoUsuario = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("NombreTipoUsuario");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
		public string permisos
		{
			get
			{
				return this._permisos;
			}
			set
			{
				this.ReportPropertyChanging("permisos");
				this._permisos = StructuralObject.SetValidValue(value, false);
				this.ReportPropertyChanged("permisos");
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TUsuario_TTipoUsuario", "TUsuario")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TUsuario> TUsuario
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TUsuario>("masterDBACModel.FK_TUsuario_TTipoUsuario", "TUsuario");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TUsuario>("masterDBACModel.FK_TUsuario_TTipoUsuario", "TUsuario", value);
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

		public TTipoUsuario()
		{
		}

		public static TTipoUsuario CreateTTipoUsuario(int idTipoUsuario, string permisos)
		{
			return new TTipoUsuario()
			{
				idTipoUsuario = idTipoUsuario,
				permisos = permisos
			};
		}
	}
}