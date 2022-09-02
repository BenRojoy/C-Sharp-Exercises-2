using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execises2
{
    internal class Question10
    {
        public static void Main10()
        {
            int phy, chem, math, total, subTotal;

            Console.Write("Input the marks obtained in Physics: ");
            phy = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input the marks obtained in Chemistry: ");
            chem = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input the marks obtained in Maths: ");
            math = Convert.ToInt32(Console.ReadLine());

            total = phy + chem + math;
            subTotal = phy + math;

            if (phy < 55 || chem < 50 || math < 65 || (total < 180 && subTotal < 140))
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }

            Console.ReadKey();
        }
    }
}
