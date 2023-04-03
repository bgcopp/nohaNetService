using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TFestivos")]
	[Serializable]
	public class TFestivos : EntityObject
	{
		private int _idFestivo;

		private DateTime _fechaFestivo;

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
		public DateTime fechaFestivo
		{
			get
			{
				return this._fechaFestivo;
			}
			set
			{
				this.ReportPropertyChanging("fechaFestivo");
				this._fechaFestivo = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("fechaFestivo");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
		public int idFestivo
		{
			get
			{
				return this._idFestivo;
			}
			set
			{
				if (this._idFestivo != value)
				{
					this.ReportPropertyChanging("idFestivo");
					this._idFestivo = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idFestivo");
				}
			}
		}

		public TFestivos()
		{
		}

		public static TFestivos CreateTFestivos(int idFestivo, DateTime fechaFestivo)
		{
			return new TFestivos()
			{
				idFestivo = idFestivo,
				fechaFestivo = fechaFestivo
			};
		}
	}
}