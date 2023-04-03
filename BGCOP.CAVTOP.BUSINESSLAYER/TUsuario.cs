using System;
using System.ComponentModel;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TUsuario")]
	[Serializable]
	public class TUsuario : EntityObject
	{
		private int _idUsuario;

		private string _nombre;

		private string _login;

		private byte[] _password;

		private int? _idTipoUsuario;

		private DateTime? _fechaUltimaGestion;

		private int? _usuarioUltimaGestion;

		private byte[] _fotoUsuario;

		private short? _activo;

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public short? activo
		{
			get
			{
				return this._activo;
			}
			set
			{
				this.ReportPropertyChanging("activo");
				this._activo = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("activo");
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
		public byte[] fotoUsuario
		{
			get
			{
				return StructuralObject.GetValidValue(this._fotoUsuario);
			}
			set
			{
				this.ReportPropertyChanging("fotoUsuario");
				this._fotoUsuario = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("fotoUsuario");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public int? idTipoUsuario
		{
			get
			{
				return this._idTipoUsuario;
			}
			set
			{
				this.ReportPropertyChanging("idTipoUsuario");
				this._idTipoUsuario = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idTipoUsuario");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
		public int idUsuario
		{
			get
			{
				return this._idUsuario;
			}
			set
			{
				if (this._idUsuario != value)
				{
					this.ReportPropertyChanging("idUsuario");
					this._idUsuario = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idUsuario");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string login
		{
			get
			{
				return this._login;
			}
			set
			{
				this.ReportPropertyChanging("login");
				this._login = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("login");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				this.ReportPropertyChanging("nombre");
				this._nombre = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("nombre");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public byte[] password
		{
			get
			{
				return StructuralObject.GetValidValue(this._password);
			}
			set
			{
				this.ReportPropertyChanging("password");
				this._password = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("password");
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TUsuario_TTipoUsuario", "TTipoUsuario")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.TTipoUsuario TTipoUsuario
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoUsuario>("masterDBACModel.FK_TUsuario_TTipoUsuario", "TTipoUsuario").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoUsuario>("masterDBACModel.FK_TUsuario_TTipoUsuario", "TTipoUsuario").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoUsuario> TTipoUsuarioReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoUsuario>("masterDBACModel.FK_TUsuario_TTipoUsuario", "TTipoUsuario");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoUsuario>("masterDBACModel.FK_TUsuario_TTipoUsuario", "TTipoUsuario", value);
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

		public TUsuario()
		{
		}

		public static TUsuario CreateTUsuario(int idUsuario)
		{
			return new TUsuario()
			{
				idUsuario = idUsuario
			};
		}
	}
}