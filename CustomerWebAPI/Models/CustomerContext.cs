using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CustomerWebAPI.Models
{
	using CustomerWebAPI.BusinessObjects;

	public class CustomerContext : DbContext
	{
		public CustomerContext(DbContextOptions<CustomerContext> options)
			: base(options)
		{

		}

		public DbSet<Customer> customers { get; set; }
	}
}
