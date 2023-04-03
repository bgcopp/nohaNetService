using System;
using System.ComponentModel;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TDivisionEmpresa")]
	[Serializable]
	public class TDivisionEmpresa : EntityObject
	{
		private int _IdDivisionEmpresa;

		private int? _IdEmpresa;

		private string _NombreDivision;

		private DateTime? _fechaUltimaGestion;

		private int? _usuarioUltimaGestion;

		private string _piso;

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
		public int IdDivisionEmpresa
		{
			get
			{
				return this._IdDivisionEmpresa;
			}
			set
			{
				if (this._IdDivisionEmpresa != value)
				{
					this.ReportPropertyChanging("IdDivisionEmpresa");
					this._IdDivisionEmpresa = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("IdDivisionEmpresa");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public int? IdEmpresa
		{
			get
			{
				return this._IdEmpresa;
			}
			set
			{
				this.ReportPropertyChanging("IdEmpresa");
				this._IdEmpresa = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("IdEmpresa");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string NombreDivision
		{
			get
			{
				return this._NombreDivision;
			}
			set
			{
				this.ReportPropertyChanging("NombreDivision");
				this._NombreDivision = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("NombreDivision");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string piso
		{
			get
			{
				return this._piso;
			}
			set
			{
				this.ReportPropertyChanging("piso");
				this._piso = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("piso");
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TEmpleado_TDivisionEmpresa", "TEmpleado")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado> TEmpleado
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado>("masterDBACModel.FK_TEmpleado_TDivisionEmpresa", "TEmpleado");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado>("masterDBACModel.FK_TEmpleado_TDivisionEmpresa", "TEmpleado", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TDivisionEmpresa_TEmpresa", "TEmpresa")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.TEmpresa TEmpresa
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpresa>("masterDBACModel.FK_TDivisionEmpresa_TEmpresa", "TEmpresa").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpresa>("masterDBACModel.FK_TDivisionEmpresa_TEmpresa", "TEmpresa").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpresa> TEmpresaReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpresa>("masterDBACModel.FK_TDivisionEmpresa_TEmpresa", "TEmpresa");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpresa>("masterDBACModel.FK_TDivisionEmpresa_TEmpresa", "TEmpresa", value);
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

		public TDivisionEmpresa()
		{
		}

		public static TDivisionEmpresa CreateTDivisionEmpresa(int idDivisionEmpresa)
		{
			return new TDivisionEmpresa()
			{
				IdDivisionEmpresa = idDivisionEmpresa
			};
		}
	}
}