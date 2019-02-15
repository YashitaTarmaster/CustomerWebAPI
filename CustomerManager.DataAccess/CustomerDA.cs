using System;

namespace CustomerManager.DataAccess
{
	using BusinessObjects;

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
