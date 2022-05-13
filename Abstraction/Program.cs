using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
   abstract class Program
    {
        public abstract void GetArea(); 

        public void show()
        {
            Console.WriteLine(" This is non-abstract method in a abstract class");
        } 
    }

    class child : Program
    {
        public override void GetArea()
        {
            double area ;
            Console.WriteLine("Enter the radius");
            int r =int.Parse(Console.ReadLine());
            Console.WriteLine("The radius of circle is = " + r);
            double pi = 3.14;
            area = pi * r * r;
            Console.WriteLine("Area of square {0}", area);
        }
        static void Main()
        {
            child objc = new child();

            objc.show();
            objc.GetArea();
            
            Console.ReadLine();
        }
    }

    class child1 : Program 
    {
        public override void GetArea()
        {
            int l, b;
            Console.WriteLine("Enter Length And Breadth");
            l = int.Parse(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int area = l * b;
            Console.WriteLine("Area of Reactangle = {0}", area);
        }
        
        static void Main()
        {
            child1 obj = new child1();
            obj.GetArea();
            Console.ReadLine();
        }
    }
}
