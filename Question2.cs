using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execises2
{
    internal class Question2
    {
        public static void Main2()
        {
            int a;

            Console.Write("Enter the number: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} is an even integer");
            }
            else
            {
                Console.WriteLine($"{a} is an odd integer");
            }

            Console.ReadKey();
        }
    }
}
