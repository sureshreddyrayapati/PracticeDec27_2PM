using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDec27
{
    public class upTolp
    {
       static string titleCase(string s)
        {
            string w = "";
            string[] s1= s.Split(' ');
            for(int  i=0; i < s1.Length; i++)
            {
                string s3= s1[i];
                for (int j = 0; j < s3.Length; j++)
                {
                    if (j == 0)
                    {
                        w = w + char.ToUpper(s3[0]);
                    }
                    else
                    {
                        w = w + char.ToLower(s3[j]);
                    }
                }
                w = w + " ";
            }
            return w;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String\n");
            string s = Console.ReadLine();
            string w = "";
            for (int i = 0; i < s.Length; i++)
            {
                char[] ch=s.ToArray();
                if (ch[i] >= 'a' && ch[i] <= 'z')
                {
                    w = w + Char.ToUpper(ch[i]);
                }
                else 
                {
                    w = w + char.ToLower(ch[i]);
                }
            }
            Console.Write("\nUpper To Lower and Lower To Upper--> ");
            Console.WriteLine(w+" \n");

            Console.WriteLine("Title case---> "+ titleCase(s)+"\n"); 
        }
    }
}

