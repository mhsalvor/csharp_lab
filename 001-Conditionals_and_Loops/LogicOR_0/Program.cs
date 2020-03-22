//he OR operator (||) returns true if any one of its operands is true. 

using System;

namespace LogicOR_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int age=18;
            int score=85;
            if(age>20 || score>50)
                Console.WriteLine("Welcome");
        }
    }
}
//You can join any number of logical OR statements you want.
//In addition, multiple OR and AND statements may be joined together.
