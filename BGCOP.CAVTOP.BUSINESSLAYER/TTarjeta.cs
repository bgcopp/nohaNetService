using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TTarjeta")]
	[Serializable]
	public class TTarjeta : EntityObject
	{
		private int _idTarjeta;

		private string _numtarjeta;

		private int? _idHorario;

		private DateTime? _fechaUltimaGestion;

		private int? _usuarioUltimaGestion;

		private bool? _activa;

		private bool? _esvisitante;

		private bool? _esutilizada;

		private DateTime? _fechavisi1;

		private DateTime? _fechavisi2;

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public bool? activa
		{
			get
			{
				return this._activa;
			}
			set
			{
				this.ReportPropertyChanging("activa");
				this._activa = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("activa");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public bool? esutilizada
		{
			get
			{
				return this._esutilizada;
			}
			set
			{
				this.ReportPropertyChanging("esutilizada");
				this._esutilizada = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("esutilizada");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public bool? esvisitante
		{
			get
			{
				return this._esvisitante;
			}
			set
			{
				this.ReportPropertyChanging("esvisitante");
				this._esvisitante = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("esvisitante");
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
		public DateTime? fechavisi1
		{
			get
			{
				return this._fechavisi1;
			}
			set
			{
				this.ReportPropertyChanging("fechavisi1");
				this._fechavisi1 = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("fechavisi1");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public DateTime? fechavisi2
		{
			get
			{
				return this._fechavisi2;
			}
			set
			{
				this.ReportPropertyChanging("fechavisi2");
				this._fechavisi2 = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("fechavisi2");
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
		[EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
		public int idTarjeta
		{
			get
			{
				return this._idTarjeta;
			}
			set
			{
				if (this._idTarjeta != value)
				{
					this.ReportPropertyChanging("idTarjeta");
					this._idTarjeta = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idTarjeta");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string numtarjeta
		{
			get
			{
				return this._numtarjeta;
			}
			set
			{
				this.ReportPropertyChanging("numtarjeta");
				this._numtarjeta = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("numtarjeta");
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

		public TTarjeta()
		{
		}

		public static TTarjeta CreateTTarjeta(int idTarjeta)
		{
			return new TTarjeta()
			{
				idTarjeta = idTarjeta
			};
		}
	}
}