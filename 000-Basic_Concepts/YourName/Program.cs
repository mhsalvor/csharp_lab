// Asks the users for input, stores it as a string type variable
// then diplays it ina formatted string.

using System;

namespace YourName
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourName;
            Console.WriteLine("What is your name?)");
            
            yourName=Console.ReadLine();

            Console.WriteLine("Hello {0}",yourName);
        }
    }
}
