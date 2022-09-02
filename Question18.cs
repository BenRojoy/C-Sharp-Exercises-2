using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execises2
{
    internal class Question18
    {
        public static void Main18()
        {
            int a = 6, i, j, c = 1;

            for (i = 1; i <= a; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write($"{c++} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
