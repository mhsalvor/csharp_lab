//The init and increment statements may be left out, if not needed, but remember that the semicolons are mandatory.
// for(;;){} is an infinite loop

using System;

namespace For_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=10;
            for (;x>0;)
            {
                Console.WriteLine(x);
                x-=3;
            }
        }
    }
}
