using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	[DataContract(IsReference=true)]
	[EdmEntityType(NamespaceName="masterDBACModel", Name="TEmpresaVisitante")]
	[Serializable]
	public class TEmpresaVisitante : EntityObject
	{
		private int _idEmpresaVisitante;

		private string _razonSocialEV;

		private DateTime? _fechaUltimaGestion;

		private int? _usuarioUltimaGestion;

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
		public int idEmpresaVisitante
		{
			get
			{
				return this._idEmpresaVisitante;
			}
			set
			{
				if (this._idEmpresaVisitante != value)
				{
					this.ReportPropertyChanging("idEmpresaVisitante");
					this._idEmpresaVisitante = StructuralObject.SetValidValue(value);
					this.ReportPropertyChanged("idEmpresaVisitante");
				}
			}
		}

		[DataMember]
		[EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
		public string razonSocialEV
		{
			get
			{
				return this._razonSocialEV;
			}
			set
			{
				this.ReportPropertyChanging("razonSocialEV");
				this._razonSocialEV = StructuralObject.SetValidValue(value, true);
				this.ReportPropertyChanged("razonSocialEV");
			}
		}

		[DataMember]
		[EdmRelationshipNavigationProperty("masterDBACModel", "FK_TVisitante_TEmpresaVisitante", "TVisitante")]
		[SoapIgnore]
		[XmlIgnore]
		public EntityCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitante> TVisitante
		{
			get
			{
				return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitante>("masterDBACModel.FK_TVisitante_TEmpresaVisitante", "TVisitante");
			}
			set
			{
				if (value != null)
				{
					((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BGCOP.CAVTOP.BUSINESSLAYER.TVisitante>("masterDBACModel.FK_TVisitante_TEmpresaVisitante", "TVisitante", value);
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

		public TEmpresaVisitante()
		{
		}

		public static TEmpresaVisitante CreateTEmpresaVisitante(int idEmpresaVisitante)
		{
			return new TEmpresaVisitante()
			{
				idEmpresaVisitante = idEmpresaVisitante
			};
		}
	}
}