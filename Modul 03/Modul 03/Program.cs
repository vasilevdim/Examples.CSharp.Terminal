using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_03
{
    class Program
    {
        static void Main(string[] args)
        { 
            double a = 0, b = 0, c = 0;
        Console.Write("<a="); a = Convert.ToDouble( Console.ReadLine ());
        Console.Write ("<b="); b= Convert.ToDouble( Console.ReadLine ());
            //Formatirane s dimensia
            
            //Stepenuvane
            c = Math.Pow(a, b);
            Console.WriteLine("\n\n>a^b=" + c.ToString());
            c = Math.Sqrt(b);
            Console.WriteLine("\n\n>b^1/2=" + c.ToString());
            c = Math.Round(a/b);
            Console.WriteLine("\n\n>(a/b)=" + c.ToString());



        }
    }
}