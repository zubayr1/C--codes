using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Test
    {
        public static int num1 = 10;

        public void test()
        {
            string name = "Farha";
            var age = 24;
            float num = 2.14f;

            Console.WriteLine($"her name is {name} and her age is {age}, {num}");

            num1 += 1;

        }

        public void cast(string value, int num)
        {
            double v = num;

            if (int.TryParse(value, out _))
            {
                // String is an integer
                Console.WriteLine("String is an integer.");
            }
            else
            {
                // String is not an integer
                Console.WriteLine("String is not an integer.");
            }
        }

        public int returnnum()
        {
            return num1;
        }

        public static void statmethod()
        {
            Console.WriteLine("static method");
        }
    }

}
