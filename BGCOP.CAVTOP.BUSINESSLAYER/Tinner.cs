using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="Tinner")]
	[Serializable]
	public class Tinner : EntityObject
	{
		private int _id;

		private int? _CodeInner;

		private string _NombreInner;

		private bool? _esActivo;

		private bool? _esinnerNet;

		private int? _puertoCom;

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public int? CodeInner
		{
			get
			{
				return this._CodeInner;
			}
			set
			{
				this.ReportPropertyChanging("CodeInner");
				this._CodeInner = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("CodeInner");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public bool? esActivo
		{
			get
			{
				return this._esActivo;
			}
			set
			{
				this.ReportPropertyChanging("esActivo");
				this._esActivo = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("esActivo");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public bool? esinnerNet
		{
			get
			{
				return this._esinnerNet;
			}
			set
			{
				this.ReportPropertyChanging("esinnerNet");
				this._esinnerNet = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("esinnerNet");
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
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string NombreInner
		{
			get
			{
				return this._NombreInner;
			}
			set
			{
				this.ReportPropertyChanging("NombreInner");
				this._NombreInner = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("NombreInner");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public int? puertoCom
		{
			get
			{
				return this._puertoCom;
			}
			set
			{
				this.ReportPropertyChanging("puertoCom");
				this._puertoCom = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("puertoCom");
			}
		}

		public Tinner()
		{
		}

		public static Tinner CreateTinner(int id)
		{
			return new Tinner()
			{
				id = id
			};
		}
	}
}