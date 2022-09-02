using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execises2
{
    internal class Question3
    {
        public static void Main3()
        {
            int a;

            Console.Write("Enter the number: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine($"{a} is a positive number");
            }
            else if (a < 0)
            {
                Console.WriteLine($"{a} is a negative number");
            }
            else
            {
                Console.WriteLine($"{a} is neither positive nor negative");
            }

            Console.ReadKey();
        }
    }
}
