using System;

namespace Oops.Models
{
    public class Customer:IComparable<Customer>
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int CompareTo(Customer c)
        {
            int result = 0;
            if (c == null)
            {
                result = 1;
            }
            else if (this.CustomerId > c.CustomerId)
            {
                result = 1;
            }
            else if (this.CustomerId < c.CustomerId)
            {
                result = -1;
            }
            else if (this.CustomerId == c.CustomerId)
            {
                result = 0;
            }
            return result;
        }
    }
}
