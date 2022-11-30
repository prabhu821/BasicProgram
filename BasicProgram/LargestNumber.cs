using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class LargestNumber
    {
        public void LargeNumber()
        {
            int a, b, c;
            Console.WriteLine("largest among three numbers:");
            Console.WriteLine("Enter value for a :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for c:");
            c = Convert.ToInt32(Console.ReadLine());
            if ((a > b) && (a > c))
            {
                Console.WriteLine("{0} is largest value", a);
            }
            else if ((b > a) && (b > c))
            {
                Console.WriteLine("{0} is largest value", b);
            }
            else
            {
                Console.WriteLine("{0} is largest value", c);

            }
        }
    }
}
