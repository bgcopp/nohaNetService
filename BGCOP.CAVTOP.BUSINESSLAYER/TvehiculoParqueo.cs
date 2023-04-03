using System;
using System.ComponentModel;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TvehiculoParqueo")]
	[Serializable]
	public class TvehiculoParqueo : EntityObject
	{
		private int _idVehiculo;

		private int _idParqueadero;

		private byte _diaSemana;

		private string _ObservacionesVP;

		private bool? _dia1;

		private bool? _dia2;

		private bool? _dia3;

		private bool? _dia4;

		private bool? _dia5;

		private bool? _dia6;

		private bool? _dia7;

		private DateTime? _fechaUltimaGestion;

		private int? _usuarioUltimaGestion;

		private int _id;

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public bool? dia1
		{
			get
			{
				return this._dia1;
			}
			set
			{
				this.ReportPropertyChanging("dia1");
				this._dia1 = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("dia1");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public bool? dia2
		{
			get
			{
				return this._dia2;
			}
			set
			{
				this.ReportPropertyChanging("dia2");
				this._dia2 = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("dia2");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public bool? dia3
		{
			get
			{
				return this._dia3;
			}
			set
			{
				this.ReportPropertyChanging("dia3");
				this._dia3 = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("dia3");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public bool? dia4
		{
			get
			{
				return this._dia4;
			}
			set
			{
				this.ReportPropertyChanging("dia4");
				this._dia4 = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("dia4");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public bool? dia5
		{
			get
			{
				return this._dia5;
			}
			set
			{
				this.ReportPropertyChanging("dia5");
				this._dia5 = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("dia5");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public bool? dia6
		{
			get
			{
				return this._dia6;
			}
			set
			{
				this.ReportPropertyChanging("dia6");
				this._dia6 = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("dia6");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public bool? dia7
		{
			get
			{
				return this._dia7;
			}
			set
			{
				this.ReportPropertyChanging("dia7");
				this._dia7 = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("dia7");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
		public byte diaSemana
		{
			get
			{
				return this._diaSemana;
			}
			set
			{
				this.ReportPropertyChanging("diaSemana");
				this._diaSemana = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("diaSemana");
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
		public int idParqueadero
		{
			get
			{
				return this._idParqueadero;
			}
			set
			{
				this.ReportPropertyChanging("idParqueadero");
				this._idParqueadero = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idParqueadero");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
		public int idVehiculo
		{
			get
			{
				return this._idVehiculo;
			}
			set
			{
				this.ReportPropertyChanging("idVehiculo");
				this._idVehiculo = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("idVehiculo");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string ObservacionesVP
		{
			get
			{
				return this._ObservacionesVP;
			}
			set
			{
				this.ReportPropertyChanging("ObservacionesVP");
				this._ObservacionesVP = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("ObservacionesVP");
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TvehiculoParqueo_Tparqueo", "TParqueo")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.TParqueo TParqueo
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TParqueo>("masterDBACModel.FK_TvehiculoParqueo_Tparqueo", "TParqueo").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TParqueo>("masterDBACModel.FK_TvehiculoParqueo_Tparqueo", "TParqueo").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.TParqueo> TParqueoReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TParqueo>("masterDBACModel.FK_TvehiculoParqueo_Tparqueo", "TParqueo");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TParqueo>("masterDBACModel.FK_TvehiculoParqueo_Tparqueo", "TParqueo", value);
				}
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TvehiculoParqueo_TVehiculo", "TVehiculo")]
		[SoapIgnore]
		[XmlIgnore]
		public BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo TVehiculo
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo>("masterDBACModel.FK_TvehiculoParqueo_TVehiculo", "TVehiculo").Value;
			}
			set
			{
				((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo>("masterDBACModel.FK_TvehiculoParqueo_TVehiculo", "TVehiculo").Value = value;
			}
		}

		[Browsable(false)]
		[DataMember]
		public EntityReference<BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo> TVehiculoReference
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo>("masterDBACModel.FK_TvehiculoParqueo_TVehiculo", "TVehiculo");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo>("masterDBACModel.FK_TvehiculoParqueo_TVehiculo", "TVehiculo", value);
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

		public TvehiculoParqueo()
		{
		}

		public static TvehiculoParqueo CreateTvehiculoParqueo(int idVehiculo, int idParqueadero, byte diaSemana, int id)
		{
			TvehiculoParqueo tvehiculoParqueo = new TvehiculoParqueo()
			{
				idVehiculo = idVehiculo,
				idParqueadero = idParqueadero,
				diaSemana = diaSemana,
				id = id
			};
			return tvehiculoParqueo;
		}
	}
}