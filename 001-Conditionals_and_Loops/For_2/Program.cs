// You can also decrement the counter

using System;

namespace For_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x=10; x>0; x-=2)
                Console.WriteLine("The value of x is: {0}",x);
        }
    }
}
