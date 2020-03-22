// Exp1 ? Exp2 : Exp3;
// Exp1 is evaluated. If it is true,
// then Exp2 is evaluated and becomes the value of the entire expression.
// If Exp1 is false,
// then Exp3 is evaluated and its value becomes the value of the expression.

using System;

namespace ConditionalOp_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int age=42;
            string msg;
            msg=(age>=18) ? "Welcome" : "Sorry";
            Console.WriteLine(msg);
        }
    }
}
