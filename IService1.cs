using System;
using System.ServiceModel;

namespace WCFNOHAWEB
{
	[ServiceContract]
	public interface IService1
	{
		[OperationContract]
		string GetData(int value);

		[OperationContract]
		CompositeType GetDataUsingDataContract(CompositeType composite);
	}
}