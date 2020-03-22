// If the condition of the do-while loop evaluates to false,
// the statements in the do will still run once

using System;

namespace DoWhile_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=42;
            do{
                Console.WriteLine(x);
                x++;
            } while(x<10);
        }
    }
}
