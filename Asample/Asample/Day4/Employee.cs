using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asample.Day4
{
    public enum City { Chennai,Banglore,Hyderabad,Pune}
    public enum Designation { Manager,Admin,Developer}
    internal class Employee
    {
        public readonly int Eid;
        public string Ename=String.Empty;
        public City Ecity; //public string Ecity;

        public Designation JobTitle; // public string JobTitle
        public Employee(int v1){ Eid = v1; }
        public override string ToString()
        {
            String output = String.Empty;
            output = $"Details of the employee are: {Eid}{Ename}{Ecity}{JobTitle}";
            return output ;
            
        }

    }
    class TestEmployee
    {
           public static void TestOne()
        { 
            Employee e1= new Employee(348);
            e1.Ename = "John";
            e1.Ecity = City.Banglore;
            e1.JobTitle = Designation.Developer;
            String output = e1.ToString();
            Console.WriteLine(output);
        }
    }
    
}

