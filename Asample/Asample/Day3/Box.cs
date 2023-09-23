using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asample.Day3
{
    internal class Box
    {
        public int height;
        public int length;
        public int width;
        public Box(int x) //constructor
        {
            Console.WriteLine("Box Object Created");
        }
        public void Open()
        {
            Console.WriteLine("Box is Open");
        }
        public void Close()
        {
            Console.WriteLine("Box is Closed");
        }
        public override string ToString()
        {
            return $"Height:{height}, Length:{length},Width:{width}";
        }
    }
    internal class WoodenBox : Box
    //inheritance = childclass:parent class
    {
        public int Area;
        public WoodenBox():base(1)
        {
            Console.WriteLine("WoodenBox Constructor");
        }
        public WoodenBox(int x) :base(x)
        {
            Console.WriteLine("WoodenBox Constructor");
        }
        public WoodenBox(int x, int y) :base(x)
        {
            Console.WriteLine("WoodenBox Constructor");
        }
        public void Move()
            {
            Console.WriteLine("WoodenBox shifted");
        }
        public override string ToString()
        {
            return $"Tom and Jerry";
        }
    }
    internal class BoxTester
    {
        public static void TestOne()
        {
            Box box = new Box(1);
            box.height = 10;
            box.width = 20;
            box.length = 30;
            box.Open();
            box.Close();
            string output = box.ToString();
            Console.WriteLine(output);

        }
        public static void TestTwo()
        {
            WoodenBox box = new WoodenBox();
            box.height = 40;
            box.width = 50;
            box.length = 60;
            box.Open();
            box.Close();
            string output = box.ToString(); //Tom and Jerry
            Console.WriteLine(output);
            box.Area = 250;
            box.Move();


        }

        public static void TestThree()
        {
            Box box = new WoodenBox();
            box.height = 70;
            box.width = 80;
            box.length = 90;
            box.Open();
            box.Close();
            string output = box.ToString();  //Tom and Jerry
            Console.WriteLine(output);
            //box.Area = 250;
            //box.Move();


        }
    }
}