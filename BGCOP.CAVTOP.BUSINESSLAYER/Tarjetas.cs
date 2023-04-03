using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class Tarjetas
	{
		public Tarjetas()
		{
		}

		public void asignartarjetaempleado(string tarjetaS, int id)
		{
			using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
			{
				TTarjeta tTarjetum = (
					from a in masterDBACEntity.TTarjeta
					where a.numtarjeta == tarjetaS
					select a).FirstOrDefault<TTarjeta>();
				TEmpleado nullable = (
					from b in masterDBACEntity.TEmpleado
					where b.idEmpleado == id
					select b).FirstOrDefault<TEmpleado>();
				nullable.idTarjeta = new int?(tTarjetum.idTarjeta);
				masterDBACEntity.SaveChanges();
			}
		}

		public void asignartarjetaempleado(int tarjetaI, int id)
		{
			using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
			{
				TEmpleado nullable = (
					from b in masterDBACEntity.TEmpleado
					where b.idEmpleado == id
					select b).FirstOrDefault<TEmpleado>();
				nullable.idTarjeta = new int?(tarjetaI);
				masterDBACEntity.SaveChanges();
			}
		}

		public void crearTarjeta(string cad)
		{
			using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
			{
				TTarjeta tTarjetum = new TTarjeta()
				{
					numtarjeta = cad,
					activa = new bool?(true)
				};
				masterDBACEntity.AddToTTarjeta(tTarjetum);
				masterDBACEntity.SaveChanges();
			}
		}

		public void limpiarTarjeta(string tarjetaS)
		{
			using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
			{
				TTarjeta nullable = (
					from a in masterDBACEntity.TTarjeta
					where a.numtarjeta == tarjetaS
					select a).FirstOrDefault<TTarjeta>();
				if (nullable != null)
				{
					nullable.esvisitante = new bool?(false);
				}
				masterDBACEntity.SaveChanges();
			}
		}

		public List<TTarjeta> ListarTodas()
		{
			List<TTarjeta> list;
			using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
			{
				IQueryable<TTarjeta> tTarjeta = 
					from usr in masterDBACEntity.TTarjeta
					select usr;
				list = tTarjeta.ToList<TTarjeta>();
			}
			return list;
		}

		public List<TTarjeta> ListarTodasActivas()
		{
			List<TTarjeta> list;
			using (masterDBACEntities masterDBACEntity = new masterDBACEntities())
			{
				IQueryable<TTarjeta> tTarjeta = 
					from usr in masterDBACEntity.TTarjeta
					where usr.esutilizada != (bool?)true
					select usr;
				list = tTarjeta.ToList<TTarjeta>();
			}
			return list;
		}
	}
}