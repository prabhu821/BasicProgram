using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class VowelOrConsonant
    {
        public void VowelorConsonant()
        {
            char ch;
            Console.WriteLine("Enter the alphabet:");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("{0} is vowel", ch);
            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'z'))
            {
                Console.WriteLine("{0} is consonant", ch);
            }
        }
    }
}
