using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul04
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //Definition
            int i = 0;
            string _userinput = "";
            List<int> _List = new List<int>();
            _List.Add(5);
            _List.Add(3);
            _List.Add(9);

            do
            {
                Console.Write("? ");
                _userinput = Console.ReadLine();
                if (_userinput.Contains("show")) ;
                {
                    for (i = 0; i < _List.Count; i++)
                    {
                        Console.Write("_list:");
                        Console.Write(_List[i]);
                        if (i != _List.Count - 1) Console.Write(",");
                    }
                 


                    //User's input 
                }

            } while (_userinput != "exit");

        }
    } }
