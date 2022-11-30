using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Factors
    {
        public void Factor()
        {
            int count = 0;
            Console.Write("Enter Number to find the prime factors : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 3; i <= num; i++)
            {
                if (num % i == 0)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 2)
                    {
                        Console.WriteLine("Prime Factor of Number {0} is: {1}", num, i);
                    }

                }
            }
        }
    }
}
