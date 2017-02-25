using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolExplore
{
    class Program
    {
        static void Main(string[] args)
        {
            bool _b = true;
            bool _test = 5 > 10;
            int[] _i = new int[] { 4, 3, 2 };
            int _ui = 0;//Convert.ToInt32(Console.ReadLine());
            String _input = "0";
            Console.Write("Please insert index:");
            _input = Console.ReadLine();
            bool _check01 = int.TryParse(_input, out_ui);
            bool _check02 = _ui <= int.Lenght;
            bool _check03 = _ui > 0;
            if (_check01 && _check02 && _check03)
            {
                Console.WriteLine(_i[_ui - 1]);

                if (!_check01)
                {
                    Console.WriteLine("Index has to be integer\n\n\n");

                    if (!_check02)
                    {
                        Console.WriteLine("Index too high\n\n\n");

                        if (!_check03 && _check01)
                        {
                            Console.WriteLine("Index too low\n\n\n");

                            //Console.WriteLine("Logic AND:"+_exp01.ToString());
                            //Console.WriteLine("LOgic OR:"+ _exp02.ToString());
                            //Console.WriteLine("NOT OF "+_check01.ToString()+": "+_exp03);

                        }
                    }
                }
            }
        }
    }
}