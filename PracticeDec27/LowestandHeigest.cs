using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDec27
{
    internal class LowestandHeigst
    {
        void Method1(int a,int b,int c)
        {
            if (a < c)
            {
                if(a < b)
                {
                    Console.WriteLine(a+" Is Small");
                }
            }
            else if(b < a)
            {
                if(b < c) 
                {
                    Console.WriteLine(b+ " Is Small");
                }
            }
            else
            {
                Console.WriteLine(c+ " Is Small");
            }
        }
        void method2(int a,int b,int c) 
        {
            if (a < b && a < c)
            {
                Console.WriteLine(a+" Is Small");
            }
            else if(b<a&&b<c)
            {
                Console.WriteLine(b + " Is Small");
            }
            else {
                Console.WriteLine(c + " Is Small");
                    }
        }
        void method3(int a,int b,int c)
        {
            int min=Math.Min(Math.Min(a,b),c);
            Console.WriteLine(min +" Is Small");
        }
        static void Main(string[] args)
        {
            LowestandHeigst x= new LowestandHeigst();
            //x.Method1(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            //x.method2(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
             //x.method3(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
        
        }

    }
}
