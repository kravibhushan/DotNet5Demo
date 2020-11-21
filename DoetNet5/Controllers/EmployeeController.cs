using DotNet5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("1.1", Deprecated = true)]
    [ApiVersion("2.0")]
    public class EmployeeController : ControllerBase
    {
        //Version 1.0 is with employee address
        [MapToApiVersion("1.0")]
        public async Task<List<Employee>> Get()
        {
            List<Employee> lstEmployee = new List<Employee>();
            lstEmployee = lstEmployee.Select(x=> new Employee { EmpId=x.EmpId,LastName=x.LastName,FirstName=x.FirstName} ).ToList();
            return lstEmployee;
        }

        [MapToApiVersion("2.0")]
        public List<Employee> GetWithAddress()
        {
            List<Employee> lstEmployee = new List<Employee>();
            return lstEmployee;
        }
    }
}
