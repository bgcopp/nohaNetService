using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TParqueo")]
	[Serializable]
	public class TParqueo : EntityObject
	{
		private int _idParqueadero;

		private string _nParqueo;

		private string _observacionesParqueo;

		private DateTime? _fechaUltimaGestion;

		private int? _usuarioUltimaGestion;

		private bool? _estaocupado;

		private string _ocupadopor;

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public bool? estaocupado
		{
			get
			{
				return this._estaocupado;
			}
			set
			{
				this.ReportPropertyChanging("estaocupado");
				this._estaocupado = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("estaocupado");
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
		public int idParqueadero
		{
			get
			{
				return this._idParqueadero;
			}
			set
			{
				if (this._idParqueadero != value)
				{
					this.ReportPropertyChanging("idParqueadero");
					this._idParqueadero = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idParqueadero");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string nParqueo
		{
			get
			{
				return this._nParqueo;
			}
			set
			{
				this.ReportPropertyChanging("nParqueo");
				this._nParqueo = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("nParqueo");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string observacionesParqueo
		{
			get
			{
				return this._observacionesParqueo;
			}
			set
			{
				this.ReportPropertyChanging("observacionesParqueo");
				this._observacionesParqueo = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("observacionesParqueo");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string ocupadopor
		{
			get
			{
				return this._ocupadopor;
			}
			set
			{
				this.ReportPropertyChanging("ocupadopor");
				this._ocupadopor = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("ocupadopor");
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TvehiculoParqueo_Tparqueo", "TvehiculoParqueo")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TvehiculoParqueo> TvehiculoParqueo
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TvehiculoParqueo>("masterDBACModel.FK_TvehiculoParqueo_Tparqueo", "TvehiculoParqueo");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TvehiculoParqueo>("masterDBACModel.FK_TvehiculoParqueo_Tparqueo", "TvehiculoParqueo", value);
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

		public TParqueo()
		{
		}

		public static TParqueo CreateTParqueo(int idParqueadero)
		{
			return new TParqueo()
			{
				idParqueadero = idParqueadero
			};
		}
	}
}