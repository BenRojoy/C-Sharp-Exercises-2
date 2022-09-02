using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execises2
{
    internal class Question6
    {
        public static void Main6()
        {
            int m, n;

            Console.Write("Enter the number: ");
            m = Convert.ToInt32(Console.ReadLine());

            if (m > 0)
            {
                n = 1;
            }
            else if (m < 0)
            {
                n = -1;
            }
            else
            {
                n = 0;
            }

            Console.WriteLine($"The value of n = {n}");

            Console.ReadKey();
        }
    }
}
