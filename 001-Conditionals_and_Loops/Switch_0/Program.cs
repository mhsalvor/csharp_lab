//  Switch, a more elegant way of evaluating the value of a variable:
// Each "case" statement MUST end with a "break" directive, otherwise 
// the compiler will return an error. 

using System;

namespace Switch_0
{
    class Program
    {
        static void Main(string[] args)
        {
           int num=3;
            switch (num) {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
            }
        
        }
    }
}
