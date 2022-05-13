using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        public void sum()
        {
            int a = 2 + 2;
            Console.WriteLine(a);
        }       
    }

    interface interface1
    {
        void test();
    }

    interface interface2
    {
         void test();
    }
    class child : Program,interface1,interface2
    {
       void interface1.test()
        {
            Console.WriteLine("interface1");

        }

       void interface2.test()
        {
            Console.WriteLine("interface2");

        }
        static void Main(string[] args)
        {
            child c = new child();
            interface2 ij = c;

            c.sum();
            ij.test();

            Console.ReadLine();
        }
    }

    class children : child
    {
        public static void Main()
        {
            children C = new children();
            interface2 j = C;
            j.test();
        }
    }
    static class Exit
    {
        public static void testExt(this Program P)
        {
            int dif = 4 - 2;
            Console.WriteLine(dif);
        }
        static void Main()
        {
            Program objp = new Program();
            objp.testExt();

            Console.ReadLine();
        }
    }
}
