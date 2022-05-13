using System;

namespace ConsoleApp11
{
    class Example
    {
        string name;
        int age;

        public Example(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Example(Example example)
        {
            this.name = example.name;
            this.age = example.age;
        }
        public void getShow()
        {
            Console.WriteLine("My name is:{0} ", name);
            Console.WriteLine("My age is:{0} ", age);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Example obj = new Example("amit", 23);
            obj.getShow();
            Example obj1 = new Example(obj);
            obj1.getShow();

            Console.WriteLine("Hello World!");
        }
    }
}
