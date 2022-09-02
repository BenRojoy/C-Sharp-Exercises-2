using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execises2
{
    internal class Question12
    {
        public static void Main12()
        {
            int a;

            Console.Write("Input the number (table to be calculated): ");
            a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{a} x {i} = {a * i}");
            }

            Console.ReadKey();
        }
    }
}
