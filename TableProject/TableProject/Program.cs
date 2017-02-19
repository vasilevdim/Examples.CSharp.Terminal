using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableProject
{
    class Program { 
        enum ti {ime, familia, godini };
    
        static void Main(string[] args)
        {
            //Definirane na tabliza
            string[,] table= new string[2, 3];
            //Vavejdane na I red
            table[0, (int)ti.ime] = "Martin";table[0, (int)ti.familia] = "Simeonov"; table[0,(int) ti.godini] = "31";



            // Vavejdane na II red
            table[1, (int)ti.ime] = "Simeon"; table[1,(int) ti.familia] = "Martinov"; table[1,(int) ti.godini] = "41";
            //Pechat
            Console.WriteLine("Koi red iskate da vidite:");

            int _index = Convert.ToInt32(Console.ReadLine()) -1;
            Console.WriteLine(
            (table[_index, (int)ti.ime])[0] + ". " + 
             table[_index,(int) ti.familia] + ", " + 
             table[_index,(int) ti.godini] + "g.");
        }
    }
}
