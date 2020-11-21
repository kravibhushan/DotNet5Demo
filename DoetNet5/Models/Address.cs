using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet5.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string LandMark { get; set; }
        public string AreaCode { get; set; }
        public string BuildingName { get; set; }
        public string FlatNumber { get; set; }
        public bool IsPrimaryAddress { get; set; }
    }
}
