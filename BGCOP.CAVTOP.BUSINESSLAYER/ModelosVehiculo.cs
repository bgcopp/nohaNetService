using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class ModelosVehiculo
	{
		public ModelosVehiculo()
		{
		}

		public TModeloVehiculo buscar(string modelo)
		{
			TModeloVehiculo tModeloVehiculo = (
				from d in (new masterDBACEntities()).TModeloVehiculo
				where d.NombreModelo.StartsWith(modelo.Substring(0, 2))
				select d).FirstOrDefault<TModeloVehiculo>();
			return tModeloVehiculo;
		}

		public void CrearModeloVehiculo(string modelo, DateTime fechaC, int usuarioUg, int tipoVeh = 1)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TModeloVehiculo tModeloVehiculo = new TModeloVehiculo()
			{
				NombreModelo = modelo,
				idTipoVehiculo = new byte?((byte)tipoVeh),
				fechaUltimaGestion = new DateTime?(fechaC),
				usuarioUltimaGestion = new int?(usuarioUg)
			};
			masterDBACEntity.AddToTModeloVehiculo(tModeloVehiculo);
			masterDBACEntity.SaveChanges();
		}

		public bool EliminarModeloVehiculo(int idEmp)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TModeloVehiculo tModeloVehiculo = masterDBACEntity.TModeloVehiculo.FirstOrDefault<TModeloVehiculo>((TModeloVehiculo c) => (int)c.idModeloVehiculo == idEmp);
			masterDBACEntity.TModeloVehiculo.DeleteObject(tModeloVehiculo);
			masterDBACEntity.SaveChanges();
			return true;
		}

		public List<TModeloVehiculo> ListarTodos()
		{
			IQueryable<TModeloVehiculo> tModeloVehiculo = 
				from d in (new masterDBACEntities()).TModeloVehiculo
				select d;
			return tModeloVehiculo.ToList<TModeloVehiculo>();
		}

		public List<TModeloVehiculo> ListarTodos(int idMarca)
		{
			IQueryable<TModeloVehiculo> tModeloVehiculo = 
				from d in (new masterDBACEntities()).TModeloVehiculo
				where (int?)d.idMarcaVehiculo == (int?)idMarca
				select d;
			return tModeloVehiculo.ToList<TModeloVehiculo>();
		}

		public void ModificarModelo(int idEmp, TModeloVehiculo nueva)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TModeloVehiculo nombreModelo = masterDBACEntity.TModeloVehiculo.FirstOrDefault<TModeloVehiculo>((TModeloVehiculo c) => (int)c.idModeloVehiculo == idEmp);
			if (nombreModelo != null)
			{
				nombreModelo.NombreModelo = nueva.NombreModelo;
				nombreModelo.TipoVehiculo = nueva.TipoVehiculo;
				nombreModelo.idMarcaVehiculo = nueva.idMarcaVehiculo;
				nombreModelo.fechaUltimaGestion = nueva.fechaUltimaGestion;
				nombreModelo.usuarioUltimaGestion = nueva.usuarioUltimaGestion;
				masterDBACEntity.SaveChanges();
			}
		}
	}
}