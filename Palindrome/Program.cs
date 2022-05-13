using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter A Number");
            int n = int.Parse(Console.ReadLine());
            int num = n;
            int rev = 0;
            while(n > 0)
            {
                int r = n % 10;
                rev = rev * 10 + r;
                n = n / 10;
            }

            if(num == rev)
            {
                Console.WriteLine("Number Is Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }

            Console.ReadLine();
        }
    }
}
