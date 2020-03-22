// When the break statement is encountered inside a loop
// the loop is immediately terminated and the program execution
// moves on to the next statement following the loop body. 

using System;

namespace Break_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=0;
            while(num<20)
            {
                if(num==5)
                    break;

                Console.WriteLine(num);
                num++;
            }
        }
    }
}
// If you are using nested loops (i.e., one loop inside another loop),
// the break statement will stop the execution of the innermost loop
// and start executing the next line of code after the block.
