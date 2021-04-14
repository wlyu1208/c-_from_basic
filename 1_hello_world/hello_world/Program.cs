using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            * writeline automatically has new line at the end ("\n")
            * diff between writeline and write
             */
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello C#");
            // Console.Write("Hello C#);

            /* 
             * will print 0 since there is no argument
             * go to bin - debug - net - execute "hello_world.exe test1 test2" in powershell will print 2 at the end
             */
            //will print 0 since there is no argument
            Console.WriteLine(args.Length);
            

        }
    }
}
