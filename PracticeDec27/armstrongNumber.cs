using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDec27
{
     class armstrongNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n=Convert.ToInt32(Console.ReadLine());
            int number = n, c1=0,arm=0;
            while (n > 0)
            {
                n = n / 10;
                c1++;
            }
            n = number;
            while (n > 0)
            {
                int x = n % 10;
                arm=arm+(int)Math.Pow(x,c1);
                n = n / 10;
            }
            if (number == arm)
            {
                Console.WriteLine("\nGiven Number is Armstrong Number\n");
            }
            else
            {
                Console.WriteLine("\nNot a Armstrong Number\n");
            }
        }
    }
}
