using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleTest
{

    class Program
    {
        class tt
        {
            public void Print1()
            {
                Console.WriteLine("the delegate type which is equal");
            }
            public void Print2()
            {
                Console.WriteLine("the change of the future");
            }
        }
        delegate void PrintFunction();
        static void Main(string[] args)
        {
            tt t = new tt();
            PrintFunction pf = t.Print1;
            pf += t.Print2;
            pf();
            
        }
    }
}
