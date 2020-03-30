// The value 42 is passed to the method as an argument and is assigned
// to the formal parameter x.

using System;

namespace Parameter_0
{
    class Program
    {
        static void Print(int x)
        {
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            Print(42);
        }
    }
}
