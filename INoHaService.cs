using BGCOP.CAVTOP.BUSINESSLAYER;
using System;
using System.ServiceModel;

namespace WCFNOHAWEB
{
	[ServiceContract]
	public interface INoHaService
	{
		[OperationContract]
		bool activaBarreraHandHeldMC75(string entrada);

		[OperationContract]
		string DoWork();

		[OperationContract]
		MessageDTO VerificaEntradaCodigoBarras(string codigoBarrasVehiculo);

		[OperationContract]
		MessageDTO VerificaEntradaCodigoBarras1(string codigoBarrasVehiculo, string RFID);

		[OperationContract]
		MessageDTO VerificaSalidaCodigoBarrasRFID(string codigoBarrasVehiculo, string RFID);

		[OperationContract]
		MessageDTO VerificaSalidaCodigoBarrasRFID1(string codigoBarrasVehiculo);
	}
}