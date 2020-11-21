using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet5.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Address> Addresses { get; set; }
        //public Employee(List<Address> addresses)
        //{
        //    Addresses = addresses;
        //}
    }
}
