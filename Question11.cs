using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execises2
{
    internal class Question11
    {
        public static void Main11()
        {
            int a;

            Console.Write("Input number of terms: ");
            a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine($"Number is: {i} and the cube of {i} is: {i * i * i}");
            }

            Console.ReadKey();
        }
    }
}
