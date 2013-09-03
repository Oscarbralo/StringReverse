using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "reverse me";

            Console.WriteLine("Original: " + s);
            

            Console.WriteLine();
            Console.WriteLine("Reversed: " + test(s));


            Console.ReadLine();
        }

            

        public static string test(string s)
            {
                string rev = "";
            //print the last index of the string and work your way backwards
                for (int i = 0; i < s.Length; i++)
                {
                    rev = rev + s[s.Length - (i + 1)];
                }
                return rev;
            }
            
    
 

        
    }
}
