using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class QuotientAndRemainder
    {
        public int Divider()
        {
            Console.Write("Enter the Dividend value = ");
            int N = Convert.ToInt32(Console.ReadLine());
            return N;
        }
        public int EnterDividend()
        {
            Console.Write("Enter the Divisor value  = ");
            int M = Convert.ToInt32(Console.ReadLine());
            return M;
        }
        public void FindValue()
        {
            int dividend = Divider();
            int divisor = EnterDividend();
            int quoitent = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Quoitent is : " + quoitent);
            Console.WriteLine("Remainder is : " + remainder);

        }
    }
}
