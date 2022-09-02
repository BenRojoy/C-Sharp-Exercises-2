using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execises2
{
    internal class Question15
    {
        public static void Main15()
        {
            int a = 6, i, j;

            for (i = 0; i < a; i++)
            {
                for (j = 0; j <=i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
