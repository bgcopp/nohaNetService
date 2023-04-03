using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="sysdiagrams")]
	[Serializable]
	public class sysdiagrams : EntityObject
	{
		private string _name;

		private int _principal_id;

		private int _diagram_id;

		private int? _version;

		private byte[] _definition;

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public byte[] definition
		{
			get
			{
				return StructuralObject.GetValidValue(this._definition);
			}
			set
			{
				this.ReportPropertyChanging("definition");
				this._definition = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("definition");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
		public int diagram_id
		{
			get
			{
				return this._diagram_id;
			}
			set
			{
				if (this._diagram_id != value)
				{
					this.ReportPropertyChanging("diagram_id");
					this._diagram_id = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("diagram_id");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				this.ReportPropertyChanging("name");
				this._name = StructuralObject.SetValidValue(value, false);
				this.ReportPropertyChanged("name");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
		public int principal_id
		{
			get
			{
				return this._principal_id;
			}
			set
			{
				this.ReportPropertyChanging("principal_id");
				this._principal_id = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("principal_id");
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public int? version
		{
			get
			{
				return this._version;
			}
			set
			{
				this.ReportPropertyChanging("version");
				this._version = StructuralObject.SetValidValue(value);
				this.ReportPropertyChanged("version");
			}
		}

		public sysdiagrams()
		{
		}

		public static sysdiagrams Createsysdiagrams(string name, int principal_id, int diagram_id)
		{
			sysdiagrams sysdiagram = new sysdiagrams()
			{
				name = name,
				principal_id = principal_id,
				diagram_id = diagram_id
			};
			return sysdiagram;
		}
	}
}