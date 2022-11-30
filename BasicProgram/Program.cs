namespace BasicProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n 1.Flip Coin \n 2.Exit");
                Console.WriteLine("Enter option to execute");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.Coin();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
            
            //LeapYears leapYear = new LeapYears();
            //leapYear.LeapYear();
            //PowerOf2s powerOf2 = new PowerOf2s();
            //powerOf2.PowerOf2();
            //HarmonicSeries harmonic = new HarmonicSeries();
            //harmonic.Harmonic();
            //PrimeFactor primeFactor = new PrimeFactor();
            //primeFactor.Factors();
            //QuotientAndRemainder quotientAndRemainder = new QuotientAndRemainder();
            //quotientAndRemainder.Divider();
            //SwapNumber swapNumber = new SwapNumber();
            //swapNumber.Swap();
            //EvenorOdd evenorOdd = new EvenorOdd();
            //evenorOdd.EvenOdd();
            //VowelsorConsonants vowelsorConsonants = new VowelsorConsonants();
            //vowelsorConsonants.VowelorConsonant();
            //LargestNumber largestNumber = new LargestNumber();
            //largestNumber.LargeNumber();
        }
    }
}