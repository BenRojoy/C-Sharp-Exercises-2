using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execises2
{
    internal class Question5
    {
        public static void Main5()
        {
            int a;

            Console.Write("Enter the age: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a >= 18)
            {
                Console.WriteLine("Congratulations! You are eligible for casting your vote.");
            }
            else
            {
                Console.WriteLine("Sorry, you are not eligible for casting your vote.");
            }

            Console.ReadKey();
        }
    }
}
