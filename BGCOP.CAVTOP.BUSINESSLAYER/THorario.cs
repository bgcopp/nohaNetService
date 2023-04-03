using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="THorario")]
	[Serializable]
	public class THorario : EntityObject
	{
		private int _idHorario;

		private string _NombreHorario;

		private bool _esMaestro;

		private DateTime? _fechaInicio;

		private DateTime? _fechaFin;

		private string _ObservacionesHorario;

		private DateTime? _fechaUltimaGestion;

		private int? _usuarioUltimaGestion;

		private bool? _esPermanente;

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
		public bool esMaestro
		{
			get
			{
				return this._esMaestro;
			}
			set
			{
				this.ReportPropertyChanging("esMaestro");
				this._esMaestro = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("esMaestro");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public bool? esPermanente
		{
			get
			{
				return this._esPermanente;
			}
			set
			{
				this.ReportPropertyChanging("esPermanente");
				this._esPermanente = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("esPermanente");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public DateTime? fechaFin
		{
			get
			{
				return this._fechaFin;
			}
			set
			{
				this.ReportPropertyChanging("fechaFin");
				this._fechaFin = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("fechaFin");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public DateTime? fechaInicio
		{
			get
			{
				return this._fechaInicio;
			}
			set
			{
				this.ReportPropertyChanging("fechaInicio");
				this._fechaInicio = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("fechaInicio");
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
		public int idHorario
		{
			get
			{
				return this._idHorario;
			}
			set
			{
				if (this._idHorario != value)
				{
					this.ReportPropertyChanging("idHorario");
					this._idHorario = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idHorario");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string NombreHorario
		{
			get
			{
				return this._NombreHorario;
			}
			set
			{
				this.ReportPropertyChanging("NombreHorario");
				this._NombreHorario = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("NombreHorario");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string ObservacionesHorario
		{
			get
			{
				return this._ObservacionesHorario;
			}
			set
			{
				this.ReportPropertyChanging("ObservacionesHorario");
				this._ObservacionesHorario = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("ObservacionesHorario");
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TDiasHorario_THorario", "TDiasHorario")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TDiasHorario> TDiasHorario
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TDiasHorario>("masterDBACModel.FK_TDiasHorario_THorario", "TDiasHorario");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TDiasHorario>("masterDBACModel.FK_TDiasHorario_THorario", "TDiasHorario", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TEmpleado_THorario", "TEmpleado")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado> TEmpleado
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado>("masterDBACModel.FK_TEmpleado_THorario", "TEmpleado");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado>("masterDBACModel.FK_TEmpleado_THorario", "TEmpleado", value);
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

		public THorario()
		{
		}

		public static THorario CreateTHorario(int idHorario, bool esMaestro)
		{
			return new THorario()
			{
				idHorario = idHorario,
				esMaestro = esMaestro
			};
		}
	}
}