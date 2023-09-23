using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Asample.Day2
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } =String.Empty;
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Title { get; set; } = String.Empty;

        public string Address { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;
        public string Region { get; set; } = String.Empty;
        public string PostalCode { get; set; } = String.Empty;
        public string Country { get; set; } = String.Empty;
        public long Phone { get; set; }
        public override string ToString()
        {
            return $"ID:{this.Id},Name:{FirstName}.{LastName},\n" +
                $"Address: { Address},City: { City},State: {Region},\n" +
                $" Phone: { Phone},Country: { Country},Zip: { PostalCode} ";
        }

    }
    internal class TestPerson
    {
        public static void TestOne()
        {
            Person firstPerson = new Person();
            firstPerson.Id = 1;
            firstPerson.FirstName = "Geethu";
            firstPerson.LastName = "N";
            firstPerson.Title = "ms";
            firstPerson.Address = "Villivakkam";
            firstPerson.City = "chennai";
            firstPerson.Region = "TamilNadu";
            firstPerson.PostalCode = "600049";
            firstPerson.Country = "India";
            firstPerson.Phone = 861084853;
            string value=firstPerson.ToString();
            Console.WriteLine(value);

        }
    }
}
