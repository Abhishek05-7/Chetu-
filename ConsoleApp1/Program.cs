using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void test()
        {
            try
            {
                test1();
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        static void test1()
        {
            try
            {
                test2();
            }
            catch (Exception ex)
            {
                //throw ex;
                throw;
            }
        }

        static void test2()
        {
            try
            {
                test3();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        static void test3()
        {
            Console.WriteLine("Enter First number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int b = int.Parse(Console.ReadLine());
            try
            {
                int c = a / b;
                Console.WriteLine("Value of c = {0}", c);

            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                throw;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                test();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
