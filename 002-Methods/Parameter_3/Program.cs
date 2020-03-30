// The return value can be assigned to a variable.

using System;

namespace Parameter_3
{
    class Program
    {
        static int Sum(int x, int y)
        {
            return x+y;
        }
        static void Main(string[] args)
        {
            int res=Sum(11, 42);
            Console.WriteLine(res);
        }
    }
}
