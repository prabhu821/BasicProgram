namespace BasicProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter your choice \n1.Flip Coin \n2.Leap Year \n3.Power Of Two " +
                    "\n4.Harmonic Number \n5.Factors \n6.Quotient And Remainder \n7.SwapTwoNumbers " +
                    "\n8.Enen Or Odd \n9.Vowel or Consonant \n10.Largest Among Three Numbers \n11.Exit");
                Console.WriteLine("\nEnter option to execute");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.Coin();
                        break;
                    case 2:
                        LeapYear leapYear = new LeapYear();
                        leapYear.Year();
                        break;
                    case 3:
                        PowerOfTwo power = new PowerOfTwo();
                        power.Power();
                        break;
                    case 4:
                        HarmonicNumber harmonic = new HarmonicNumber();
                        harmonic.Harmonic();
                        break;
                    case 5:
                        Factors factor = new Factors();
                        factor.Factor();
                        break;
                    case 6:
                        QuotientAndRemainder quotientAndRemainder = new QuotientAndRemainder();
                        quotientAndRemainder.FindValue();
                        break;
                    case 7:
                        SwapTwoNumbers swapNumber = new SwapTwoNumbers();
                        swapNumber.Swap();
                        break;
                    case 8:
                        EvenOrOdd evenorOdd = new EvenOrOdd();
                        evenorOdd.EvenOdd();
                        break;
                    case 9:
                        VowelOrConsonant vowelorConsonant = new VowelOrConsonant();
                        vowelorConsonant.VowelorConsonant();
                        break;
                    case 10:
                        LargestNumber largestNumber = new LargestNumber();
                        largestNumber.LargeNumber();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}