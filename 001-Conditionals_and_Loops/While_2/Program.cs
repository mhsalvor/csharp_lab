// we can increment the value of num right in the condition;
// also, as with the if statement, in case of 1 line blocks we can omitt the {}

using System;

namespace While_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=1;
            while (++num<6)
                Console.WriteLine(num);
        }
    }
}
