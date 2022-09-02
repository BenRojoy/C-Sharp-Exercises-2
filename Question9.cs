using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execises2
{
    internal class Question9
    {
        public static void Main9()
        {
            int x, y;

            Console.Write("Enter x coordinate: ");
            x = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter y coordinate: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the first quadrant");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the second quadrant");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the third quadrant");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the fourth quadrant");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) is the origin");
            }
            else if (x == 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) is on the y-axis");
            }
            else
            {
                Console.WriteLine($"The coordinate point ({x},{y}) is on the x-axis");
            }

            Console.ReadKey();
        }
    }
}
