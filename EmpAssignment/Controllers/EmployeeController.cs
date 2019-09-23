using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using EmpAssignment.DataAccessLayer;
using EmpAssignment.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmpAssignment.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		EmployeeDataAccessLayer objemployee = new EmployeeDataAccessLayer();

		// GET: api/Employee
		[HttpGet]
		public IEnumerable<Employee> Get()
		{
			return objemployee.GetAllEmployees();
		}

		[HttpPost]
		[Route("InsertEmployeeDetails")]

		public void Post([FromBody] Employee employee)
		{
			objemployee.AddEmployee(employee);
		}
	}
}