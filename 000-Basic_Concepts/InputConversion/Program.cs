// The Console.ReadLine() method only returns a string
// If another type of value is expected, the entered data must be converted
// to that Type using the Convert.To--- method (--- stands for any .NET type)
// for Int, there are 3 alternatives, based on bit size: int16, int32, int64.
// Default C# is int32

using System;

namespace InputConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Old are your?");
            
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} years old", age);            
        }
    }
}
