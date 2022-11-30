using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class SwapTwoNumbers
    {
        public void Swap()
        {
            int x = 5, y = 10;
            Console.WriteLine("Before swap x= " + x + " y= " + y);
            x = x + y;
            y = x - y;
            x = x - y;
            Console.Write("After swap x= " + x + " y= " + y);
        }
    }
}
