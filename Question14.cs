using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execises2
{
    internal class Question14
    {
        public static void Main14()
        {
            int a, sum = 0;

            Console.Write("Input the number of terms: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("The odd numbers are: ");
            for(int i = 0; i < a; i++)
            {
                Console.Write($"{i * 2 + 1} ");
                sum += (i * 2 + 1);
            }

            Console.WriteLine($"\nThe sum of odd natural numbers upto {a} terms: {sum}");

            Console.ReadKey();
        }
    }
}
