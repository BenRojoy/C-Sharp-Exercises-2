using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execises2
{
    internal class Question7
    {
        public static void Main7()
        {
            int h;

            Console.Write("Enter height in cms: ");
            h = Convert.ToInt32(Console.ReadLine());

            if (h < 140)
            {
                Console.WriteLine("The person is dwarf");
            }
            else if (h < 160)
            {
                Console.WriteLine("The person is short");
            }
            else if (h < 180)
            {
                Console.WriteLine("The person is medium");
            }
            else if (h < 200)
            {
                Console.WriteLine("The person is tall");
            }
            else
            {
                Console.WriteLine("The person is very tall");
            }

            Console.ReadKey();
        }
    }
}
