using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolExplore2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] _i = new int[] { 4, 3, 2 };
            int _ui = 0;
            string _input = "0";
            Console.Write("Please insert index:");
            _input = Console.ReadLine();
            bool _check01 = int.TryParse(_input, out _ui);
            { 



                _ui = (_ui <= _i.Length) ? _ui : 3;
                _ui = (_ui > 0) ? _ui : 1;

                switch (_ui) {
                    case 1:
                        {
                            Console.Write("First array element is:");
                            Console.WriteLine(_ui [_ui-1]);
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Second array element is:");
                            Console.WriteLine(_ui [_ui-1]);
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Third array element is:");
                            Console.WriteLine(_ui [_ui-1]);
                            break;
                        }
                    default:
                        {
                            Console.Write("There is no array element for this index.\nTry index between 1 and 3.\n\n");
                      break;
                        }
                }
                //if (_check01)

                //Console.WriteLine(_i[_ui - 1]);

            }
        }
    }
}
