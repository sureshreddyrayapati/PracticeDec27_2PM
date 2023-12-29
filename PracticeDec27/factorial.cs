using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDec27
{
    internal class factorial
    {
        void fact(int a)
        {
            int fact = 1;
            for (int i = 1; i <= a; i++) 
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
        static void Main(string[] args) 
        {
            factorial factorial = new factorial();
            factorial.fact(5);
        }
    }
}
