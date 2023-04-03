using System;
using System.ComponentModel;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TDiasHorario")]
	[Serializable]
	public class TDiasHorario : EntityObject
	{
		private int _idDiasHorario;

		private int? _idHorario;

		private byte? _dia;

		private string _entrada;

		private string _salida;

		private string _ObservacionesDia;

		private DateTime? _fechaUltimaGestion;

		private int? _usuarioUltimaGestion;

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public byte? dia
		{
			get
			{
				return this._dia;
			}
			set
			{
				this.ReportPropertyChanging("dia");
				this._dia = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("dia");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string entrada
		{
			get
			{
				return this._entrada;
			}
			set
			{
				this.ReportPropertyChanging("entrada");
				this._entrada = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("entrada");
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
		public int idDiasHorario
		{
			get
			{
				return this._idDiasHorario;
			}
			set
			{
				if (this._idDiasHorario != value)
				{
					this.ReportPropertyChanging("idDiasHorario");
					this._idDiasHorario = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idDiasHorario");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public int? idHorario
		{
			get
			{
				return this._idHorario;
			}
			set
			{
				this.ReportPropertyChanging("idHorario");
				this._idHorario = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idHorario");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string ObservacionesDia
		{
			get
			{
				return this._ObservacionesDia;
			}
			set
			{
				this.ReportPropertyChanging("ObservacionesDia");
				this._ObservacionesDia = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("ObservacionesDia");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string salida
		{
			get
			{
				return this._salida;
			}
			set
			{
				this.ReportPropertyChanging("salida");
				this._salida = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("salida");
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TDiasHorario_THorario", "THorario")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.THorario THorario
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.THorario>("masterDBACModel.FK_TDiasHorario_THorario", "THorario").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.THorario>("masterDBACModel.FK_TDiasHorario_THorario", "THorario").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.THorario> THorarioReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.THorario>("masterDBACModel.FK_TDiasHorario_THorario", "THorario");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.THorario>("masterDBACModel.FK_TDiasHorario_THorario", "THorario", value);
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

		public TDiasHorario()
		{
		}

		public static TDiasHorario CreateTDiasHorario(int idDiasHorario)
		{
			return new TDiasHorario()
			{
				idDiasHorario = idDiasHorario
			};
		}
	}
}