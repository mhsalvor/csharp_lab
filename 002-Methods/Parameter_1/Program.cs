// You can pass different arguments to the same method as long as
// they are of the expected type.

using System;

namespace Parameter_1
{
    class Program
    {
        static void Func(int x)
        {
            Console.WriteLine(x*2);
        }

        static void Main(string[] args)
        {
            Func(5);
            Func(12);
            Func(42);
        }
    }
}
