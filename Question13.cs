using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execises2
{
    internal class Question13
    {
        public static void Main13()
        {
            int a, i, j;

            Console.Write("Input upto the table number starting from 1: ");
            a = Convert.ToInt32(Console.ReadLine());

            for(i = 1; i <= 10; i++)
            {
                for (j = 1; j < a; j++)
                {
                    Console.Write($"{j} x {i} = {j*i}, ");
                }
                Console.Write($"{j} x {i} = {j * i}\n");
            }

            Console.ReadKey();
        }
    }
}
