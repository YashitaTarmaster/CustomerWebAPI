using BusinessObjects;
using CustomerManager.DataAccess;
using System;

namespace CustomerManager.Business
{
	public class CustomerBL
	{
		public Customer GetCustomers()
		{
			CustomerDA customerDA = new CustomerDA();

			return customerDA.GetCustomer();
		}
	}
}
