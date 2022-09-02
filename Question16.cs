using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execises2
{
    internal class Question16
    {
        public static void Main16()
        {
            int a = 6, i, j;

            for (i = 1; i <= a; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write($"{j}");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
