using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, sum = 0;
            Console.WriteLine("Enter Number of Terms");
            int n = int.Parse(Console.ReadLine());
            Console.Write(a+" "+ b);
            for (int i = 2; i < n; i++)
            {
                sum = a + b;
                Console.Write(" " + sum);
                a = b;
                b = sum;
               // Console.Write(" " + sum);
            }

            Console.ReadLine();
        }
    }
}
