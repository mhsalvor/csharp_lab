// The continue statement is similar to the break statement,
// but instead of terminating the loop entirely,
// it skips the current iteration of the loop and continues with the next iteration.

using System;

namespace Continue_0
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<10;i++)
            {
                if(i==5)
                    continue;
                
                Console.WriteLine(i);
            }
        }
    }
}
