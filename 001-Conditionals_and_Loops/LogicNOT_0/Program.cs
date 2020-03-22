// The logical NOT (!) operator works with just a single operand, reversing its logical state

using System;

namespace LogicNOT_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int age=8;
            if (!(age>=16))
                Console.WriteLine("Your age is less than 16");
        }
    }
}
