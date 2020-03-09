// The else-if statement

using System;

namespace ElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
           int x=33;

           if (x==8) {
               Console.WriteLine("The value of x is 8.");
           }
           else if (x==18) {
               Console.WriteLine("The value of x is 18.");
           }
           else if (x==33) {
               Console.WriteLine("The Value of x is 33");
           }
           else {
               Console.WriteLine("No match.");
           }
        }
    }
}
