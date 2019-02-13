namespace CustomerWebAPI.BusinessLogic
{
	using CustomerWebAPI.BusinessObjects;
	using CustomerWebAPI.DataAccess;

	public class CustomerBL
	{
		public Customer GetCustomers()
		{
			CustomerDA customerDA = new CustomerDA();

			return customerDA.GetCustomer();
		}
	}
}
