using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TPanel")]
	[Serializable]
	public class TPanel : EntityObject
	{
		private int _idPanel;

		private string _descrpcionPanel;

		private string _direccionIP;

		private string _puertoPanel;

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string descrpcionPanel
		{
			get
			{
				return this._descrpcionPanel;
			}
			set
			{
				this.ReportPropertyChanging("descrpcionPanel");
				this._descrpcionPanel = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("descrpcionPanel");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string direccionIP
		{
			get
			{
				return this._direccionIP;
			}
			set
			{
				this.ReportPropertyChanging("direccionIP");
				this._direccionIP = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("direccionIP");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
		public int idPanel
		{
			get
			{
				return this._idPanel;
			}
			set
			{
				if (this._idPanel != value)
				{
					this.ReportPropertyChanging("idPanel");
					this._idPanel = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idPanel");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string puertoPanel
		{
			get
			{
				return this._puertoPanel;
			}
			set
			{
				this.ReportPropertyChanging("puertoPanel");
				this._puertoPanel = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("puertoPanel");
			}
		}

		public TPanel()
		{
		}

		public static TPanel CreateTPanel(int idPanel)
		{
			return new TPanel()
			{
				idPanel = idPanel
			};
		}
	}
}