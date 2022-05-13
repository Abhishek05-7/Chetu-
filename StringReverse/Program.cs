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
            Console.WriteLine("Enter A String");
            String str = Console.ReadLine();
            String s = " ";
            int L = str.Length - 1;
            for(int i = L; i >= 0; i--)
            {
                s += str[i];
            }
            Console.WriteLine("Reverse of string is {0}", s);
            Console.ReadLine();
        }
    }
}
