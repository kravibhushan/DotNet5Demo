using Oops.Models;
using System;
using System.Collections.Generic;
//using System.Linq;

namespace Oops
{
    public class PracticeCollection
    {
        SortedDictionary<int, Customer> dicCustomer = null;
        List<Customer> lstCustomer = null;

        public PracticeCollection()
        {
            dicCustomer = new SortedDictionary<int, Customer>();
            lstCustomer = new List<Customer>();

            Customer cust = null;
            for (int i = 0; i < 100; i++)
            {
                cust = new Customer();
                Random ran = new Random();
                cust.Age = ran.Next(1, 50);
                cust.FirstName = "FirstName" + i;
                cust.LastName = "LastName" + i;
                dicCustomer.Add(1, cust);
                lstCustomer.Add(cust);
            }
        }
        public void TestSort() 
        {
           
        }
    }
}
