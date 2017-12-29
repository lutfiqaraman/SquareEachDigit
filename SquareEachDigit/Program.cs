using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareEachDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 12345;
            Console.WriteLine(SquareEachDigit(n));
            Console.ReadLine();
        }

        public static int SquareEachDigit(int n)
        {
            string OutPut = "";
            string digits = n.ToString();

            foreach (char digit in digits)
            {
                int number = int.Parse(digit.ToString());
                OutPut += Math.Pow(number, 2);
            }

            n = int.Parse(OutPut);

            return n;
        }
    }
}
