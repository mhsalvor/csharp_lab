// Methods can be called many times

using System;

namespace Method_1
{
    class Program
    {
        static void sayHi()
        {
            Console.WriteLine("Hello");
        }
        static void Main(string[] args)
        {
            sayHi();
            sayHi();
            sayHi();
        }
    }
}
