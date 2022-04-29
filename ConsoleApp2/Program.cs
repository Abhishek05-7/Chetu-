using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter A String");
            StringBuilder str = new StringBuilder();
            str.Append("Abhishek");
            str.Append("\tLoves\t");
            str.Append("Himself\t");

            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}
