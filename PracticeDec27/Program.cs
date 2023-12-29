using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDec27
{
    internal class Prime
    {
         bool primeNumber(int number) 
        {
                int c = 0;
            for(int i = 1; i <=number; i++) 
            {
                if (number % i == 0)
                {
                    c++;
                }
            }
            if(c==2)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Prime p = new Prime();
            if (p.primeNumber(Convert.ToInt32(Console.ReadLine())))
            {
                Console.WriteLine("Prime Number");
            }
            else 
            {
                Console.WriteLine("Not a prime Number");
            }
        }
    }
}
