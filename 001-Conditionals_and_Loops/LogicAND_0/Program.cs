// With the AND operator, both operands must be true for the entire expression to be true.

using System;

namespace LogicAND_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int age=42;
            double money=540;
            if(age>18 && money>100)
                Console.WriteLine("Welcome");
        }
    }
}
