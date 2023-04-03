using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TEmpresa")]
	[Serializable]
	public class TEmpresa : EntityObject
	{
		private int _idEmpresa;

		private string _nit;

		private string _RazonSocial;

		private string _telefonos;

		private string _telContactoInterno;

		private string _EmpleadoContacto;

		private string _ObservacioneEmpresa;

		private DateTime? _fechaUltimaGestion;

		private int? _usuarioUltimaGestion;

		private string _CargoContacto;

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string CargoContacto
		{
			get
			{
				return this._CargoContacto;
			}
			set
			{
				this.ReportPropertyChanging("CargoContacto");
				this._CargoContacto = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("CargoContacto");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string EmpleadoContacto
		{
			get
			{
				return this._EmpleadoContacto;
			}
			set
			{
				this.ReportPropertyChanging("EmpleadoContacto");
				this._EmpleadoContacto = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("EmpleadoContacto");
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
		public int idEmpresa
		{
			get
			{
				return this._idEmpresa;
			}
			set
			{
				if (this._idEmpresa != value)
				{
					this.ReportPropertyChanging("idEmpresa");
					this._idEmpresa = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idEmpresa");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string nit
		{
			get
			{
				return this._nit;
			}
			set
			{
				this.ReportPropertyChanging("nit");
				this._nit = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("nit");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string ObservacioneEmpresa
		{
			get
			{
				return this._ObservacioneEmpresa;
			}
			set
			{
				this.ReportPropertyChanging("ObservacioneEmpresa");
				this._ObservacioneEmpresa = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("ObservacioneEmpresa");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string RazonSocial
		{
			get
			{
				return this._RazonSocial;
			}
			set
			{
				this.ReportPropertyChanging("RazonSocial");
				this._RazonSocial = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("RazonSocial");
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TDivisionEmpresa_TEmpresa", "TDivisionEmpresa")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TDivisionEmpresa> TDivisionEmpresa
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TDivisionEmpresa>("masterDBACModel.FK_TDivisionEmpresa_TEmpresa", "TDivisionEmpresa");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TDivisionEmpresa>("masterDBACModel.FK_TDivisionEmpresa_TEmpresa", "TDivisionEmpresa", value);
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string telContactoInterno
		{
			get
			{
				return this._telContactoInterno;
			}
			set
			{
				this.ReportPropertyChanging("telContactoInterno");
				this._telContactoInterno = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("telContactoInterno");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string telefonos
		{
			get
			{
				return this._telefonos;
			}
			set
			{
				this.ReportPropertyChanging("telefonos");
				this._telefonos = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("telefonos");
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

		public TEmpresa()
		{
		}

		public static TEmpresa CreateTEmpresa(int idEmpresa)
		{
			return new TEmpresa()
			{
				idEmpresa = idEmpresa
			};
		}
	}
}