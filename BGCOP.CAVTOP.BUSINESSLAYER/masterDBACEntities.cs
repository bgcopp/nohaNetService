using System;
using System.Data.EntityClient;
using System.Data.Objects;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class masterDBACEntities : ObjectContext
	{
		private const string defaultIsolation = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED";

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.sysdiagrams> _sysdiagrams;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TCargo> _TCargo;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TDiasHorario> _TDiasHorario;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TDivisionEmpresa> _TDivisionEmpresa;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado> _TEmpleado;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleadoVehiculo> _TEmpleadoVehiculo;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TEmpresa> _TEmpresa;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TEmpresaVisitante> _TEmpresaVisitante;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TEstado> _TEstado;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TFestivos> _TFestivos;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.THorario> _THorario;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TipoVehiculo> _TipoVehiculo;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TMarcaVehiculo> _TMarcaVehiculo;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TModeloVehiculo> _TModeloVehiculo;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TPanel> _TPanel;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TRegistroEmpleado> _TRegistroEmpleado;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TTipoIdentificacion> _TTipoIdentificacion;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TTipoRegistro> _TTipoRegistro;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TTipoUsuario> _TTipoUsuario;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TUsuario> _TUsuario;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo> _TVehiculo;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TvehiculoParqueo> _TvehiculoParqueo;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TVisitante> _TVisitante;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramada> _TVisitanteVisitaProgramada;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TVisitaProgramada> _TVisitaProgramada;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TParqueo> _TParqueo;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TRegistroVehiculo> _TRegistroVehiculo;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.viVehiculo> _viVehiculo;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.viParqueoVehiculo> _viParqueoVehiculo;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TTarjeta> _TTarjeta;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.viEmpleado> _viEmpleado;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.Tinner> _Tinner;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TInnerAccion> _TInnerAccion;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TMarcacion> _TMarcacion;

		private ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramadaLog> _TVisitanteVisitaProgramadaLog;

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.sysdiagrams> sysdiagrams
		{
			get
			{
				if (this._sysdiagrams == null)
				{
					this._sysdiagrams = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.sysdiagrams>("sysdiagrams");
				}
				return this._sysdiagrams;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TCargo> TCargo
		{
			get
			{
				if (this._TCargo == null)
				{
					this._TCargo = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TCargo>("TCargo");
				}
				return this._TCargo;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TDiasHorario> TDiasHorario
		{
			get
			{
				if (this._TDiasHorario == null)
				{
					this._TDiasHorario = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TDiasHorario>("TDiasHorario");
				}
				return this._TDiasHorario;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TDivisionEmpresa> TDivisionEmpresa
		{
			get
			{
				if (this._TDivisionEmpresa == null)
				{
					this._TDivisionEmpresa = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TDivisionEmpresa>("TDivisionEmpresa");
				}
				return this._TDivisionEmpresa;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado> TEmpleado
		{
			get
			{
				if (this._TEmpleado == null)
				{
					this._TEmpleado = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado>("TEmpleado");
				}
				return this._TEmpleado;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleadoVehiculo> TEmpleadoVehiculo
		{
			get
			{
				if (this._TEmpleadoVehiculo == null)
				{
					this._TEmpleadoVehiculo = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TEmpleadoVehiculo>("TEmpleadoVehiculo");
				}
				return this._TEmpleadoVehiculo;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TEmpresa> TEmpresa
		{
			get
			{
				if (this._TEmpresa == null)
				{
					this._TEmpresa = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TEmpresa>("TEmpresa");
				}
				return this._TEmpresa;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TEmpresaVisitante> TEmpresaVisitante
		{
			get
			{
				if (this._TEmpresaVisitante == null)
				{
					this._TEmpresaVisitante = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TEmpresaVisitante>("TEmpresaVisitante");
				}
				return this._TEmpresaVisitante;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TEstado> TEstado
		{
			get
			{
				if (this._TEstado == null)
				{
					this._TEstado = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TEstado>("TEstado");
				}
				return this._TEstado;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TFestivos> TFestivos
		{
			get
			{
				if (this._TFestivos == null)
				{
					this._TFestivos = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TFestivos>("TFestivos");
				}
				return this._TFestivos;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.THorario> THorario
		{
			get
			{
				if (this._THorario == null)
				{
					this._THorario = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.THorario>("THorario");
				}
				return this._THorario;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.Tinner> Tinner
		{
			get
			{
				if (this._Tinner == null)
				{
					this._Tinner = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.Tinner>("Tinner");
				}
				return this._Tinner;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TInnerAccion> TInnerAccion
		{
			get
			{
				if (this._TInnerAccion == null)
				{
					this._TInnerAccion = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TInnerAccion>("TInnerAccion");
				}
				return this._TInnerAccion;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TipoVehiculo> TipoVehiculo
		{
			get
			{
				if (this._TipoVehiculo == null)
				{
					this._TipoVehiculo = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TipoVehiculo>("TipoVehiculo");
				}
				return this._TipoVehiculo;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TMarcacion> TMarcacion
		{
			get
			{
				if (this._TMarcacion == null)
				{
					this._TMarcacion = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TMarcacion>("TMarcacion");
				}
				return this._TMarcacion;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TMarcaVehiculo> TMarcaVehiculo
		{
			get
			{
				if (this._TMarcaVehiculo == null)
				{
					this._TMarcaVehiculo = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TMarcaVehiculo>("TMarcaVehiculo");
				}
				return this._TMarcaVehiculo;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TModeloVehiculo> TModeloVehiculo
		{
			get
			{
				if (this._TModeloVehiculo == null)
				{
					this._TModeloVehiculo = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TModeloVehiculo>("TModeloVehiculo");
				}
				return this._TModeloVehiculo;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TPanel> TPanel
		{
			get
			{
				if (this._TPanel == null)
				{
					this._TPanel = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TPanel>("TPanel");
				}
				return this._TPanel;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TParqueo> TParqueo
		{
			get
			{
				if (this._TParqueo == null)
				{
					this._TParqueo = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TParqueo>("TParqueo");
				}
				return this._TParqueo;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TRegistroEmpleado> TRegistroEmpleado
		{
			get
			{
				if (this._TRegistroEmpleado == null)
				{
					this._TRegistroEmpleado = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TRegistroEmpleado>("TRegistroEmpleado");
				}
				return this._TRegistroEmpleado;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TRegistroVehiculo> TRegistroVehiculo
		{
			get
			{
				if (this._TRegistroVehiculo == null)
				{
					this._TRegistroVehiculo = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TRegistroVehiculo>("TRegistroVehiculo");
				}
				return this._TRegistroVehiculo;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TTarjeta> TTarjeta
		{
			get
			{
				if (this._TTarjeta == null)
				{
					this._TTarjeta = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TTarjeta>("TTarjeta");
				}
				return this._TTarjeta;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TTipoIdentificacion> TTipoIdentificacion
		{
			get
			{
				if (this._TTipoIdentificacion == null)
				{
					this._TTipoIdentificacion = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TTipoIdentificacion>("TTipoIdentificacion");
				}
				return this._TTipoIdentificacion;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TTipoRegistro> TTipoRegistro
		{
			get
			{
				if (this._TTipoRegistro == null)
				{
					this._TTipoRegistro = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TTipoRegistro>("TTipoRegistro");
				}
				return this._TTipoRegistro;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TTipoUsuario> TTipoUsuario
		{
			get
			{
				if (this._TTipoUsuario == null)
				{
					this._TTipoUsuario = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TTipoUsuario>("TTipoUsuario");
				}
				return this._TTipoUsuario;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TUsuario> TUsuario
		{
			get
			{
				if (this._TUsuario == null)
				{
					this._TUsuario = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TUsuario>("TUsuario");
				}
				return this._TUsuario;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo> TVehiculo
		{
			get
			{
				if (this._TVehiculo == null)
				{
					this._TVehiculo = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo>("TVehiculo");
				}
				return this._TVehiculo;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TvehiculoParqueo> TvehiculoParqueo
		{
			get
			{
				if (this._TvehiculoParqueo == null)
				{
					this._TvehiculoParqueo = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TvehiculoParqueo>("TvehiculoParqueo");
				}
				return this._TvehiculoParqueo;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TVisitante> TVisitante
		{
			get
			{
				if (this._TVisitante == null)
				{
					this._TVisitante = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TVisitante>("TVisitante");
				}
				return this._TVisitante;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramada> TVisitanteVisitaProgramada
		{
			get
			{
				if (this._TVisitanteVisitaProgramada == null)
				{
					this._TVisitanteVisitaProgramada = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramada>("TVisitanteVisitaProgramada");
				}
				return this._TVisitanteVisitaProgramada;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramadaLog> TVisitanteVisitaProgramadaLog
		{
			get
			{
				if (this._TVisitanteVisitaProgramadaLog == null)
				{
					this._TVisitanteVisitaProgramadaLog = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramadaLog>("TVisitanteVisitaProgramadaLog");
				}
				return this._TVisitanteVisitaProgramadaLog;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TVisitaProgramada> TVisitaProgramada
		{
			get
			{
				if (this._TVisitaProgramada == null)
				{
					this._TVisitaProgramada = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.TVisitaProgramada>("TVisitaProgramada");
				}
				return this._TVisitaProgramada;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.viEmpleado> viEmpleado
		{
			get
			{
				if (this._viEmpleado == null)
				{
					this._viEmpleado = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.viEmpleado>("viEmpleado");
				}
				return this._viEmpleado;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.viParqueoVehiculo> viParqueoVehiculo
		{
			get
			{
				if (this._viParqueoVehiculo == null)
				{
					this._viParqueoVehiculo = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.viParqueoVehiculo>("viParqueoVehiculo");
				}
				return this._viParqueoVehiculo;
			}
		}

		public ObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.viVehiculo> viVehiculo
		{
			get
			{
				if (this._viVehiculo == null)
				{
					this._viVehiculo = base.CreateObjectSet<BGCOP.CAVTOP.BUSINESSLAYER.viVehiculo>("viVehiculo");
				}
				return this._viVehiculo;
			}
		}

		public masterDBACEntities() : base("name=masterDBACEntities", "masterDBACEntities")
		{
			base.ContextOptions.LazyLoadingEnabled = true;
			this.OnContextCreated();
		}

		public masterDBACEntities(string connectionString) : base(connectionString, "masterDBACEntities")
		{
			base.ContextOptions.LazyLoadingEnabled = true;
			this.OnContextCreated();
		}

		public masterDBACEntities(EntityConnection connection) : base(connection, "masterDBACEntities")
		{
			base.ContextOptions.LazyLoadingEnabled = true;
			this.OnContextCreated();
		}

		public void AddTosysdiagrams(BGCOP.CAVTOP.BUSINESSLAYER.sysdiagrams sysdiagrams)
		{
			base.AddObject("sysdiagrams", sysdiagrams);
		}

		public void AddToTCargo(BGCOP.CAVTOP.BUSINESSLAYER.TCargo tCargo)
		{
			base.AddObject("TCargo", tCargo);
		}

		public void AddToTDiasHorario(BGCOP.CAVTOP.BUSINESSLAYER.TDiasHorario tDiasHorario)
		{
			base.AddObject("TDiasHorario", tDiasHorario);
		}

		public void AddToTDivisionEmpresa(BGCOP.CAVTOP.BUSINESSLAYER.TDivisionEmpresa tDivisionEmpresa)
		{
			base.AddObject("TDivisionEmpresa", tDivisionEmpresa);
		}

		public void AddToTEmpleado(BGCOP.CAVTOP.BUSINESSLAYER.TEmpleado tEmpleado)
		{
			base.AddObject("TEmpleado", tEmpleado);
		}

		public void AddToTEmpleadoVehiculo(BGCOP.CAVTOP.BUSINESSLAYER.TEmpleadoVehiculo tEmpleadoVehiculo)
		{
			base.AddObject("TEmpleadoVehiculo", tEmpleadoVehiculo);
		}

		public void AddToTEmpresa(BGCOP.CAVTOP.BUSINESSLAYER.TEmpresa tEmpresa)
		{
			base.AddObject("TEmpresa", tEmpresa);
		}

		public void AddToTEmpresaVisitante(BGCOP.CAVTOP.BUSINESSLAYER.TEmpresaVisitante tEmpresaVisitante)
		{
			base.AddObject("TEmpresaVisitante", tEmpresaVisitante);
		}

		public void AddToTEstado(BGCOP.CAVTOP.BUSINESSLAYER.TEstado tEstado)
		{
			base.AddObject("TEstado", tEstado);
		}

		public void AddToTFestivos(BGCOP.CAVTOP.BUSINESSLAYER.TFestivos tFestivos)
		{
			base.AddObject("TFestivos", tFestivos);
		}

		public void AddToTHorario(BGCOP.CAVTOP.BUSINESSLAYER.THorario tHorario)
		{
			base.AddObject("THorario", tHorario);
		}

		public void AddToTinner(BGCOP.CAVTOP.BUSINESSLAYER.Tinner tinner)
		{
			base.AddObject("Tinner", tinner);
		}

		public void AddToTInnerAccion(BGCOP.CAVTOP.BUSINESSLAYER.TInnerAccion tInnerAccion)
		{
			base.AddObject("TInnerAccion", tInnerAccion);
		}

		public void AddToTipoVehiculo(BGCOP.CAVTOP.BUSINESSLAYER.TipoVehiculo tipoVehiculo)
		{
			base.AddObject("TipoVehiculo", tipoVehiculo);
		}

		public void AddToTMarcacion(BGCOP.CAVTOP.BUSINESSLAYER.TMarcacion tMarcacion)
		{
			base.AddObject("TMarcacion", tMarcacion);
		}

		public void AddToTMarcaVehiculo(BGCOP.CAVTOP.BUSINESSLAYER.TMarcaVehiculo tMarcaVehiculo)
		{
			base.AddObject("TMarcaVehiculo", tMarcaVehiculo);
		}

		public void AddToTModeloVehiculo(BGCOP.CAVTOP.BUSINESSLAYER.TModeloVehiculo tModeloVehiculo)
		{
			base.AddObject("TModeloVehiculo", tModeloVehiculo);
		}

		public void AddToTPanel(BGCOP.CAVTOP.BUSINESSLAYER.TPanel tPanel)
		{
			base.AddObject("TPanel", tPanel);
		}

		public void AddToTParqueo(BGCOP.CAVTOP.BUSINESSLAYER.TParqueo tParqueo)
		{
			base.AddObject("TParqueo", tParqueo);
		}

		public void AddToTRegistroEmpleado(BGCOP.CAVTOP.BUSINESSLAYER.TRegistroEmpleado tRegistroEmpleado)
		{
			base.AddObject("TRegistroEmpleado", tRegistroEmpleado);
		}

		public void AddToTRegistroVehiculo(BGCOP.CAVTOP.BUSINESSLAYER.TRegistroVehiculo tRegistroVehiculo)
		{
			base.AddObject("TRegistroVehiculo", tRegistroVehiculo);
		}

		public void AddToTTarjeta(BGCOP.CAVTOP.BUSINESSLAYER.TTarjeta tTarjeta)
		{
			base.AddObject("TTarjeta", tTarjeta);
		}

		public void AddToTTipoIdentificacion(BGCOP.CAVTOP.BUSINESSLAYER.TTipoIdentificacion tTipoIdentificacion)
		{
			base.AddObject("TTipoIdentificacion", tTipoIdentificacion);
		}

		public void AddToTTipoRegistro(BGCOP.CAVTOP.BUSINESSLAYER.TTipoRegistro tTipoRegistro)
		{
			base.AddObject("TTipoRegistro", tTipoRegistro);
		}

		public void AddToTTipoUsuario(BGCOP.CAVTOP.BUSINESSLAYER.TTipoUsuario tTipoUsuario)
		{
			base.AddObject("TTipoUsuario", tTipoUsuario);
		}

		public void AddToTUsuario(BGCOP.CAVTOP.BUSINESSLAYER.TUsuario tUsuario)
		{
			base.AddObject("TUsuario", tUsuario);
		}

		public void AddToTVehiculo(BGCOP.CAVTOP.BUSINESSLAYER.TVehiculo tVehiculo)
		{
			base.AddObject("TVehiculo", tVehiculo);
		}

		public void AddToTvehiculoParqueo(BGCOP.CAVTOP.BUSINESSLAYER.TvehiculoParqueo tvehiculoParqueo)
		{
			base.AddObject("TvehiculoParqueo", tvehiculoParqueo);
		}

		public void AddToTVisitante(BGCOP.CAVTOP.BUSINESSLAYER.TVisitante tVisitante)
		{
			base.AddObject("TVisitante", tVisitante);
		}

		public void AddToTVisitanteVisitaProgramada(BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramada tVisitanteVisitaProgramada)
		{
			base.AddObject("TVisitanteVisitaProgramada", tVisitanteVisitaProgramada);
		}

		public void AddToTVisitanteVisitaProgramadaLog(BGCOP.CAVTOP.BUSINESSLAYER.TVisitanteVisitaProgramadaLog tVisitanteVisitaProgramadaLog)
		{
			base.AddObject("TVisitanteVisitaProgramadaLog", tVisitanteVisitaProgramadaLog);
		}

		public void AddToTVisitaProgramada(BGCOP.CAVTOP.BUSINESSLAYER.TVisitaProgramada tVisitaProgramada)
		{
			base.AddObject("TVisitaProgramada", tVisitaProgramada);
		}

		public void AddToviEmpleado(BGCOP.CAVTOP.BUSINESSLAYER.viEmpleado viEmpleado)
		{
			base.AddObject("viEmpleado", viEmpleado);
		}

		public void AddToviParqueoVehiculo(BGCOP.CAVTOP.BUSINESSLAYER.viParqueoVehiculo viParqueoVehiculo)
		{
			base.AddObject("viParqueoVehiculo", viParqueoVehiculo);
		}

		public void AddToviVehiculo(BGCOP.CAVTOP.BUSINESSLAYER.viVehiculo viVehiculo)
		{
			base.AddObject("viVehiculo", viVehiculo);
		}

		private void OnContextCreated()
		{
			base.ExecuteStoreCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED", new object[0]);
		}
	}
}