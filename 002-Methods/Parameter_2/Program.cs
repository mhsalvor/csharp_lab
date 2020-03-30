// A *method* can call multiple *parameters*.
// Multiple arguments must be separated by commas.

using System;

namespace Parameter_2
{
    class Program
    {
        static int Sum(int x, int y)
        {
            return x+y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(8, 6));
        }
    }
}
