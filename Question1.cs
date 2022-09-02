using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execises2
{
    internal class Question1
    {
        public static void Main1()
        {
            int a, b;

            Console.Write("Enter the first number: ");
            a = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter the second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine($"{a} and {b} are equal");
            }
            else
            {
                Console.WriteLine($"{a} and {b} are not equal");
            }

            Console.ReadKey();
        }
    }
}
