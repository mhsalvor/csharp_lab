// A do-while loop is similar to a while loop,
// except that a do-while loop is guaranteed to execute at least one time.

using System;

namespace DoWhile_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            do {
                Console.WriteLine(a);
                a++;
            } while (a<5);
        }
    }
}
