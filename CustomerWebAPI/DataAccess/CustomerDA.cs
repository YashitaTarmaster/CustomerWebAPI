using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerWebAPI.DataAccess
{
	using CustomerWebAPI.BusinessObjects;

	public class CustomerDA
	{
		public Customer GetCustomer()
		{
			Customer customer = new Customer();
			customer.Id = 123;
			customer.Name = "Test";
			customer.LongName = "Application";
			return customer;
		}
	}
}
