using BGCOP.CAVTOP.BUSINESSLAYER;
using System;

namespace WCFNOHAWEB
{
	public class NoHaService : INoHaService
	{
		public NoHaService()
		{
		}

		public bool activaBarreraHandHeldMC75(string entrada)
		{
			(new TareasInner()).AgregarTarea(1, "OpenS", entrada);
			return true;
		}

		public string DoWork()
		{
			return "Funciona!";
		}

		public MessageDTO VerificaEntradaCodigoBarras(string codigoBarrasVehiculo)
		{
			return (new Vtarjetas()).verificaParqueoEntrada(codigoBarrasVehiculo);
		}

		public MessageDTO VerificaEntradaCodigoBarras1(string codigoBarrasVehiculo, string RFID)
		{
			return (new Vtarjetas()).verificaParqueoEntrada(RFID, codigoBarrasVehiculo);
		}

		public MessageDTO VerificaSalidaCodigoBarrasRFID(string codigoBarrasVehiculo, string RFID)
		{
			return (new Vtarjetas()).verificaParqueoSalida(RFID, codigoBarrasVehiculo);
		}

		public MessageDTO VerificaSalidaCodigoBarrasRFID1(string codigoBarrasVehiculo)
		{
			return (new Vtarjetas()).verificaParqueoSalida(codigoBarrasVehiculo);
		}
	}
}