using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class HarmonicNumber
    {
        public int InputValue()
        {
            Console.WriteLine("Enter the Number to find the Harmonic value : ");
            int N = Convert.ToInt32(Console.ReadLine());
            return N;
        }
        public void Harmonic()
        {
            int N = InputValue();
            float harmonic = 1;
            for (int i = 2; i < N; i++)
            {
                harmonic += (float)1 / N;
            }
            Console.WriteLine("The Nth Harmonic Value of " +N+ " : " + harmonic);
        }
    }
}
