using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CA1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("several lines of text");
            //Console.WriteLine("several lines of more text");
            //Console.WriteLine("and even more lines of text");
            
            string[] lines = File.ReadAllLines(@"D:\CTEC\CONSOLEAPPS\console-apps-smcilvenny\MyConsoleApp\bonus.txt");
            args = lines;

            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
