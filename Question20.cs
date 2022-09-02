using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execises2
{
    internal class Question20
    {
        public static void Main()
        {
            int a = 4, i, j;

            for (i = 1; i <= a; i++)
            {
                for (j = a; j > i; j--)
                {
                    Console.Write(' ');
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
