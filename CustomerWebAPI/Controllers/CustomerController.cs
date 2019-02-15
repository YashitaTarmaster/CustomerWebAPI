using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace CustomerWebAPI.Controllers
{
	using CustomerWebAPI.Models;
	using Microsoft.EntityFrameworkCore;
	using BusinessObjects;

	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		private readonly CustomerContext _customerContext;

		public CustomerController(CustomerContext context)
		{
			_customerContext = context;

			if (_customerContext.customers.Count() == 0)
			{
				_customerContext.customers.Add(new Customer { Id = 1, Name = "Yashita", LongName = "Shah" });
				_customerContext.customers.Add(new Customer { Id = 2, Name = "Pariv", LongName = "Shah" });
				_customerContext.customers.Add(new Customer { Id = 3, Name = "Diyan", LongName = "Shah" });

				_customerContext.SaveChanges();
			}
		}

		// GET api/values
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Customer>>> Get()
		{
			return await _customerContext.customers.ToListAsync();
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Customer>> Get(Int64 id)
		{
			Customer customer = await _customerContext.customers.FindAsync(id);

			if (customer == null)
			{
				return NotFound();
			}

			return customer;
		}

		// POST api/values
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
