using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asample.Day2
{
    internal class Bill
    {
        public int Billno { get; set; }
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public long Amount { get; set; }
        public string City { get; set; } = String.Empty;
        public long Phone { get; set; }
        public override string ToString()
        {
            return $" Billno:{this.Billno},Name:{FirstName}.{LastName},\n" +
                $"Amount:{Amount}\n" +
                $"Phone:{Phone}\n" +
                $"City:{City}";


        }
    }
internal class TestBill
    {
        public static void TestOne()
        {
            Bill firstBill = new Bill();
            firstBill.Billno = 1;
            firstBill.FirstName = "Geethu";
            firstBill.LastName = "N";
            firstBill.Amount = 500;
            firstBill.City = "Chennai";
                firstBill.Phone = 212344556;
            string value=firstBill.ToString();
            Console.WriteLine(value);
        }
    }
}
