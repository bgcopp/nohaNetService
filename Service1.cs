using System;

namespace WCFNOHAWEB
{
	public class Service1 : IService1
	{
		public Service1()
		{
		}

		public string GetData(int value)
		{
			return string.Format("You entered: {0}", value);
		}

		public CompositeType GetDataUsingDataContract(CompositeType composite)
		{
			if (composite == null)
			{
				throw new ArgumentNullException("composite");
			}
			if (composite.BoolValue)
			{
				CompositeType compositeType = composite;
				compositeType.StringValue = string.Concat(compositeType.StringValue, "Suffix");
			}
			return composite;
		}
	}
}