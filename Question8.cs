using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execises2
{
    internal class Question8
    {
        public static void Main8()
        {
            int a, b, c;

            Console.Write("Enter the first number: ");
            a = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter the second number: ");
            b = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter the third number: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("The first number is the greatest among the three");
                }
                else
                {
                    Console.WriteLine("The third number is the greatest among the three");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("The second number is the greatest among the three");
                }
                else
                {
                    Console.WriteLine("The third number is the greatest among the three");
                }
            }

            Console.ReadKey();
        }
    }
}
