using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Asample.Day1
{
    internal class Statements
    {
        public static void TestOne()
        {
            Console.WriteLine("Enter your age");
            String ageAsString = Console.ReadLine();
            if (!IsNumeric(ageAsString))
            {
                return;
            }
            int age = int.Parse(ageAsString);
            if (age < 18)
            {
                Console.WriteLine("You can't drive");
            }
            else
            {
                Console.WriteLine("You can drive");
            }
        }
        public static bool IsNumeric(String pValue)
        { 
            bool result = false;
                if (pValue == null)
                {
                    Console.WriteLine("Invalid string . value is NULL");
                    return false;

                }
                char[] data = pValue.ToCharArray();
                int length = data.Length;
                for(int i=0; i<length;i++)
                {
                    char c1= data[i];
                    int ascii= (int)c1;
                    if (ascii < 48 || ascii >  57)
                    {
                        Console.WriteLine("value is not a number");
                        return false;
                    }
                }
            result = true;  
            return result;  

        }
    }
}
