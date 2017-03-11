using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string usercommand = " ";string test = "  ";
            do
            {
                Console.WriteLine("$ "); usercommand = Console.ReadLine();
                if (usercommand.Contains("test")) test (usercommand);
            } while (usercommand != "exit");
        }
    }
}
