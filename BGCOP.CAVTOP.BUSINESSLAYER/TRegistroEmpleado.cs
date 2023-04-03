using System;
using System.ComponentModel;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TRegistroEmpleado")]
	[Serializable]
	public class TRegistroEmpleado : EntityObject
	{
		private decimal _idRegistroEmpleado;

		private int? _idEmpleado;

		private DateTime? _fechadeRegistro;

		private int? _idPanel;

		private int? _idTipoRegistro;

		private string _descripcionRegistro;

		private string _ObservacionesRegistro;

		private DateTime? _fechaUltimaGestion;

		private int? _usuarioUltimaGestion;

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string descripcionRegistro
		{
			get
			{
				return this._descripcionRegistro;
			}
			set
			{
				this.ReportPropertyChanging("descripcionRegistro");
				this._descripcionRegistro = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("descripcionRegistro");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public DateTime? fechadeRegistro
		{
			get
			{
				return this._fechadeRegistro;
			}
			set
			{
				this.ReportPropertyChanging("fechadeRegistro");
				this._fechadeRegistro = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("fechadeRegistro");
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
		public int? idEmpleado
		{
			get
			{
				return this._idEmpleado;
			}
			set
			{
				this.ReportPropertyChanging("idEmpleado");
				this._idEmpleado = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idEmpleado");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public int? idPanel
		{
			get
			{
				return this._idPanel;
			}
			set
			{
				this.ReportPropertyChanging("idPanel");
				this._idPanel = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idPanel");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
		public decimal idRegistroEmpleado
		{
			get
			{
				return this._idRegistroEmpleado;
			}
			set
			{
				if (this._idRegistroEmpleado != value)
				{
					this.ReportPropertyChanging("idRegistroEmpleado");
					this._idRegistroEmpleado = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idRegistroEmpleado");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public int? idTipoRegistro
		{
			get
			{
				return this._idTipoRegistro;
			}
			set
			{
				this.ReportPropertyChanging("idTipoRegistro");
				this._idTipoRegistro = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idTipoRegistro");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string ObservacionesRegistro
		{
			get
			{
				return this._ObservacionesRegistro;
			}
			set
			{
				this.ReportPropertyChanging("ObservacionesRegistro");
				this._ObservacionesRegistro = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("ObservacionesRegistro");
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TRegistroEmpleado_TEmpleado", "TEmpleado")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado TEmpleado
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado>("masterDBACModel.FK_TRegistroEmpleado_TEmpleado", "TEmpleado").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado>("masterDBACModel.FK_TRegistroEmpleado_TEmpleado", "TEmpleado").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado> TEmpleadoReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado>("masterDBACModel.FK_TRegistroEmpleado_TEmpleado", "TEmpleado");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado>("masterDBACModel.FK_TRegistroEmpleado_TEmpleado", "TEmpleado", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TRegistroEmpleado_TTipoRegistro", "TTipoRegistro")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.TTipoRegistro TTipoRegistro
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoRegistro>("masterDBACModel.FK_TRegistroEmpleado_TTipoRegistro", "TTipoRegistro").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoRegistro>("masterDBACModel.FK_TRegistroEmpleado_TTipoRegistro", "TTipoRegistro").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoRegistro> TTipoRegistroReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoRegistro>("masterDBACModel.FK_TRegistroEmpleado_TTipoRegistro", "TTipoRegistro");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TTipoRegistro>("masterDBACModel.FK_TRegistroEmpleado_TTipoRegistro", "TTipoRegistro", value);
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

		public TRegistroEmpleado()
		{
		}

		public static TRegistroEmpleado CreateTRegistroEmpleado(decimal idRegistroEmpleado)
		{
			return new TRegistroEmpleado()
			{
				idRegistroEmpleado = idRegistroEmpleado
			};
		}
	}
}