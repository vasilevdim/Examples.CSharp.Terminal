using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definirane na tabliza
            string[,] table= new string[2, 3];
            //Vavejdane na I red
            table[0, 0] = "Martin";table[0, 1] = "Simeonov"; table[0, 2] = "31";



            // Vavejdane na II red
            table[1, 0] = "Simeon"; table[1, 1] = "Martinov"; table[1, 2] = "41";
            //Pechat
            Console.WriteLine("Koi red iskate da vidite:");

            int _index = Convert.ToInt32(Console.ReadLine()) -1;
            Console.WriteLine((table[_index, 0])[0] + ". " + table[_index, 1] + ", " + table[_index, 2] + "g.");
        }
    }
}
