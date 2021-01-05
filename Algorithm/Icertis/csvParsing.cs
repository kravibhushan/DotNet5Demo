using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Icertis
{
    public class SaleValues
    {
        public string BuyerName;
        public string Address;
        public string Quantity;
        public string Product;
        public Int32 Price;
        public string ModeOfPayment;

        public SaleValues()
        {

        }
        public static SaleValues FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            SaleValues saleValues = new SaleValues();

            saleValues.BuyerName = Convert.ToString(values[0]);
            saleValues.Address = Convert.ToString(values[1]);
            saleValues.Quantity = Convert.ToString(values[2]);
            saleValues.Product = Convert.ToString(values[3]);
            saleValues.Price = Convert.ToInt32( Convert.ToString(values[4]).Replace("Rs","").Trim());
            saleValues.ModeOfPayment = Convert.ToString(values[5]);
            return saleValues;
        }
        public List<SaleValues> GetDataFromCSV()
        {
            List<SaleValues> values = File.ReadAllLines(@"E:\Git Repo\DotNet5Demo\Algorithm\Icertis\data.csv")
                                           .Skip(1)
                                           .Select(v => SaleValues.FromCsv(v))
                                           .ToList();
            return values;
        }
    }
}
