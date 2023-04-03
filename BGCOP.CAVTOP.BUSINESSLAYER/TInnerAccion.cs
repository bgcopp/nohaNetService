using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TInnerAccion")]
	[Serializable]
	public class TInnerAccion : EntityObject
	{
		private decimal _id;

		private int? _CodeInner;

		private string _CodigoAccion;

		private DateTime? _fecha;

		private int? _Cumplido;

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
		public string CodigoAccion
		{
			get
			{
				return this._CodigoAccion;
			}
			set
			{
				this.ReportPropertyChanging("CodigoAccion");
				this._CodigoAccion = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("CodigoAccion");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public int? Cumplido
		{
			get
			{
				return this._Cumplido;
			}
			set
			{
				this.ReportPropertyChanging("Cumplido");
				this._Cumplido = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("Cumplido");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public DateTime? fecha
		{
			get
			{
				return this._fecha;
			}
			set
			{
				this.ReportPropertyChanging("fecha");
				this._fecha = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("fecha");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
		public decimal id
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

		public TInnerAccion()
		{
		}

		public static TInnerAccion CreateTInnerAccion(decimal id)
		{
			return new TInnerAccion()
			{
				id = id
			};
		}
	}
}