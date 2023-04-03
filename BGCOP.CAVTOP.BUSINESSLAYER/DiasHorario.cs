using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class DiasHorario
	{
		public DiasHorario()
		{
		}

		public void Agregar(int idHorario, int dia, string horaEntrada, string horaSalida, string Observa)
		{
			try
			{
				masterDBACEntities masterDBACEntity = new masterDBACEntities();
				TDiasHorario tDiasHorario = new TDiasHorario()
				{
					idHorario = new int?(idHorario),
					dia = new byte?((byte)dia),
					entrada = horaEntrada,
					salida = horaSalida,
					ObservacionesDia = Observa
				};
				masterDBACEntity.AddToTDiasHorario(tDiasHorario);
				masterDBACEntity.SaveChanges();
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		public void Eliminar(int idT)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TDiasHorario tDiasHorario = masterDBACEntity.TDiasHorario.FirstOrDefault<TDiasHorario>((TDiasHorario c) => c.idDiasHorario == idT);
			if (tDiasHorario != null)
			{
				masterDBACEntity.TDiasHorario.DeleteObject(tDiasHorario);
				masterDBACEntity.SaveChanges();
			}
		}

		public List<TDiasHorario> ListarTodas(int idHorario)
		{
			IQueryable<TDiasHorario> tDiasHorario = 
				from d in (new masterDBACEntities()).TDiasHorario
				where d.idHorario == (int?)idHorario
				select d;
			return tDiasHorario.ToList<TDiasHorario>();
		}

		public void Modificar(int idT, int idHorario, int dia, string horaEntrada, string horaSalida, string Observa)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			TDiasHorario nullable = masterDBACEntity.TDiasHorario.FirstOrDefault<TDiasHorario>((TDiasHorario c) => c.idDiasHorario == idT);
			if (nullable != null)
			{
				nullable.dia = new byte?((byte)dia);
				nullable.entrada = horaEntrada;
				nullable.salida = horaSalida;
				nullable.ObservacionesDia = Observa;
				masterDBACEntity.SaveChanges();
			}
		}
	}
}