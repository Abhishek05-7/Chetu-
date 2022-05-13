using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number");
            int num = int.Parse(Console.ReadLine());
            Boolean b = false;
            if (num > 0)
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine("Number Is Not Prime");
                        b = true;
                        break;
                    }

                }
                if (b == false)
                {
                    Console.WriteLine("Number Is Prime");
                }
            }
            else
            {
                Console.WriteLine("Number Is ZERO or Less Than Zero");
            }

            Console.ReadLine();
        }
    }
}
