using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        public virtual void test()
        {
            Console.WriteLine("Program");
        }

        //public void neutral()
        //{
        //    Console.WriteLine("Hello Abhishek Singh");
        //}

    }
    class Program1 : Program
    {
        public new void test()
        {
            Console.WriteLine("Program1");
        }
        public void neutral()
        {
            base.test();
        }


        public static void Main()
        {
            Program1 obj = new Program1();
            //Program p;    // Program p = new Program1();
            //p = obj;

            //p.test();
            obj.neutral();

            Console.ReadLine();
        }
    }
}
