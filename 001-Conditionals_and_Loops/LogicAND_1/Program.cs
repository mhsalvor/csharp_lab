// You can join more than two conditions. 
// The entire expression evaluates to true only if all of the conditions are true.

using System;

namespace LogicAND_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age=42;
            int grade=75;
            if(age>16 && age<80 && grade>50)
                Console.WriteLine("Hey There!");
        }
    }
}
