using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Program
    {
     
            public void function()
            {
                Console.WriteLine("Hi I'm public");
            }
            private void function1()
            {
                Console.WriteLine("Hi I'm Private");
            }
            protected void function2()
            {
                Console.WriteLine("Hi I'm Protected");
            }
            protected internal void function3()
            {
                Console.WriteLine("Hi I'm Protected internal");
            }
            internal void function4()
            {
                Console.WriteLine("Hi I'm Internal");
            }

            static void Main(string[] args)
            {
                Program b = new Program();
                b.function();
            b.function1();
            b.function2();
            b.function3();
            b.function4();
                Console.ReadLine();
        }
    }
}

   
