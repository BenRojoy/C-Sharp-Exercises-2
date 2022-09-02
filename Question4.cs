using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execises2
{
    internal class Question4
    {
        public static void Main4()
        {
            int a;

            Console.Write("Enter the year: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 400 == 0)
            {
                Console.WriteLine($"{a} is a leap year");
            }
            else if (a % 100 == 0 || a % 4 != 0)
            {
                Console.WriteLine($"{a} is not a leap year");
            }
            else
            {
                Console.WriteLine($"{a} is a leap year");
            }

            Console.ReadKey();
        }
    }
}
