using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("There are 0 args");
            }
            else
            {
                Console.WriteLine($"there are {args.Length} arguments");
            }

            foreach(string s in args){
                Console.WriteLine(s);
            }
        }
    }
}
