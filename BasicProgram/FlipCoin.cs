using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class FlipCoin
    {
        int headcount = 0;
        int tailcount = 0;
        double headpercentage = 0;
        double tailpercentage = 0;
        public void Coin()
        {
            Console.WriteLine("Enter The Value For Number of Flips ");
            int numberofFlip = Convert.ToInt32(Console.ReadLine());
            if (numberofFlip > 0)
            {
                for (int i = 0; i < numberofFlip; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.WriteLine(number);
                    if (number == 0)
                    {
                        tailcount = tailcount + 1;
                    }
                    else
                    {
                        headcount++;
                    }
                }
                headpercentage = headcount + 100 / numberofFlip;
                tailpercentage = tailcount + 100 / numberofFlip;
                Console.WriteLine("Head Percentage " + headpercentage);
                Console.WriteLine("Tail Percentage " + tailpercentage);
            }
            else
            {
                Console.WriteLine("The number of Flip is not Valid");
                Console.ReadLine();
            }
        }
    }
}
