using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
     public class Program
    {
        public static void M1()
        {
            Console.WriteLine("Hii");
        }
        internal static void M2()
        {
            Console.WriteLine("Hello Sir");
        }
        private static void M3()
        {
            Console.WriteLine("Good evening Sir");
        }
        protected static void M4()
        {
            Console.WriteLine("How R U");
        }
        protected internal static void M5()
        {
            Console.WriteLine("I am fine Sir");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            M1();
            M2();
            M3();
            M4();
            M5();
        }
    }
}
